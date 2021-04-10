namespace LibraryManagement.Modules.SubModules
{
    partial class SearchBook
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
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBoxSearch = new System.Windows.Forms.CheckBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxReturnDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.chkBoxSort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeColumns = false;
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.ColumnHeadersHeight = 35;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Category});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.GridColor = System.Drawing.Color.White;
            this.dgvBook.Location = new System.Drawing.Point(25, 228);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBook.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvBook.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.RowTemplate.Height = 30;
            this.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(613, 413);
            this.dgvBook.TabIndex = 16;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "book_title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "book_author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "category_name";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkBoxSearch
            // 
            this.chkBoxSearch.AutoSize = true;
            this.chkBoxSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.chkBoxSearch.Location = new System.Drawing.Point(29, 170);
            this.chkBoxSearch.Name = "chkBoxSearch";
            this.chkBoxSearch.Size = new System.Drawing.Size(102, 23);
            this.chkBoxSearch.TabIndex = 19;
            this.chkBoxSearch.Text = "Search by : ";
            this.chkBoxSearch.UseVisualStyleBackColor = true;
            this.chkBoxSearch.CheckedChanged += new System.EventHandler(this.chkBoxSearch_CheckedChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(137, 169);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(105, 26);
            this.comboBoxSearch.TabIndex = 18;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(25, 127);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(250, 56);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(428, 27);
            this.txtBoxSearch.TabIndex = 17;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(21, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "details below.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(21, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Select book from the table and see full";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblBookId.Location = new System.Drawing.Point(212, 727);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(15, 20);
            this.lblBookId.TabIndex = 62;
            this.lblBookId.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 727);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Book ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblDate.Location = new System.Drawing.Point(212, 903);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(15, 20);
            this.lblDate.TabIndex = 58;
            this.lblDate.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(21, 903);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Added Date";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblCategory.Location = new System.Drawing.Point(212, 872);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(15, 20);
            this.lblCategory.TabIndex = 56;
            this.lblCategory.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 872);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Category";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblPage.Location = new System.Drawing.Point(212, 842);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(15, 20);
            this.lblPage.TabIndex = 54;
            this.lblPage.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(21, 842);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Page";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblAuthor.Location = new System.Drawing.Point(212, 786);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(15, 20);
            this.lblAuthor.TabIndex = 52;
            this.lblAuthor.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 786);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Author";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblBookTitle.Location = new System.Drawing.Point(212, 756);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(15, 20);
            this.lblBookTitle.TabIndex = 50;
            this.lblBookTitle.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 756);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Book Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label10.Location = new System.Drawing.Point(20, 659);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 30);
            this.label10.TabIndex = 46;
            this.label10.Text = "Book Details";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.Black;
            this.lblAvailability.Location = new System.Drawing.Point(212, 940);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(15, 20);
            this.lblAvailability.TabIndex = 63;
            this.lblAvailability.Text = "-";
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear1.FlatAppearance.BorderSize = 0;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.Location = new System.Drawing.Point(22, 1307);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(238, 46);
            this.btnClear1.TabIndex = 71;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = false;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.DarkGray;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Location = new System.Drawing.Point(22, 1255);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(238, 46);
            this.btnIssueBook.TabIndex = 70;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 1188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 69;
            this.label7.Text = "Return Date";
            // 
            // txtBoxReturnDate
            // 
            this.txtBoxReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxReturnDate.Location = new System.Drawing.Point(24, 1210);
            this.txtBoxReturnDate.Name = "txtBoxReturnDate";
            this.txtBoxReturnDate.Size = new System.Drawing.Size(236, 29);
            this.txtBoxReturnDate.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 1123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Current Date";
            // 
            // txtBoxCurrentDate
            // 
            this.txtBoxCurrentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCurrentDate.Location = new System.Drawing.Point(24, 1145);
            this.txtBoxCurrentDate.Name = "txtBoxCurrentDate";
            this.txtBoxCurrentDate.ReadOnly = true;
            this.txtBoxCurrentDate.Size = new System.Drawing.Size(238, 29);
            this.txtBoxCurrentDate.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 1070);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "Select book from the table to borrow book.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label12.Location = new System.Drawing.Point(20, 1016);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 30);
            this.label12.TabIndex = 64;
            this.label12.Text = "Issue Book";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(103, 1191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 83;
            this.label14.Text = "(dd/mm/yyyy)";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.comboBoxSort.Location = new System.Drawing.Point(348, 169);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(105, 26);
            this.comboBoxSort.TabIndex = 86;
            this.comboBoxSort.SelectedValueChanged += new System.EventHandler(this.comboBoxSort_SelectedValueChanged);
            // 
            // chkBoxSort
            // 
            this.chkBoxSort.AutoSize = true;
            this.chkBoxSort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSort.ForeColor = System.Drawing.Color.Black;
            this.chkBoxSort.Location = new System.Drawing.Point(261, 170);
            this.chkBoxSort.Name = "chkBoxSort";
            this.chkBoxSort.Size = new System.Drawing.Size(81, 23);
            this.chkBoxSort.TabIndex = 85;
            this.chkBoxSort.Text = "Sort By :";
            this.chkBoxSort.UseVisualStyleBackColor = true;
            this.chkBoxSort.CheckedChanged += new System.EventHandler(this.chkBoxSort_CheckedChanged);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.chkBoxSort);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxReturnDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCurrentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.dgvBook);
            this.MinimumSize = new System.Drawing.Size(665, 1342);
            this.Name = "SearchBook";
            this.Size = new System.Drawing.Size(665, 1379);
            this.Load += new System.EventHandler(this.SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.CheckBox chkBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxReturnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCurrentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.CheckBox chkBoxSort;
    }
}
