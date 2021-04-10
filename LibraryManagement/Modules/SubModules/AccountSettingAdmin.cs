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
    public partial class AccountSettingAdmin : UserControl
    {
        private static AccountSettingAdmin _instance;

        private Database db = new Database("library");
        private Function func = new Function();
        private string getCurrentName = "SELECT username FROM account WHERE status = \"admin\"";

        public static AccountSettingAdmin Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AccountSettingAdmin();
                }
                return _instance;
            }
        }

        public AccountSettingAdmin()
        {
            InitializeComponent();
        }

        private void AccountSettingAdmin_Load(object sender, EventArgs e)
        {
            string chargeFee = "SELECT charge_fee FROM charge_fee";

            string[] arr = db.RetrieveRowValues(chargeFee,
                new string[] { },
                new string[] { },
                new string[] { "charge_fee" });
            string[] arr2 = db.RetrieveRowValues(getCurrentName,
                new string[] { },
                new string[] { },
                new string[] { "username" });

            txtBoxCurrentChargeFee.Text = arr[0];
            txtBoxCurrentName.Text = arr2[0];

            func.JumpToSection(lblOption1, btnClear1, this);
            func.JumpToSection(lblOption2, btnClear2, this);
            func.JumpToSection(lblBackToTop, label13, this);

            txtBoxOldPass.PasswordChar = '\u25CF';
            txtBoxNewPass.PasswordChar = '\u25CF';
            txtBoxRepeatNewPass.PasswordChar = '\u25CF';
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            string update = "UPDATE account SET password = @pass WHERE status = \"admin\"";
            string getOldPassword = "SELECT password FROM account WHERE password = @pass";

            bool limitPassword = txtBoxRepeatNewPass.Text.Length >= 6 && txtBoxRepeatNewPass.Text.Length <= 64;

            bool isOldPass = db.Query(getOldPassword,
                new string[] { "@pass" },
                new string[] { txtBoxOldPass.Text });

            if (isOldPass)
            {
                if (txtBoxNewPass.Text.Equals(txtBoxRepeatNewPass.Text))
                {
                    if (limitPassword)
                    {
                        bool updatePassword = db.Query(update,
                            new string[] { "@pass" },
                            new string[] { txtBoxRepeatNewPass.Text });

                        if (updatePassword)
                        {
                            MessageBox.Show("Password Change Successs!");
                        }

                    }
                    else MessageBox.Show("Password must be 6-32 characters.");
                }
                else MessageBox.Show("New Password doesn't match.");
            }
            else MessageBox.Show("Old Password Incorrect.");
        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            string updateUsername = "UPDATE account SET username = @user WHERE status = \"admin\"";
            bool limit = txtBoxNewName.Text.Length >= 4 && txtBoxNewName.Text.Length <= 32;

            if (!txtBoxNewName.Text.Trim().Equals(""))
            {
                if (limit)
                {
                    db.Query(updateUsername,
                        new string[] { "@user" },
                        new string[] { txtBoxNewName.Text });

                    string[] arr2 = db.RetrieveRowValues(getCurrentName,
                        new string[] { },
                        new string[] { },
                        new string[] { "username" });

                    txtBoxCurrentName.Text = arr2[0];
                    txtBoxNewName.Text = "";

                }
                else MessageBox.Show("Name must be 4-32 characters");

            }
            else MessageBox.Show("Enter your name.");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string setFee = "UPDATE charge_fee SET charge_fee = @fee";
            bool isDigit = func.IsStringMatchToRegex(txtBoxSetChargeFee.Text, @"^[0-9]{1,2}$");

            if (isDigit)
            {
                db.Query(setFee,
                    new string[] { "@fee" },
                    new string[] { txtBoxSetChargeFee.Text });

                txtBoxSetChargeFee.Text = "";

                string chargeFee = "SELECT charge_fee FROM charge_fee";
                string[] arr = db.RetrieveRowValues(chargeFee,
                    new string[] { },
                    new string[] { },
                    new string[] { "charge_fee" });
                txtBoxCurrentChargeFee.Text = arr[0];
            }
            else MessageBox.Show("Invalid Input.");
        }

    }


}
