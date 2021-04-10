namespace LibraryManagement.Modules
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnBooks = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.btnViewIssuedBook = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAdminSetting = new System.Windows.Forms.Button();
            this.btnAbout1 = new System.Windows.Forms.Button();
            this.studentMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnAccountSettingStudent = new System.Windows.Forms.Button();
            this.btnAbout2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblModules = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelProfile.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.adminMenu.SuspendLayout();
            this.studentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 0);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(278, 53);
            this.btnBooks.TabIndex = 91;
            this.btnBooks.Text = " Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Transparent;
            this.panelProfile.Controls.Add(this.lblTime);
            this.panelProfile.Controls.Add(this.lblDate);
            this.panelProfile.Controls.Add(this.lblWelcome);
            this.panelProfile.Controls.Add(this.label1);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(278, 202);
            this.panelProfile.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(28, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(67, 18);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "HH:mm tt";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(28, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "dd/mm/yyyy";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(176, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Admin!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.panelMainMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMainMenu.Controls.Add(this.panelProfile);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(278, 611);
            this.panelMainMenu.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.adminMenu);
            this.flowLayoutPanel1.Controls.Add(this.studentMenu);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 202);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 409);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // adminMenu
            // 
            this.adminMenu.Controls.Add(this.btnBooks);
            this.adminMenu.Controls.Add(this.btnRegisterStudent);
            this.adminMenu.Controls.Add(this.btnViewIssuedBook);
            this.adminMenu.Controls.Add(this.btnAddCategory);
            this.adminMenu.Controls.Add(this.btnAdminSetting);
            this.adminMenu.Controls.Add(this.btnAbout1);
            this.adminMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.adminMenu.Location = new System.Drawing.Point(0, 0);
            this.adminMenu.Margin = new System.Windows.Forms.Padding(0);
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(278, 319);
            this.adminMenu.TabIndex = 0;
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.FlatAppearance.BorderSize = 0;
            this.btnRegisterStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterStudent.Image")));
            this.btnRegisterStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterStudent.Location = new System.Drawing.Point(0, 53);
            this.btnRegisterStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegisterStudent.Size = new System.Drawing.Size(278, 53);
            this.btnRegisterStudent.TabIndex = 92;
            this.btnRegisterStudent.Text = " Register Student";
            this.btnRegisterStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // btnViewIssuedBook
            // 
            this.btnViewIssuedBook.FlatAppearance.BorderSize = 0;
            this.btnViewIssuedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIssuedBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIssuedBook.Image = ((System.Drawing.Image)(resources.GetObject("btnViewIssuedBook.Image")));
            this.btnViewIssuedBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewIssuedBook.Location = new System.Drawing.Point(0, 106);
            this.btnViewIssuedBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewIssuedBook.Name = "btnViewIssuedBook";
            this.btnViewIssuedBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnViewIssuedBook.Size = new System.Drawing.Size(278, 53);
            this.btnViewIssuedBook.TabIndex = 93;
            this.btnViewIssuedBook.Text = " View Issued Book";
            this.btnViewIssuedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewIssuedBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewIssuedBook.UseVisualStyleBackColor = true;
            this.btnViewIssuedBook.Click += new System.EventHandler(this.btnViewIssuedBook_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(0, 159);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddCategory.Size = new System.Drawing.Size(278, 53);
            this.btnAddCategory.TabIndex = 94;
            this.btnAddCategory.Text = " Add Book Category";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAdminSetting
            // 
            this.btnAdminSetting.FlatAppearance.BorderSize = 0;
            this.btnAdminSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminSetting.Image")));
            this.btnAdminSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminSetting.Location = new System.Drawing.Point(0, 212);
            this.btnAdminSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminSetting.Name = "btnAdminSetting";
            this.btnAdminSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminSetting.Size = new System.Drawing.Size(278, 53);
            this.btnAdminSetting.TabIndex = 95;
            this.btnAdminSetting.Text = " Setting";
            this.btnAdminSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminSetting.UseVisualStyleBackColor = true;
            this.btnAdminSetting.Click += new System.EventHandler(this.btnAdminSetting_Click);
            // 
            // btnAbout1
            // 
            this.btnAbout1.FlatAppearance.BorderSize = 0;
            this.btnAbout1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout1.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout1.Image")));
            this.btnAbout1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout1.Location = new System.Drawing.Point(0, 265);
            this.btnAbout1.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout1.Name = "btnAbout1";
            this.btnAbout1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout1.Size = new System.Drawing.Size(278, 53);
            this.btnAbout1.TabIndex = 96;
            this.btnAbout1.Text = " About";
            this.btnAbout1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout1.UseVisualStyleBackColor = true;
            this.btnAbout1.Click += new System.EventHandler(this.btnAbout1_Click);
            // 
            // studentMenu
            // 
            this.studentMenu.Controls.Add(this.btnSearchBook);
            this.studentMenu.Controls.Add(this.btnReturnBook);
            this.studentMenu.Controls.Add(this.btnAccountSettingStudent);
            this.studentMenu.Controls.Add(this.btnAbout2);
            this.studentMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.studentMenu.Location = new System.Drawing.Point(0, 319);
            this.studentMenu.Margin = new System.Windows.Forms.Padding(0);
            this.studentMenu.Name = "studentMenu";
            this.studentMenu.Size = new System.Drawing.Size(278, 212);
            this.studentMenu.TabIndex = 7;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBook.Image")));
            this.btnSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.Location = new System.Drawing.Point(0, 0);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearchBook.Size = new System.Drawing.Size(278, 53);
            this.btnSearchBook.TabIndex = 97;
            this.btnSearchBook.Text = " Search && Issue Book";
            this.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.Image")));
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 53);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(278, 53);
            this.btnReturnBook.TabIndex = 98;
            this.btnReturnBook.Text = " Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnAccountSettingStudent
            // 
            this.btnAccountSettingStudent.FlatAppearance.BorderSize = 0;
            this.btnAccountSettingStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettingStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSettingStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountSettingStudent.Image")));
            this.btnAccountSettingStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSettingStudent.Location = new System.Drawing.Point(0, 106);
            this.btnAccountSettingStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccountSettingStudent.Name = "btnAccountSettingStudent";
            this.btnAccountSettingStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccountSettingStudent.Size = new System.Drawing.Size(278, 53);
            this.btnAccountSettingStudent.TabIndex = 99;
            this.btnAccountSettingStudent.Text = " Account Setting";
            this.btnAccountSettingStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSettingStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountSettingStudent.UseVisualStyleBackColor = true;
            this.btnAccountSettingStudent.Click += new System.EventHandler(this.btnAccountSettingStudent_Click);
            // 
            // btnAbout2
            // 
            this.btnAbout2.FlatAppearance.BorderSize = 0;
            this.btnAbout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout2.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout2.Image")));
            this.btnAbout2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout2.Location = new System.Drawing.Point(0, 159);
            this.btnAbout2.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout2.Name = "btnAbout2";
            this.btnAbout2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout2.Size = new System.Drawing.Size(278, 53);
            this.btnAbout2.TabIndex = 100;
            this.btnAbout2.Text = " About";
            this.btnAbout2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout2.UseVisualStyleBackColor = true;
            this.btnAbout2.Click += new System.EventHandler(this.btnAbout2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 531);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(278, 53);
            this.btnLogout.TabIndex = 101;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModules.ForeColor = System.Drawing.Color.Black;
            this.lblModules.Location = new System.Drawing.Point(303, 46);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(22, 30);
            this.lblModules.TabIndex = 2;
            this.lblModules.Text = "-";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(278, 85);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(706, 526);
            this.panelContainer.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.lblModules);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMainMenu);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.adminMenu.ResumeLayout(false);
            this.studentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Button btnViewIssuedBook;
        private System.Windows.Forms.Button btnAdminSetting;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.FlowLayoutPanel adminMenu;
        private System.Windows.Forms.FlowLayoutPanel studentMenu;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnAccountSettingStudent;
        private System.Windows.Forms.Button btnAbout2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblModules;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private SubModules.Book book1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnAbout1;
    }
}