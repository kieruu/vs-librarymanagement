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
    public partial class RegisterStudent : UserControl
    {

        private static RegisterStudent _instance;

        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtStudent = new DataTable();

        private string studentTableQuery = "SELECT student_number,first_name,last_name, section " +
            "FROM student";

        // pattern for student number e.g. 200042002
        private string patternStudentNumber = @"^2[0]{3}[0-9]{6}$";


        public static RegisterStudent Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new RegisterStudent();
                }
                return _instance;
            }
        }


        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            db.RetrieveToTable(dtStudent, dgvStudent, studentTableQuery);
            func.DataGridHeaderToComboBox(dgvStudent, comboBoxSort);
            comboBoxSort.Enabled = false;

            func.SetPlaceHolder(txtBoxAddStudNum, "2000<6-digit>");

            func.JumpToSection(lblOption1, btnClear1,this);
            func.JumpToSection(lblOption2, dgvStudent,this);
            func.JumpToSection(lblOption3, btnClear2,this);
            func.JumpToSection(lblBackToTop, label17,this);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            func.FilterTable(dtStudent, dgvStudent, txtBoxSearch, comboBoxSort, chkBoxSearch);
        }

        private void chkBoxSort_CheckedChanged(object sender, EventArgs e)
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

        

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.DataGridRowToTextBox(dgvStudent, new TextBox[] { txtBoxOldStudNum, txtBoxStudFName, txtBoxStudLName, txtBoxStudSection }, e);

            string pass = "SELECT password FROM account " +
                "WHERE username = @user";
            string[] arr = db.RetrieveRowValues(pass,
                new string[] { "@user" },
                new string[] { func.DataGridRowToString(dgvStudent, 0, e) },
                new string[] { "password" });

            txtBoxOldPassword.Text = arr[0];
        }


        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            bool isValidStudentId = func.IsStringMatchToRegex(txtBoxAddStudNum.Text, patternStudentNumber);
            bool isTextBoxFilled = func.IsStringNotEmpty(new string[] { txtBoxAddStudNum.Text,
            txtBoxAddFName.Text, txtBoxAddLName.Text, txtBoxAddSection.Text });

            string isAlreadyExist = "SELECT student_number FROM student " +
                "WHERE student_number = @studnum";

            string add = "INSERT INTO student(student_number,first_name,last_name,section) " +
                "VALUES(@stud_num, @fname, @lname, @section)";

            string addStudentAccount = "INSERT INTO account(username,password,status) " +
                "VALUES(@name, @password, @status)";

            if(isTextBoxFilled)
            {
                if (isValidStudentId)
                {
                    bool alreadyExist = db.Query(isAlreadyExist,
                    new string[] { "@studnum" },
                    new string[] { txtBoxAddStudNum.Text });

                    if (!alreadyExist)
                    {
                        string accountDefaultPassword = func.ToUpperFirstLetter(txtBoxAddLName.Text) +
                            txtBoxAddStudNum.Text.Substring(txtBoxAddStudNum.Text.Length - 4);

                        db.Query(add,
                            new string[] { "@stud_num", "@fname", "@lname", "@section" },
                            new string[] { txtBoxAddStudNum.Text, func.ToUpperFirstLetter(txtBoxAddFName.Text),
                                func.ToUpperFirstLetter(txtBoxAddLName.Text), txtBoxAddSection.Text.ToUpper() });

                        db.Query(addStudentAccount,
                            new string[] { "@name", "@password", "@status" },
                            new string[] { txtBoxAddStudNum.Text, accountDefaultPassword, "student" });

                        db.RetrieveToTable(dtStudent, dgvStudent, studentTableQuery);
                        func.ClearTextInTextBox(new TextBox[] { txtBoxAddStudNum, txtBoxAddFName, txtBoxAddLName, txtBoxAddSection });

                    }
                    else MessageBox.Show("Student number already exist. Please try another.");
                    
                }
                else MessageBox.Show("Invalid student number. Must be in 10 digits followed by format.\ne.g. 2000042002");
              
            }
            else MessageBox.Show("You must fill out the form.");
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string edit = "UPDATE student SET student_number = @new_stud_num, first_name = @fname, " +
                "last_name = @lname, section = @section " +
                "WHERE student_number = @old_stud_num";

            string editStudentAccount = "UPDATE account SET username = @user, password = @pass " +
                "WHERE username = @old_stud_num";

            string newStudNum = txtBoxNewStudNum.Text;
            string newPass = txtBoxNewPassword.Text;
            bool isStudentId;
            bool isTextBoxFilled;

            
            if (txtBoxNewStudNum.Text.ToString().Trim().Equals(""))
            {
                newStudNum = txtBoxOldStudNum.Text;
            }

            if (txtBoxNewPassword.Text.ToString().Trim().Equals(""))
            {
                newPass = txtBoxOldPassword.Text;
            }

            isStudentId = func.IsStringMatchToRegex(newStudNum, patternStudentNumber);
            isTextBoxFilled = func.IsStringNotEmpty(new string[] { txtBoxStudFName.Text, txtBoxStudLName.Text,
                txtBoxStudSection.Text});

            if (isTextBoxFilled)
            {
                if (isStudentId)
                {
                    db.Query(edit,
                        new string[] { "new_stud_num", "@fname", "@lname", "@section", "@old_stud_num" },
                        new string[] { newStudNum,func.ToUpperFirstLetter(txtBoxStudFName.Text),
                        func.ToUpperFirstLetter(txtBoxStudLName.Text),txtBoxStudSection.Text.ToUpper(),
                        txtBoxOldStudNum.Text});

                    db.Query(editStudentAccount,
                        new string[] { "@user", "@pass", "@old_stud_num" },
                        new string[] { newStudNum, newPass, txtBoxOldStudNum.Text });

                    db.RetrieveToTable(dtStudent, dgvStudent, studentTableQuery);

                    func.ClearTextInTextBox(new TextBox[] { txtBoxOldStudNum,txtBoxNewStudNum,txtBoxStudFName,txtBoxStudLName,
                        txtBoxNewPassword,txtBoxOldPassword,txtBoxStudSection});
                }
                else
                {
                    MessageBox.Show("Invalid student number.\nMust be in 10 digits followed by format.");
                }
            }
            else MessageBox.Show("Please fill out the form.");
            
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!txtBoxOldStudNum.Text.Equals(""))
            {
                string getStudentId = "SELECT student_id FROM student WHERE student_number = @studnum";
                string isStudentIssuedBook = "SELECT i.student_id FROM book_issued as i, student as s " +
                    "WHERE i.student_id = s.student_id " +
                    "AND s.student_id = @studid";
                string delete = "DELETE FROM student WHERE student_number = @stud_num";
                string deleteStudentAccount = "DELETE FROM account WHERE username = @stud_num";

                string[] arr = db.RetrieveRowValues(getStudentId,
                    new string[] { "@studnum" },
                    new string[] { txtBoxOldStudNum.Text },
                    new string[] { "student_id" });

                bool hasIssuedBook = db.Query(isStudentIssuedBook,
                    new string[] { "@studid" },
                    new string[] { arr[0] });

                // if student don't borrow book/s
                if (!hasIssuedBook)
                {
                    db.Query(delete,
                    new string[] { "@stud_num" },
                    new string[] { txtBoxOldStudNum.Text });

                    db.Query(deleteStudentAccount,
                        new string[] { "@stud_num" },
                        new string[] { txtBoxOldStudNum.Text });

                    db.RetrieveToTable(dtStudent, dgvStudent, studentTableQuery);

                    func.ClearTextInTextBox(new TextBox[] { txtBoxOldStudNum,txtBoxNewStudNum,txtBoxStudFName,txtBoxStudLName,
                    txtBoxNewPassword,txtBoxOldPassword,txtBoxStudSection});
                }
                else MessageBox.Show("You cannot remove student while having issued book/s.");
                
            }
            else MessageBox.Show("Select a student from the table.");
            
        }
        
        private void btnClear1_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxAddStudNum, txtBoxAddFName, txtBoxAddLName, txtBoxAddSection });
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxOldStudNum,txtBoxNewStudNum,txtBoxStudFName,txtBoxStudLName,
                txtBoxNewPassword,txtBoxOldPassword,txtBoxStudSection});
        }

    }
}
