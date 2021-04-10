using LibraryManagement.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Modules
{
    public partial class Login : Form
    {

        private Database db = new Database("library");
        private Function func = new Function();

        private void showForm(string name,string status)
        {
            Application.Run(new MainMenu(name,status));
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = '\0';
            func.SetPlaceHolder(txtBoxUsername, "Username");
            func.SetPlaceHolder(txtBoxPassword, "Password", true);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string login = "SELECT username,status FROM account " +
                "WHERE username = @user AND password = @pass";
            string getFirstName = "SELECT first_name FROM student " +
                "WHERE student_number = @studnum";

            string name = "";
            string status = "";

            bool isLogin = db.Query(login,
                new string[] { "@user", "@pass" },
                new string[] { txtBoxUsername.Text, txtBoxPassword.Text });

            if (isLogin)
            {
                string[] arr = db.RetrieveRowValues(login,
                    new string[] { "@user", "@pass" },
                    new string[] { txtBoxUsername.Text, txtBoxPassword.Text },
                    new string[] { "username", "status" });

                name = arr[0];
                status = arr[1];

                if (status.Equals("student"))
                {
                    string[] arr2 = db.RetrieveRowValues(getFirstName,
                        new string[] { "@studnum" },
                        new string[] { name },
                        new string[] { "first_name" });

                    name = arr2[0];
                }

                this.Close();
                Thread th = new Thread(() => showForm(name, status));
                th.Start();

            }
            else MessageBox.Show("Invalid username/password.");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
