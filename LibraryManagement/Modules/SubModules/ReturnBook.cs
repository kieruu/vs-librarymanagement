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
    public partial class ReturnBook : UserControl
    {

        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtIssued = new DataTable();
        private static ReturnBook _instance;

        public string AccessName { get; set; } = "";
        // determine if the user control is visible in main menu
        public bool isVisible { get; set; } = false;

        private string issuedBookQuery = "SELECT i.issued_id, b.book_title, i.date_issued " +
            "FROM book as b, book_issued as i " +
            "WHERE b.book_id = i.book_id " +
            "AND i.student_id = @id";


        public static ReturnBook Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ReturnBook();
                }
                return _instance;
            }
        }

        public void ShowIssuedBook()
        {
            if (isVisible)
            {
                string getStudentId = "SELECT student_id FROM student WHERE first_name = @name";
                string[] arr = db.RetrieveRowValues(getStudentId,
                    new string[] { "@name" },
                    new string[] { this.AccessName },
                    new string[] { "student_id" });

                db.RetrieveToTable(dtIssued, dgvIssuedBook, issuedBookQuery,
                new string[] { "@id" },
                new string[] { arr[0] });
            }
        }

        private void CheckStatus(Label date,DataGridViewCellEventArgs e)
        {
            // selecting the header result in exception thus, must return nothing.
            if (e.RowIndex == -1) return;

            DateTime currentDate = DateTime.Today;
            DateTime paramDate = DateTime.Parse(date.Text);


            int res = DateTime.Compare(currentDate, paramDate);

            lblPenaltyFee.Text = "-";
            lblStatus.ForeColor = Color.FromArgb(0, 177, 106);
            if (res < 0)
            {
                lblStatus.Text = "EARLY";
            }
            else if(res == 0)
            {
                lblStatus.Text = "ON TIME";
            }
            else
            {
                string getChargeFee = "SELECT charge_fee FROM charge_fee";

                double totalDates = (currentDate - paramDate).TotalDays;
                string[] arr = db.RetrieveRowValues(getChargeFee,
                    new string[] { },
                    new string[] { },
                    new string[] { "charge_fee" });

                lblPenaltyFee.Text = (totalDates * Convert.ToInt32(arr[0])).ToString();
                lblStatus.Text = "OVERDUE - "+totalDates+" DAY(S) LATE";
                lblStatus.ForeColor = Color.FromArgb(240, 52, 52);
            }
        }

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
        }

        private void dgvIssuedBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string getDetails = "SELECT b.book_id,b.book_author,b.book_page,i.date_return " +
                "FROM book as b, book_issued as i " +
                "WHERE i.book_id = b.book_id " +
                "AND i.issued_id = @id";

            string[] details = db.RetrieveRowValues(getDetails,
                new string[] { "@id" },
                new string[] { func.DataGridRowToString(dgvIssuedBook, 0, e) },
                new string[] { "book_id", "book_author", "book_page", "date_return" });

            lblIssuedId.Text = func.DataGridRowToString(dgvIssuedBook, 0, e);
            lblBookTitle.Text = func.DataGridRowToString(dgvIssuedBook, 1, e);
            lblDateIssued.Text = func.DataGridRowToString(dgvIssuedBook, 2, e);

            Label[] label = { lblBookId,lblAuthor, lblPage, lblReturnDate };
            for(int i=0; i < label.Length; i++)
            {
                label[i].Text = details[i];
            }

            // determine if the student return book is late or not.
            CheckStatus(lblReturnDate,e);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (!lblIssuedId.Text.Equals("-"))
            {
                string deleteIssuedBook = "DELETE FROM book_issued WHERE issued_id = @id";
                string increaseBookQuantity = "UPDATE book SET quantity = quantity + 1 " +
                    "WHERE book_id = @id";

                string getStudentId = "SELECT student_id FROM student WHERE first_name = @name";
                string logReturn = "INSERT INTO log_return(book_return_id,student_id) " +
                    "VALUES(@bookid, @studentid)";

                db.Query(deleteIssuedBook,
                    new string[] { "@id" },
                    new string[] { lblIssuedId.Text });

                db.Query(increaseBookQuantity,
                    new string[] { "@id" },
                    new string[] { lblBookId.Text });

                string[] arr = db.RetrieveRowValues(getStudentId,
                    new string[] { "@name" },
                    new string[] { this.AccessName },
                    new string[] { "student_id" });
                db.Query(logReturn,
                    new string[] { "@bookid", "@studentid" },
                    new string[] { lblBookId.Text, arr[0] });

                db.RetrieveToTable(dtIssued, dgvIssuedBook, issuedBookQuery,
                    new string[] { "@id" },
                    new string[] { arr[0] });

                // clear label text in details
                func.ReplaceLabel(new Label[] {lblIssuedId,lblBookId,lblBookTitle,lblAuthor,lblAuthor,
                lblPage,lblDateIssued,lblReturnDate,lblStatus,lblPenaltyFee}, "-");
                lblStatus.ForeColor = Color.Black;
            }
            else MessageBox.Show("Please select issued book.");
        }
    }
}
