namespace LibraryManagement.Modules.SubModules
{
    partial class RegisterStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudent));
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBoxSearch = new System.Windows.Forms.CheckBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxAddLName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxAddFName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxAddStudNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAddSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStudSection = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxStudLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxStudFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxOldStudNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxNewStudNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.lblBackToTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeight = 35;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.FirstName,
            this.LastName,
            this.Section});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.GridColor = System.Drawing.Color.White;
            this.dgvStudent.Location = new System.Drawing.Point(32, 698);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudent.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.RowTemplate.Height = 30;
            this.dgvStudent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(613, 429);
            this.dgvStudent.TabIndex = 15;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "student_number";
            this.StudentNumber.HeaderText = "Student Number";
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "first_name";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "last_name";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // chkBoxSearch
            // 
            this.chkBoxSearch.AutoSize = true;
            this.chkBoxSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.chkBoxSearch.Location = new System.Drawing.Point(300, 638);
            this.chkBoxSearch.Name = "chkBoxSearch";
            this.chkBoxSearch.Size = new System.Drawing.Size(98, 23);
            this.chkBoxSearch.TabIndex = 12;
            this.chkBoxSearch.Text = "Search by :";
            this.chkBoxSearch.UseVisualStyleBackColor = true;
            this.chkBoxSearch.CheckedChanged += new System.EventHandler(this.chkBoxSort_CheckedChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(404, 638);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(140, 26);
            this.comboBoxSort.TabIndex = 13;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(32, 635);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(250, 56);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(250, 26);
            this.txtBoxSearch.TabIndex = 11;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegisterStudent.FlatAppearance.BorderSize = 0;
            this.btnRegisterStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterStudent.Location = new System.Drawing.Point(31, 439);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(236, 46);
            this.btnRegisterStudent.TabIndex = 5;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = false;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(308, 19);
            this.label13.TabIndex = 58;
            this.label13.Text = "Fill up the following below to register student.";
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear1.FlatAppearance.BorderSize = 0;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(31, 491);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(236, 46);
            this.btnClear1.TabIndex = 6;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = false;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 56;
            this.label14.Text = "Last Name";
            // 
            // txtBoxAddLName
            // 
            this.txtBoxAddLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddLName.Location = new System.Drawing.Point(31, 321);
            this.txtBoxAddLName.Name = "txtBoxAddLName";
            this.txtBoxAddLName.Size = new System.Drawing.Size(238, 29);
            this.txtBoxAddLName.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 54;
            this.label15.Text = "First Name";
            // 
            // txtBoxAddFName
            // 
            this.txtBoxAddFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddFName.Location = new System.Drawing.Point(31, 256);
            this.txtBoxAddFName.Name = "txtBoxAddFName";
            this.txtBoxAddFName.Size = new System.Drawing.Size(238, 29);
            this.txtBoxAddFName.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 19);
            this.label16.TabIndex = 52;
            this.label16.Text = "Student Number";
            // 
            // txtBoxAddStudNum
            // 
            this.txtBoxAddStudNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddStudNum.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxAddStudNum.Location = new System.Drawing.Point(32, 191);
            this.txtBoxAddStudNum.Name = "txtBoxAddStudNum";
            this.txtBoxAddStudNum.Size = new System.Drawing.Size(237, 29);
            this.txtBoxAddStudNum.TabIndex = 1;
            this.txtBoxAddStudNum.Text = "2000<6-digit>";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label17.Location = new System.Drawing.Point(28, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 30);
            this.label17.TabIndex = 50;
            this.label17.Text = "Register Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Section";
            // 
            // txtBoxAddSection
            // 
            this.txtBoxAddSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddSection.Location = new System.Drawing.Point(31, 384);
            this.txtBoxAddSection.Name = "txtBoxAddSection";
            this.txtBoxAddSection.Size = new System.Drawing.Size(238, 29);
            this.txtBoxAddSection.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(28, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 62;
            this.label2.Text = "View Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 1525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Section";
            // 
            // txtBoxStudSection
            // 
            this.txtBoxStudSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudSection.Location = new System.Drawing.Point(29, 1547);
            this.txtBoxStudSection.Name = "txtBoxStudSection";
            this.txtBoxStudSection.Size = new System.Drawing.Size(219, 29);
            this.txtBoxStudSection.TabIndex = 23;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(29, 1602);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 46);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 1197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Fill up the following below to register student.";
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear2.FlatAppearance.BorderSize = 0;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.Location = new System.Drawing.Point(29, 1654);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(219, 46);
            this.btnClear2.TabIndex = 26;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 1385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "Last Name";
            // 
            // txtBoxStudLName
            // 
            this.txtBoxStudLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudLName.Location = new System.Drawing.Point(29, 1407);
            this.txtBoxStudLName.Name = "txtBoxStudLName";
            this.txtBoxStudLName.Size = new System.Drawing.Size(219, 29);
            this.txtBoxStudLName.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 1320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "First Name";
            // 
            // txtBoxStudFName
            // 
            this.txtBoxStudFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudFName.Location = new System.Drawing.Point(29, 1342);
            this.txtBoxStudFName.Name = "txtBoxStudFName";
            this.txtBoxStudFName.Size = new System.Drawing.Size(219, 29);
            this.txtBoxStudFName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 1249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Current Student Number";
            // 
            // txtBoxOldStudNum
            // 
            this.txtBoxOldStudNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOldStudNum.Location = new System.Drawing.Point(30, 1277);
            this.txtBoxOldStudNum.Name = "txtBoxOldStudNum";
            this.txtBoxOldStudNum.ReadOnly = true;
            this.txtBoxOldStudNum.Size = new System.Drawing.Size(218, 29);
            this.txtBoxOldStudNum.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(28, 1149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 30);
            this.label8.TabIndex = 63;
            this.label8.Text = "Edit && Remove Student Info";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(144, 1602);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 46);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 1249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 19);
            this.label9.TabIndex = 77;
            this.label9.Text = "New Student Number";
            // 
            // txtBoxNewStudNum
            // 
            this.txtBoxNewStudNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewStudNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxNewStudNum.Location = new System.Drawing.Point(289, 1277);
            this.txtBoxNewStudNum.Name = "txtBoxNewStudNum";
            this.txtBoxNewStudNum.Size = new System.Drawing.Size(218, 29);
            this.txtBoxNewStudNum.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 1453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 81;
            this.label10.Text = "New Password";
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPassword.Location = new System.Drawing.Point(289, 1481);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(218, 29);
            this.txtBoxNewPassword.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 1453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 79;
            this.label11.Text = "Current Password";
            // 
            // txtBoxOldPassword
            // 
            this.txtBoxOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOldPassword.Location = new System.Drawing.Point(30, 1481);
            this.txtBoxOldPassword.Name = "txtBoxOldPassword";
            this.txtBoxOldPassword.ReadOnly = true;
            this.txtBoxOldPassword.Size = new System.Drawing.Size(218, 29);
            this.txtBoxOldPassword.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 82;
            this.label12.Text = "e.g. 2000042002";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(437, 1252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 15);
            this.label18.TabIndex = 83;
            this.label18.Text = "e.g. 2000042002";
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOption3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.lblOption3.Location = new System.Drawing.Point(477, 162);
            this.lblOption3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(178, 22);
            this.lblOption3.TabIndex = 9;
            this.lblOption3.Text = "Edit && Remove Student";
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOption2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.lblOption2.Location = new System.Drawing.Point(477, 135);
            this.lblOption2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(106, 22);
            this.lblOption2.TabIndex = 8;
            this.lblOption2.Text = "View Student";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(477, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 22);
            this.label20.TabIndex = 85;
            this.label20.Text = "Options";
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOption1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.lblOption1.Location = new System.Drawing.Point(477, 108);
            this.lblOption1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(129, 22);
            this.lblOption1.TabIndex = 7;
            this.lblOption1.Text = "Register Student";
            // 
            // lblBackToTop
            // 
            this.lblBackToTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackToTop.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToTop.ForeColor = System.Drawing.Color.Black;
            this.lblBackToTop.Image = ((System.Drawing.Image)(resources.GetObject("lblBackToTop.Image")));
            this.lblBackToTop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBackToTop.Location = new System.Drawing.Point(516, 1678);
            this.lblBackToTop.Name = "lblBackToTop";
            this.lblBackToTop.Size = new System.Drawing.Size(149, 22);
            this.lblBackToTop.TabIndex = 86;
            this.lblBackToTop.Text = "Go back to top.";
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBackToTop);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblOption1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxOldPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxNewStudNum);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxStudSection);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxStudLName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxStudFName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxOldStudNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAddSection);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxAddLName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxAddFName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBoxAddStudNum);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.chkBoxSearch);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.txtBoxSearch);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimumSize = new System.Drawing.Size(665, 1488);
            this.Name = "RegisterStudent";
            this.Size = new System.Drawing.Size(665, 1713);
            this.Load += new System.EventHandler(this.RegisterStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.CheckBox chkBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxAddLName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxAddFName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxAddStudNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAddSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxStudSection;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxStudLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxStudFName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxOldStudNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxNewStudNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxOldPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.Label lblBackToTop;
    }
}
