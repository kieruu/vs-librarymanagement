using LibraryManagement.Modules.SubModules;
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
    public partial class MainMenu : Form
    {
        private UserControl []userControlAdmin = { Book.Instance, RegisterStudent.Instance,ViewIssuedBook.Instance,AddCategory.Instance,AccountSettingAdmin.Instance, About.Instance};
        private UserControl[] userControlStudent = { SearchBook.Instance, ReturnBook.Instance, AccountSettingStudent.Instance,About.Instance };

        protected string status { get; set; }
        protected string name { get; set; }


        private void LoadAdminPanel()
        {
            foreach (UserControl a in userControlAdmin)
            {
                if (!panelContainer.Controls.Contains(a))
                {
                    panelContainer.Controls.Add(a);
                }
            }
        }

        private void LoadStudentPanel()
        {
            foreach (UserControl a in userControlStudent)
            {
                if (!panelContainer.Controls.Contains(a))
                {
                    panelContainer.Controls.Add(a);
                }
            }
        }

        private void HideAdminPanel()
        {
            foreach (UserControl a in userControlAdmin)
            {
                a.Visible = false;
            }
        }
        private void HideStudentPanel()
        {
            foreach (UserControl a in userControlStudent)
            {
                a.Visible = false;
            }
        }

        private void ShowLoginForm()
        {
            Application.Run(new Login());
        }



        public MainMenu(string name,string status)
        {
            this.name = name;
            this.status = status;
            InitializeComponent();
        }

        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + this.name + "!";
           
            if (this.status.Equals("admin"))
            {
                studentMenu.Hide();

                LoadAdminPanel();
                HideAdminPanel();

                lblModules.Text = "Books";
                Book.Instance.Visible = true;
                Book.Instance.isVisible = true;
                Book.Instance.reloadComboBox(Book.Instance.isVisible);
            }
            else
            {
                adminMenu.Hide();

                LoadStudentPanel();
                HideStudentPanel();

                lblModules.Text = "Search && Issue Book";
                SearchBook.Instance.AccessName = this.name;
                SearchBook.Instance.Visible = true;

            }

            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        
        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (!Book.Instance.Visible)
            {
                lblModules.Text = "Books";
                HideAdminPanel();
                Book.Instance.Visible = true;
                Book.Instance.isVisible = true;
                Book.Instance.reloadComboBox(Book.Instance.isVisible);
            }
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            if (!RegisterStudent.Instance.Visible)
            {
                lblModules.Text = "Student Info";
                HideAdminPanel();
                RegisterStudent.Instance.Visible = true;
            }
            
        }

        private void btnViewIssuedBook_Click(object sender, EventArgs e)
        {
            if (!ViewIssuedBook.Instance.Visible)
            {
                lblModules.Text = "View Issued Book";
                HideAdminPanel();
                ViewIssuedBook.Instance.isVisible = true;
                ViewIssuedBook.Instance.ReloadTable();
                ViewIssuedBook.Instance.Visible = true;
            }
            
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            lblModules.Text = "View Student";
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!AddCategory.Instance.Visible)
            {
                lblModules.Text = "Add Book Category";
                HideAdminPanel();
                AddCategory.Instance.Visible = true;
            }
            
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (!SearchBook.Instance.Visible)
            {
                lblModules.Text = "Search && Issue Book";
                HideStudentPanel();
                SearchBook.Instance.AccessName = this.name;
                SearchBook.Instance.Visible = true;
            }
            

        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (!ReturnBook.Instance.Visible)
            {
                lblModules.Text = "Return Book";
                HideStudentPanel();
                ReturnBook.Instance.AccessName = this.name;
                ReturnBook.Instance.isVisible = true;
                ReturnBook.Instance.ShowIssuedBook();
                ReturnBook.Instance.Visible = true;
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(new ThreadStart(ShowLoginForm));
            thread.Start();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnAccountSettingStudent_Click(object sender, EventArgs e)
        {
            if (!AccountSettingStudent.Instance.Visible)
            {
                lblModules.Text = "Account Setting";
                HideStudentPanel();
                AccountSettingStudent.Instance.AccessName = this.name;
                AccountSettingStudent.Instance.Visible = true;
            }
            
        }

        private void btnAbout2_Click(object sender, EventArgs e)
        {
            if (!About.Instance.Visible)
            {
                lblModules.Text = "About";
                HideStudentPanel();
                About.Instance.Visible = true;
            }
            
        }

        private void btnAbout1_Click(object sender, EventArgs e)
        {
            if (!About.Instance.Visible)
            {
                lblModules.Text = "About";
                HideAdminPanel();
                About.Instance.Visible = true;
            }
        }

        private void btnAdminSetting_Click(object sender, EventArgs e)
        {
            if (!AccountSettingAdmin.Instance.Visible)
            {
                lblModules.Text = "Setting";
                HideAdminPanel();
                AccountSettingAdmin.Instance.Visible = true;
            }
        }
    }
}
