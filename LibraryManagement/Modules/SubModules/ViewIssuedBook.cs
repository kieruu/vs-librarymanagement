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
    public partial class ViewIssuedBook : UserControl
    {

        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtIssued = new DataTable();
        public bool isVisible { get; set; } = false;
        private static ViewIssuedBook _instance;

        private string issuedTableQuery = "SELECT i.issued_id, s.first_name || ' ' || s.last_name AS 'full_name',  " +
            "s.section, b.book_title, i.date_issued " +
            "FROM book_issued as i, student as s, book as b " +
            "WHERE i.student_id = s.student_id " +
            "AND i.book_id = b.book_id";

        public static ViewIssuedBook Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ViewIssuedBook();
                }
                return _instance;
            }
        }

        public void ReloadTable()
        {
            if (isVisible)
            {
                db.RetrieveToTable(dtIssued, dgvIssued, issuedTableQuery);
                this.isVisible = false;
            }
        }

        private void CheckStatus(Label date, DataGridViewCellEventArgs e)
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
            else if (res == 0)
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
                lblStatus.Text = "OVERDUE - " + totalDates + " DAY(S) LATE";
                lblStatus.ForeColor = Color.FromArgb(240, 52, 52);
            }
        }

        private void ReturnBook(bool isBookLost = false)
        {
            if (!lblIssueID.Text.Equals("-"))
            {
                string deleteIssuedBook = "DELETE FROM book_issued WHERE issued_id = @id";
                string increaseBookQuantity = "UPDATE book SET quantity = quantity + 1 " +
                    "WHERE book_id = @id";

                string getStudentId = "SELECT student_id FROM student WHERE student_number = @studnum";
                string logReturn = "INSERT INTO log_return(book_return_id,student_id) " +
                    "VALUES(@bookid, @studentid)";

                db.Query(deleteIssuedBook,
                    new string[] { "@id" },
                    new string[] { lblIssueID.Text });

                if (!isBookLost)
                {
                    db.Query(increaseBookQuantity,
                        new string[] { "@id" },
                        new string[] { lblBookId.Text });
                }

                string[] arr = db.RetrieveRowValues(getStudentId,
                    new string[] { "@studnum" },
                    new string[] { lblStudNum.Text },
                    new string[] { "student_id" });
                db.Query(logReturn,
                    new string[] { "@bookid", "@studentid" },
                    new string[] { lblBookId.Text, arr[0] });

                db.RetrieveToTable(dtIssued, dgvIssued, issuedTableQuery);

                // clear label text in details
                func.ReplaceLabel(new Label[] {lblIssueID,lblBookId,lblBookTitle,lblAuthor,lblStudNum,
                    lblFullName,lblSection,lblIssueDate,lblReturnDate,lblPenaltyFee,lblStatus},"-");
                lblStatus.ForeColor = Color.Black;
            }
            else MessageBox.Show("Please select issued book.");
        }

        public ViewIssuedBook()
        {
            InitializeComponent();
        }

        private void IssuedBook_Load(object sender, EventArgs e)
        {
            dgvIssued.Columns[0].Width = 90;
            dgvIssued.Columns[2].Width = 90;

            db.RetrieveToTable(dtIssued, dgvIssued, issuedTableQuery);

            func.DataGridHeaderToComboBox(dgvIssued, comboBoxSort);
            comboBoxSort.Enabled = false;
        }

        private void dgvIssued_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT b.book_id,b.book_title,b.book_author, " +
                "s.student_number as studnum, s.first_name || ' ' || s.last_name as full_name, s.section, " +
                "i.date_issued, i.date_return " +
                "FROM book_issued as i ,book as b, student as s " +
                "WHERE i.book_id = b.book_id " +
                "AND i.student_id = s.student_id " +
                "AND i.issued_id = @issue_id";
            string[] info = db.RetrieveRowValues(query,
                new string[] { "issue_id" },
                new string[] { func.DataGridRowToString(dgvIssued, 0, e) },
                new string[] { "book_id","book_title","book_author","studnum","full_name",
                "section","date_issued","date_return"} );

            Label[] lblInfo = {lblBookId,lblBookTitle,lblAuthor, lblStudNum,lblFullName,lblSection,
            lblIssueDate,lblReturnDate};

            lblIssueID.Text = func.DataGridRowToString(dgvIssued, 0, e);
            for (int i=0; i < info.Length ; i++)
            {
                lblInfo[i].Text = info[i];
            }

            CheckStatus(lblReturnDate, e);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            func.FilterTable(dtIssued, dgvIssued, txtBoxSearch, comboBoxSort, chkBoxSearch);
        }

        private void chkBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxSearch.Checked)
            {
                comboBoxSort.Enabled = false;
            }
            else
            {
                comboBoxSort.Enabled = true;
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string notice = "You manually return the book from the student.\nDo you want to procced?";
            DialogResult dr = MessageBox.Show(notice, "Notice", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                ReturnBook();
            }
        }

        private void btnRemoveFromTheList_Click(object sender, EventArgs e)
        {
            string notice = "You're about to remove the issued book from the list, select this option if the book is lost. " +
                "Do you want to proceed?";
            DialogResult dr = MessageBox.Show(notice, "Notice", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ReturnBook(true);
            }
        }
    }
}
