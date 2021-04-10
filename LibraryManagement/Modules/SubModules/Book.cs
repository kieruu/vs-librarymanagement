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
    public partial class Book : UserControl
    {
        private static Book _instance;

        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtBook = new DataTable();
        // determine if the user control is visible in main menu
        public bool isVisible { get; set; } = false;

        private string bookID = "";


        private string bookTableQuery = "SELECT b.book_id, b.book_title ,b.book_author, b.book_page, c.category_name " +
                "FROM book AS b, book_category AS c " +
                "WHERE b.category_id = c.category_id";


        public static Book Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Book();
                }
                return _instance;
            }
        }

        // update category combobox if new category is added
        public void reloadComboBox(bool visible)
        {
            if (visible)
            {
                comboBoxCategory1.Items.Clear();
                comboBoxCategory2.Items.Clear();
                db.RetrieveColumnValueToComboBox(comboBoxCategory1, "SELECT category_name FROM book_category", "category_name");
                db.RetrieveColumnValueToComboBox(comboBoxCategory2, "SELECT category_name FROM book_category", "category_name");
                db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);
                this.isVisible = false;
            }
        }

        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);
            func.DataGridHeaderToComboBox(dgvBook, comboBoxSearch);

            // disable comboboxSearch by default
            comboBoxSearch.Enabled = false;
            comboBoxSort.Enabled = false;

            // specifically set the width of a table columns
            dgvBook.Columns[0].Width = 60;
            dgvBook.Columns[3].Width = 70;
            dgvBook.Columns[4].Width = 110;

            // clicking the option on the left side jump the screen to specific section.
            func.JumpToSection(lblOption1, btnClear1, this);
            func.JumpToSection(lblOption2, btnClear2, this);
            func.JumpToSection(lblOption3, btnClear3, this);
            func.JumpToSection(lblBackToTop, txtBoxSearch, this);

        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBoxSort_CheckedChanged(object sender, EventArgs e)
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

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            func.FilterTable(dtBook, dgvBook, txtBoxSearch, comboBoxSearch, chkBoxSearch);
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.DataGridRowToTextBox(dgvBook, new TextBox[] { txtBoxId, txtBoxTitle, txtBoxAuthor, txtBoxPage }, e);
            func.DataGridRowToCombobox(dgvBook, 4, comboBoxCategory1, e);

            this.bookID = func.DataGridRowToString(dgvBook, 0, e);
            string[] arr = db.RetrieveRowValues("SELECT quantity FROM book WHERE book_id = @id",
                new string[] { "@id" },
                new string[] { this.bookID },
                new string[] { "quantity" });

            txtBoxQuantity.Text = arr[0];
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            string edit = "UPDATE book SET book_title = @title, book_author = @author, " +
                "book_page = @page, category_id = @category " +
                "WHERE book_id = @id";
            string getCategory = "SELECT category_id FROM book_category WHERE category_name = @name";

            string[] arr = db.RetrieveRowValues(getCategory,
                new string[] { "@name" },
                new string[] { comboBoxCategory1.Text },
                new string[] { "category_id" });


            if (!txtBoxId.Text.Trim().Equals(""))
            {
                bool isTextBoxFilled = func.IsStringNotEmpty(new string[]
                {txtBoxTitle.Text,txtBoxAuthor.Text,txtBoxPage.Text,
                    comboBoxCategory1.GetItemText(comboBoxCategory1.SelectedItem) });

                if (isTextBoxFilled)
                {
                    db.Query(edit,
                        new string[] { "@title", "@author", "@page", "@category", "@id" },
                        new string[] { txtBoxTitle.Text, txtBoxAuthor.Text, txtBoxPage.Text, arr[0], txtBoxId.Text });

                    db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);

                    func.ClearTextInTextBox(new TextBox[] { txtBoxId, txtBoxPage, txtBoxQuantity, txtBoxTitle, txtBoxAuthor });
                    func.ClearTextInComboBox(new ComboBox[] { comboBoxCategory1 });
                }
                else MessageBox.Show("Fill out the form.");

            }
            else MessageBox.Show("Select book from the table.");

        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM book WHERE book_id = @id";
            string isBookIssued = "SELECT i.book_id FROM book_issued as i, book as b " +
                "WHERE i.book_id = b.book_id " +
                "AND b.book_id = @bookid";

            if (!txtBoxId.Text.Trim().Equals(""))
            {
                bool isIssued = db.Query(isBookIssued,
                    new string[] { "@bookid" },
                    new string[] { txtBoxId.Text });

                // if no issued book is found
                if (!isIssued)
                {
                    db.Query(delete,
                    new string[] { "@id" },
                    new string[] { txtBoxId.Text });

                    db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);

                    func.ClearTextInTextBox(new TextBox[] { txtBoxId, txtBoxPage, txtBoxQuantity, txtBoxTitle, txtBoxAuthor });
                    func.ClearTextInComboBox(new ComboBox[] { comboBoxCategory1 });
                }
                else MessageBox.Show("You cannot delete book while its issued by student/s.");
            }
            else MessageBox.Show("Select book from the table.");
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO book(book_title, book_author, book_page, category_id) " +
                "VALUES(@title, @author, @page, @categoryid)";
            string getCategory = "SELECT category_id FROM book_category WHERE category_name = @name";

            string[] arr = db.RetrieveRowValues(getCategory,
                new string[] { "@name" },
                new string[] { comboBoxCategory2.Text },
                new string[] { "category_id" });

            bool isTextBoxFilled = func.IsStringNotEmpty(new string[]
            {txtBoxAddTitle.Text,txtBoxAddAuthor.Text,txtBoxAddPage.Text,
            comboBoxCategory2.GetItemText(comboBoxCategory2.SelectedItem)});

            if (isTextBoxFilled)
            {
                db.Query(add,
                new string[] { "@title", "@author", "@page", "@categoryid" },
                new string[] { txtBoxAddTitle.Text, txtBoxAddAuthor.Text, txtBoxAddPage.Text, arr[0] });

                db.RetrieveToTable(dtBook, dgvBook, bookTableQuery);

                func.ClearTextInTextBox(new TextBox[] { txtBoxAddTitle, txtBoxAddAuthor, txtBoxAddPage });
                func.ClearTextInComboBox(new ComboBox[] { comboBoxCategory2 });
            }
            else MessageBox.Show("Fill out the form.");

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (!txtBoxId.Text.Trim().Equals(""))
            {
                bool isTextBoxFilled = func.IsStringNotEmpty(new string[] { txtBoxAddStock.Text });
                bool isNumber = func.IsStringMatchToRegex(txtBoxAddStock.Text, "^[0-9]{1,2}$");

                if (isTextBoxFilled && isNumber)
                {
                    bool limit = Convert.ToInt32(txtBoxAddStock.Text) <= 99 && Convert.ToInt32(txtBoxAddStock.Text) >= 1;
                    if (limit)
                    {
                        db.Query("UPDATE book SET quantity = quantity + @quantity WHERE book_id = @id",
                            new string[] { "@quantity", "@id" },
                            new string[] { txtBoxAddStock.Text, this.bookID });

                        func.ClearTextInTextBox(new TextBox[] { txtBoxId, txtBoxPage, txtBoxQuantity, txtBoxTitle, txtBoxAuthor, txtBoxAddStock });
                        func.ClearTextInComboBox(new ComboBox[] { comboBoxCategory1 });
                    }
                    else MessageBox.Show("Input must be greater than 1 and less than 99.");
                }
                else MessageBox.Show("Invalid Quantity.");
            }
            else MessageBox.Show("Select book from the table.");

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxId, txtBoxPage, txtBoxQuantity, txtBoxTitle, txtBoxAuthor });
            func.ClearTextInComboBox(new ComboBox[] { comboBoxCategory1 });
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxAddStock });
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxAddTitle, txtBoxAddAuthor, txtBoxAddPage });
            func.ClearTextInComboBox(new ComboBox[] { comboBoxCategory2 });
        }

        private void chkBoxSort_CheckedChanged_1(object sender, EventArgs e)
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
