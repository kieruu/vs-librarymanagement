namespace LibraryManagement.Modules.SubModules
{
    partial class ReturnBook
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
            this.dgvIssuedBook = new System.Windows.Forms.DataGridView();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lblIssuedId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPenaltyFee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIssuedBook
            // 
            this.dgvIssuedBook.AllowUserToAddRows = false;
            this.dgvIssuedBook.AllowUserToDeleteRows = false;
            this.dgvIssuedBook.AllowUserToResizeColumns = false;
            this.dgvIssuedBook.AllowUserToResizeRows = false;
            this.dgvIssuedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuedBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssuedBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIssuedBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssuedBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuedBook.ColumnHeadersHeight = 35;
            this.dgvIssuedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIssuedBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.Title,
            this.DateIssued});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuedBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssuedBook.GridColor = System.Drawing.Color.White;
            this.dgvIssuedBook.Location = new System.Drawing.Point(24, 156);
            this.dgvIssuedBook.MultiSelect = false;
            this.dgvIssuedBook.Name = "dgvIssuedBook";
            this.dgvIssuedBook.ReadOnly = true;
            this.dgvIssuedBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIssuedBook.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvIssuedBook.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssuedBook.RowTemplate.Height = 30;
            this.dgvIssuedBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuedBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuedBook.Size = new System.Drawing.Size(613, 254);
            this.dgvIssuedBook.TabIndex = 17;
            this.dgvIssuedBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssuedBook_CellClick);
            // 
            // IID
            // 
            this.IID.DataPropertyName = "issued_id";
            this.IID.HeaderText = "IID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "book_title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateIssued
            // 
            this.DateIssued.DataPropertyName = "date_issued";
            this.DateIssued.HeaderText = "Date Issued";
            this.DateIssued.Name = "DateIssued";
            this.DateIssued.ReadOnly = true;
            this.DateIssued.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Select book from the table to see details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label12.Location = new System.Drawing.Point(19, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 30);
            this.label12.TabIndex = 66;
            this.label12.Text = "Issued Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "and to return the book.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(19, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 69;
            this.label2.Text = "Details";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblBookId.Location = new System.Drawing.Point(211, 549);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(15, 20);
            this.lblBookId.TabIndex = 81;
            this.lblBookId.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 549);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Book ID";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblReturnDate.Location = new System.Drawing.Point(211, 725);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(15, 20);
            this.lblReturnDate.TabIndex = 79;
            this.lblReturnDate.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(20, 725);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 78;
            this.label13.Text = "Return Date";
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIssued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblDateIssued.Location = new System.Drawing.Point(211, 694);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(15, 20);
            this.lblDateIssued.TabIndex = 77;
            this.lblDateIssued.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 694);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Date Issued";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblPage.Location = new System.Drawing.Point(211, 637);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(15, 20);
            this.lblPage.TabIndex = 75;
            this.lblPage.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 637);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 74;
            this.label11.Text = "Page";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblAuthor.Location = new System.Drawing.Point(211, 608);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(15, 20);
            this.lblAuthor.TabIndex = 73;
            this.lblAuthor.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Author";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblBookTitle.Location = new System.Drawing.Point(211, 578);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(15, 20);
            this.lblBookTitle.TabIndex = 71;
            this.lblBookTitle.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Book Title";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(211, 799);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 20);
            this.lblStatus.TabIndex = 82;
            this.lblStatus.Text = "-";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(24, 855);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(127, 50);
            this.btnReturnBook.TabIndex = 83;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lblIssuedId
            // 
            this.lblIssuedId.AutoSize = true;
            this.lblIssuedId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblIssuedId.Location = new System.Drawing.Point(211, 499);
            this.lblIssuedId.Name = "lblIssuedId";
            this.lblIssuedId.Size = new System.Drawing.Size(15, 20);
            this.lblIssuedId.TabIndex = 85;
            this.lblIssuedId.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Issued ID";
            // 
            // lblPenaltyFee
            // 
            this.lblPenaltyFee.AutoSize = true;
            this.lblPenaltyFee.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblPenaltyFee.Location = new System.Drawing.Point(211, 756);
            this.lblPenaltyFee.Name = "lblPenaltyFee";
            this.lblPenaltyFee.Size = new System.Drawing.Size(15, 20);
            this.lblPenaltyFee.TabIndex = 87;
            this.lblPenaltyFee.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 756);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "Penalty Fee";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPenaltyFee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblIssuedId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDateIssued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvIssuedBook);
            this.Name = "ReturnBook";
            this.Size = new System.Drawing.Size(665, 932);
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssuedBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDateIssued;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIssued;
        private System.Windows.Forms.Label lblIssuedId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPenaltyFee;
        private System.Windows.Forms.Label label10;
    }
}
