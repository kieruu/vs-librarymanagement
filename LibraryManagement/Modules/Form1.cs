using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Libraries;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {

        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtAccount = new DataTable();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            db.RetrieveToTable(dtAccount, dataGridView1, "SELECT id,username,status FROM account");
            func.DataGridHeaderToComboBox(dataGridView1, comboBox1);
       
            //  MessageBox.Show(sb.ToString());

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.DataGridRowToTextBox(dataGridView1, new TextBox[] {txtBoxId,txtBoxUser,txtBoxStatus}, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool isSuccess = db.Query("INSERT INTO account(username,password) VALUES(@user,@pass)",
                new string[] { "@user","pass"},
                new string[] { txtBoxUser.Text,txtBoxPassword.Text});

            if (isSuccess)
            {
                MessageBox.Show("Successfully Added!");
                db.RetrieveToTable(dtAccount, dataGridView1,  "SELECT id,username,status FROM account");
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isDeleted = db.Query("DELETE FROM account WHERE id="+txtBoxId.Text);

            if (isDeleted)
            {
                MessageBox.Show("Successfully Deleted!");
                db.RetrieveToTable(dtAccount,dataGridView1,  "SELECT id,username,status FROM account");
            }
            else
            {
                MessageBox.Show("Failed Deleted!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isUpdated = db.Query("UPDATE account SET username = @user, password = @pass WHERE id = @id",
                new string[] {"@user","@pass","@id"},
                new string[] {txtBoxUser.Text,txtBoxPassword.Text,txtBoxId.Text });

            if (isUpdated)
            {
                MessageBox.Show("Successfully Updated!");
                db.RetrieveToTable(dtAccount,dataGridView1,  "SELECT id,username,status FROM account");
            }
            else
            {
                MessageBox.Show("Failed Update!");
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
           func.FilterTable(dtAccount,dataGridView1, txtBoxSearch,comboBox1,chkBoxSort);
        }

        private void chkBoxSort_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxSort.Checked)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void txtBoxNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                string pattern = @"^2[0]{3}[0-9]{6}$";
                if (Regex.IsMatch(txtBoxNum.Text, pattern))
                {
                    MessageBox.Show("Match!");
                }
                else
                {
                    MessageBox.Show("No match");
                }
            }

        }
    }
}
