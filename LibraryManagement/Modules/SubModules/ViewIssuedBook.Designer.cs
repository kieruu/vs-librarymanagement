namespace LibraryManagement.Modules.SubModules
{
    partial class ViewIssuedBook
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
            this.dgvIssued = new System.Windows.Forms.DataGridView();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBoxSearch = new System.Windows.Forms.CheckBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStudNum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPenaltyFee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnRemoveFromTheList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIssued
            // 
            this.dgvIssued.AllowUserToAddRows = false;
            this.dgvIssued.AllowUserToDeleteRows = false;
            this.dgvIssued.AllowUserToResizeColumns = false;
            this.dgvIssued.AllowUserToResizeRows = false;
            this.dgvIssued.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssued.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssued.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIssued.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssued.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssued.ColumnHeadersHeight = 35;
            this.dgvIssued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIssued.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueID,
            this.FullName,
            this.Section,
            this.BookTitle,
            this.DateIssued});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssued.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssued.GridColor = System.Drawing.Color.White;
            this.dgvIssued.Location = new System.Drawing.Point(25, 106);
            this.dgvIssued.MultiSelect = false;
            this.dgvIssued.Name = "dgvIssued";
            this.dgvIssued.ReadOnly = true;
            this.dgvIssued.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIssued.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvIssued.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssued.RowTemplate.Height = 30;
            this.dgvIssued.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssued.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssued.Size = new System.Drawing.Size(613, 332);
            this.dgvIssued.TabIndex = 19;
            this.dgvIssued.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssued_CellClick);
            // 
            // IssueID
            // 
            this.IssueID.DataPropertyName = "issued_id";
            this.IssueID.HeaderText = "Issue ID";
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            this.IssueID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "full_name";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // BookTitle
            // 
            this.BookTitle.DataPropertyName = "book_title";
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            this.BookTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateIssued
            // 
            this.DateIssued.DataPropertyName = "date_issued";
            this.DateIssued.HeaderText = "Date Issued";
            this.DateIssued.Name = "DateIssued";
            this.DateIssued.ReadOnly = true;
            this.DateIssued.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkBoxSearch
            // 
            this.chkBoxSearch.AutoSize = true;
            this.chkBoxSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.chkBoxSearch.Location = new System.Drawing.Point(293, 46);
            this.chkBoxSearch.Name = "chkBoxSearch";
            this.chkBoxSearch.Size = new System.Drawing.Size(102, 23);
            this.chkBoxSearch.TabIndex = 18;
            this.chkBoxSearch.Text = "Search by : ";
            this.chkBoxSearch.UseVisualStyleBackColor = true;
            this.chkBoxSearch.CheckedChanged += new System.EventHandler(this.chkBoxSearch_CheckedChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(401, 45);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(105, 26);
            this.comboBoxSort.TabIndex = 17;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(25, 43);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(250, 56);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(250, 26);
            this.txtBoxSearch.TabIndex = 16;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(20, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Issued Book Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 653);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Book Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Select issued book from the table to see";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "full details below.";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblBookTitle.Location = new System.Drawing.Point(212, 653);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(15, 20);
            this.lblBookTitle.TabIndex = 29;
            this.lblBookTitle.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Author";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblAuthor.Location = new System.Drawing.Point(212, 683);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(15, 20);
            this.lblAuthor.TabIndex = 31;
            this.lblAuthor.Text = "-";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblFullName.Location = new System.Drawing.Point(212, 768);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(15, 20);
            this.lblFullName.TabIndex = 35;
            this.lblFullName.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 768);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Full Name";
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblStudNum.Location = new System.Drawing.Point(212, 738);
            this.lblStudNum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(15, 20);
            this.lblStudNum.TabIndex = 33;
            this.lblStudNum.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(21, 738);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Student Number";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblSection.Location = new System.Drawing.Point(212, 798);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(15, 20);
            this.lblSection.TabIndex = 37;
            this.lblSection.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(21, 798);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Yr/Section";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblReturnDate.Location = new System.Drawing.Point(212, 883);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(15, 20);
            this.lblReturnDate.TabIndex = 41;
            this.lblReturnDate.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(21, 883);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Return Date";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblIssueDate.Location = new System.Drawing.Point(212, 853);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(15, 20);
            this.lblIssueDate.TabIndex = 39;
            this.lblIssueDate.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(21, 853);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Issued Date";
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblIssueID.Location = new System.Drawing.Point(212, 572);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(15, 20);
            this.lblIssueID.TabIndex = 43;
            this.lblIssueID.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Issued ID";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblBookId.Location = new System.Drawing.Point(212, 623);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(15, 20);
            this.lblBookId.TabIndex = 45;
            this.lblBookId.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 623);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Book ID";
            // 
            // lblPenaltyFee
            // 
            this.lblPenaltyFee.AutoSize = true;
            this.lblPenaltyFee.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblPenaltyFee.Location = new System.Drawing.Point(212, 913);
            this.lblPenaltyFee.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblPenaltyFee.Name = "lblPenaltyFee";
            this.lblPenaltyFee.Size = new System.Drawing.Size(15, 20);
            this.lblPenaltyFee.TabIndex = 89;
            this.lblPenaltyFee.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(21, 913);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "Penalty Fee";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(212, 943);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 20);
            this.lblStatus.TabIndex = 90;
            this.lblStatus.Text = "-";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(25, 1000);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(181, 50);
            this.btnReturnBook.TabIndex = 91;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnRemoveFromTheList
            // 
            this.btnRemoveFromTheList.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemoveFromTheList.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromTheList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromTheList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromTheList.Location = new System.Drawing.Point(25, 1056);
            this.btnRemoveFromTheList.Name = "btnRemoveFromTheList";
            this.btnRemoveFromTheList.Size = new System.Drawing.Size(181, 50);
            this.btnRemoveFromTheList.TabIndex = 92;
            this.btnRemoveFromTheList.Text = "Remove From The List";
            this.btnRemoveFromTheList.UseVisualStyleBackColor = false;
            this.btnRemoveFromTheList.Click += new System.EventHandler(this.btnRemoveFromTheList_Click);
            // 
            // ViewIssuedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemoveFromTheList);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPenaltyFee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIssueID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStudNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIssued);
            this.Controls.Add(this.chkBoxSearch);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.txtBoxSearch);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimumSize = new System.Drawing.Size(665, 947);
            this.Name = "ViewIssuedBook";
            this.Size = new System.Drawing.Size(665, 1134);
            this.Load += new System.EventHandler(this.IssuedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssued;
        private System.Windows.Forms.CheckBox chkBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStudNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIssued;
        private System.Windows.Forms.Label lblPenaltyFee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnRemoveFromTheList;
    }
}
