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
    public partial class AccountSettingStudent : UserControl
    {
        public string AccessName { get; set; } = "";
        private Database db = new Database("library");
        private Function func = new Function();
        private static AccountSettingStudent _instance;

        public static AccountSettingStudent Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AccountSettingStudent();
                }
                return _instance;
            }
        }

        public AccountSettingStudent()
        {
            InitializeComponent();
        }

        private void AccountSettingStudent_Load(object sender, EventArgs e)
        {
            txtBoxOldPass.PasswordChar = '\u25CF';
            txtBoxNewPass.PasswordChar = '\u25CF';
            txtBoxRepeatNewPass.PasswordChar = '\u25CF';
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string getStudentNumber = "SELECT student_number FROM student WHERE first_name = @studname";
            string getOldPassword = "SELECT password FROM account WHERE username = @studnum " +
                "AND password = @pass";
            string changePassword = "UPDATE account SET password = @pass WHERE username = @studnum";

            string[] arr = db.RetrieveRowValues(getStudentNumber,
                new string[] { "@studname" },
                new string[] { this.AccessName },
                new string[] { "student_number" });

            Console.WriteLine(arr[0]);

            bool isOldPass = db.Query(getOldPassword,
                new string[] { "@studnum","@pass" },
                new string[] { arr[0],txtBoxOldPass.Text});

            if (isOldPass)
            {
                bool isFilled = func.IsStringNotEmpty(new string[]{ txtBoxOldPass.Text,txtBoxRepeatNewPass.Text});
                if (isFilled)
                {
                    if (txtBoxNewPass.Text.Equals(txtBoxRepeatNewPass.Text))
                    {
                        db.Query(changePassword,
                        new string[] { "@pass", "@studnum" },
                        new string[] { txtBoxRepeatNewPass.Text, arr[0] });

                        func.ClearTextInTextBox(new TextBox[] { txtBoxOldPass, txtBoxNewPass, txtBoxRepeatNewPass });
                    }
                    else MessageBox.Show("New password is not match.");
                }
                else MessageBox.Show("Please fill out the form.");
            }
            else MessageBox.Show("Old Password is incorrect.");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] {txtBoxOldPass,txtBoxNewPass,txtBoxRepeatNewPass });
        }
    }
}
