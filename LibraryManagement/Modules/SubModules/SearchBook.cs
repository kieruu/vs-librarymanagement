using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Libraries;

namespace LibraryManagement.Modules.SubModules
{
    public partial class SearchBook : UserControl
    {
        private static SearchBook _instance;
        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtBook = new DataTable();
        private string bookTableQuery = "SELECT b.book_title ,b.book_author, c.category_name " +
            "FROM book AS b, book_category AS c " +
            "WHERE b.category_id = c.category_id";

        public string AccessName { get; set; } = "";

        public static SearchBook Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new SearchBook();
                }
                return _instance;
            }
        }

        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);
            func.DataGridHeaderToComboBox(dgvBook, comboBoxSearch);

            txtBoxCurrentDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            comboBoxSearch.Enabled = false;
            comboBoxSort.Enabled = false;

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            func.FilterTable(dtBook, dgvBook, txtBoxSearch, comboBoxSearch, chkBoxSearch);
        }

        private void chkBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxSearch.Checked)
            {
                comboBoxSearch.Enabled = false;
            }
            else
            {
                comboBoxSearch.Enabled = true;
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // selecting the header result in exception thus, must return nothing.
            if (e.RowIndex == -1) return;

            string getBook = "SELECT book_id,book_title,book_author,book_page, " +
                "category_id,quantity, strftime('%d/%m/%Y', created_at) as created_at " +
                "FROM book " +
                "WHERE book_title = @book";
            string getCategory = "SELECT c.category_name FROM book_category as c, book as b  " +
                "WHERE c.category_id = @book";

            string[] bookInfo = db.RetrieveRowValues(getBook,
                new string[] { "@book" },
                new string[] { func.DataGridRowToString(dgvBook, 0, e)},
                new string[] { "book_id","book_title","book_author","book_page","category_id","quantity",
                "created_at"});
            string[] categoryName = db.RetrieveRowValues(getCategory,
                new string[] { "@book" },
                new string[] { bookInfo[4] },
                new string[] { "category_name"});
           
            lblBookId.Text = bookInfo[0];
            lblBookTitle.Text = bookInfo[1];
            lblAuthor.Text = bookInfo[2];
            lblPage.Text = bookInfo[3];
            lblCategory.Text = categoryName[0];
            lblDate.Text = bookInfo[6];

            int quantity = Convert.ToInt32(bookInfo[5]);

            if(quantity > 0)
            {
                lblAvailability.Text = "AVAILABLE";
                lblAvailability.ForeColor = Color.FromArgb(0, 177, 106);
            }
            else
            {
                lblAvailability.Text = "UNAVAILABLE";
                lblAvailability.ForeColor = Color.FromArgb(240, 52, 52);
            }

        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            DateTime temp;
            // check if book is selected or not
            if (!lblAvailability.Text.Equals("-"))
            {
                // check if book is available or not
                if (lblAvailability.Text.Equals("AVAILABLE"))
                {
                    string getStudentId = "SELECT student_id FROM student WHERE first_name = @studname";
                    string checkIfAlreadyBorrowed = "SELECT bi.issued_id, bi.student_id FROM book_issued as bi, student as s, book as b " +
                        "WHERE bi.student_id = @studid AND bi.student_id = s.student_id " +
                        "AND bi.book_id = @bookid AND bi.book_id = b.book_id";

                    string[] arr = db.RetrieveRowValues(getStudentId,
                                new string[] { "@studname" },
                                new string[] { this.AccessName },
                                new string[] { "student_id" });

                    bool isBorrowed = db.Query(checkIfAlreadyBorrowed,
                        new string[] { "@studid","@bookid"},
                        new string[] { arr[0],  lblBookId.Text});

                    // check if the user already borrow the book.
                    if (!isBorrowed)
                    {
                        // check if date is in the correct format
                        if (DateTime.TryParse(txtBoxReturnDate.Text, out temp) &&
                            func.IsStringMatchToRegex(txtBoxReturnDate.Text, "^[0-9]{2}\\/[0-9]{2}\\/[0-9]{4}$"))
                        {
                            DateTime returnDate = DateTime.Parse(txtBoxReturnDate.Text);
                            // substraction of current date and return date
                            TimeSpan diff = returnDate - DateTime.Today;
                            int daysGap = (int)diff.TotalDays;

                            // if date is greater than the current date and less than three weeks
                            if (returnDate > DateTime.Today && daysGap < 21)
                            {
                                string insertIssuedBook = "INSERT INTO book_issued(student_id,book_id,date_issued,date_return) " +
                                    "VALUES(@studid, @bookid, @dateissue, @datereturn)";
                                string decreaseQuantity = "UPDATE book SET quantity = quantity - 1 " +
                                    "WHERE book_id = @bookid";

                                bool isSuccess = db.Query(insertIssuedBook,
                                    new string[] { "@studid", "@bookid", "@dateissue", "@datereturn" },
                                    new string[] { arr[0], lblBookId.Text, txtBoxCurrentDate.Text, txtBoxReturnDate.Text });

                                if (isSuccess)
                                {
                                    MessageBox.Show("You successfully borrowed the book.");
                                    db.Query(decreaseQuantity,
                                    new string[] { "@bookid" },
                                    new string[] { lblBookId.Text });

                                    db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);

                                    func.ReplaceLabel(new Label[] {lblBookId,lblBookTitle,lblAuthor,
                                lblCategory,lblPage,lblDate,lblAvailability }, "-");
                                    lblAvailability.ForeColor = Color.Black;

                                    func.ClearTextInTextBox(new TextBox[] { txtBoxReturnDate });
                                }

                            }
                            else MessageBox.Show("Date must be greater than the current date and less than three weeks.");
                        }
                        else MessageBox.Show("Invalid Date format.");
                    }
                    else MessageBox.Show("Sorry, You already borrowed the book.");
                }
                else MessageBox.Show("Selected book is unavailable.");
            }
            else MessageBox.Show("Select book from the table.");

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtBoxReturnDate.Text = "";
        }

        private void chkBoxSort_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxSort.Checked)
            {
                comboBoxSort.Enabled = false;
                db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);
            }
            else
            {
                comboBoxSort.Enabled = true;
            }
        }

        private void comboBoxSort_SelectedValueChanged(object sender, EventArgs e)
        {
            string add = "``";
            switch (Convert.ToString(comboBoxSort.SelectedItem))
            {
                case "Available":
                    add = " AND quantity >= 1";
                    bookTableQuery += add;
                    db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);
                    break;
                case "Unavailable":
                    add = " AND quantity < 1";
                    bookTableQuery += add;
                    db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);
                    break;
            }
            bookTableQuery = bookTableQuery.Replace(add, "");
        }
    }
}
