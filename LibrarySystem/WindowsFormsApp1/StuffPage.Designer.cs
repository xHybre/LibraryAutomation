namespace WindowsFormsApp1
{
    partial class StuffPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuffPage));
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booklanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpagecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_staff = new System.Windows.Forms.GroupBox();
            this.btn_staffClear = new System.Windows.Forms.Button();
            this.btn_staffUpdate = new System.Windows.Forms.Button();
            this.btn_staffDelete = new System.Windows.Forms.Button();
            this.btn_staffAdd = new System.Windows.Forms.Button();
            this.txt_bookYear = new System.Windows.Forms.TextBox();
            this.txt_bookPageCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_bookLanguage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bookCount = new System.Windows.Forms.TextBox();
            this.txt_bookAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bookType = new System.Windows.Forms.TextBox();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bookPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_bookSearch = new System.Windows.Forms.GroupBox();
            this.txt_bookSearch = new System.Windows.Forms.TextBox();
            this.btn_bookRefresh = new System.Windows.Forms.Button();
            this.btn_bookSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            this.groupBox_staff.SuspendLayout();
            this.groupBox_bookSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AllowUserToAddRows = false;
            this.dataGridView_staff.AllowUserToDeleteRows = false;
            this.dataGridView_staff.AllowUserToResizeColumns = false;
            this.dataGridView_staff.AllowUserToResizeRows = false;
            this.dataGridView_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.bookauthor,
            this.booklanguage,
            this.bookpublisher,
            this.booktype,
            this.bookcount,
            this.bookpagecount,
            this.bookyear});
            this.dataGridView_staff.Location = new System.Drawing.Point(13, 13);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.RowHeadersVisible = false;
            this.dataGridView_staff.RowHeadersWidth = 51;
            this.dataGridView_staff.RowTemplate.Height = 24;
            this.dataGridView_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_staff.Size = new System.Drawing.Size(1102, 303);
            this.dataGridView_staff.TabIndex = 0;
            this.dataGridView_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_staff_CellClick);
            // 
            // bookId
            // 
            this.bookId.HeaderText = "Id";
            this.bookId.MinimumWidth = 6;
            this.bookId.Name = "bookId";
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Name";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            // 
            // bookauthor
            // 
            this.bookauthor.HeaderText = "Author";
            this.bookauthor.MinimumWidth = 6;
            this.bookauthor.Name = "bookauthor";
            // 
            // booklanguage
            // 
            this.booklanguage.HeaderText = "Language";
            this.booklanguage.MinimumWidth = 6;
            this.booklanguage.Name = "booklanguage";
            // 
            // bookpublisher
            // 
            this.bookpublisher.HeaderText = "Publisher";
            this.bookpublisher.MinimumWidth = 6;
            this.bookpublisher.Name = "bookpublisher";
            // 
            // booktype
            // 
            this.booktype.HeaderText = "Type";
            this.booktype.MinimumWidth = 6;
            this.booktype.Name = "booktype";
            // 
            // bookcount
            // 
            this.bookcount.HeaderText = "Book Count";
            this.bookcount.MinimumWidth = 6;
            this.bookcount.Name = "bookcount";
            // 
            // bookpagecount
            // 
            this.bookpagecount.HeaderText = "Page Count";
            this.bookpagecount.MinimumWidth = 6;
            this.bookpagecount.Name = "bookpagecount";
            // 
            // bookyear
            // 
            this.bookyear.HeaderText = "Year";
            this.bookyear.MinimumWidth = 6;
            this.bookyear.Name = "bookyear";
            // 
            // groupBox_staff
            // 
            this.groupBox_staff.Controls.Add(this.btn_staffClear);
            this.groupBox_staff.Controls.Add(this.btn_staffUpdate);
            this.groupBox_staff.Controls.Add(this.btn_staffDelete);
            this.groupBox_staff.Controls.Add(this.btn_staffAdd);
            this.groupBox_staff.Controls.Add(this.txt_bookYear);
            this.groupBox_staff.Controls.Add(this.txt_bookPageCount);
            this.groupBox_staff.Controls.Add(this.label9);
            this.groupBox_staff.Controls.Add(this.txt_bookLanguage);
            this.groupBox_staff.Controls.Add(this.label8);
            this.groupBox_staff.Controls.Add(this.label4);
            this.groupBox_staff.Controls.Add(this.txt_bookCount);
            this.groupBox_staff.Controls.Add(this.txt_bookAuthor);
            this.groupBox_staff.Controls.Add(this.label7);
            this.groupBox_staff.Controls.Add(this.label3);
            this.groupBox_staff.Controls.Add(this.txt_bookType);
            this.groupBox_staff.Controls.Add(this.txt_bookName);
            this.groupBox_staff.Controls.Add(this.label6);
            this.groupBox_staff.Controls.Add(this.label2);
            this.groupBox_staff.Controls.Add(this.txt_bookPublisher);
            this.groupBox_staff.Controls.Add(this.label5);
            this.groupBox_staff.Controls.Add(this.txt_bookId);
            this.groupBox_staff.Controls.Add(this.label1);
            this.groupBox_staff.Location = new System.Drawing.Point(13, 323);
            this.groupBox_staff.Name = "groupBox_staff";
            this.groupBox_staff.Size = new System.Drawing.Size(670, 302);
            this.groupBox_staff.TabIndex = 1;
            this.groupBox_staff.TabStop = false;
            this.groupBox_staff.Text = "Book Transactions";
            // 
            // btn_staffClear
            // 
            this.btn_staffClear.Location = new System.Drawing.Point(351, 235);
            this.btn_staffClear.Name = "btn_staffClear";
            this.btn_staffClear.Size = new System.Drawing.Size(309, 47);
            this.btn_staffClear.TabIndex = 3;
            this.btn_staffClear.Text = "Clear";
            this.btn_staffClear.UseVisualStyleBackColor = true;
            this.btn_staffClear.Click += new System.EventHandler(this.btn_staffClear_Click);
            // 
            // btn_staffUpdate
            // 
            this.btn_staffUpdate.Location = new System.Drawing.Point(351, 179);
            this.btn_staffUpdate.Name = "btn_staffUpdate";
            this.btn_staffUpdate.Size = new System.Drawing.Size(309, 47);
            this.btn_staffUpdate.TabIndex = 3;
            this.btn_staffUpdate.Text = "Update";
            this.btn_staffUpdate.UseVisualStyleBackColor = true;
            this.btn_staffUpdate.Click += new System.EventHandler(this.btn_staffUpdate_Click);
            // 
            // btn_staffDelete
            // 
            this.btn_staffDelete.Location = new System.Drawing.Point(351, 123);
            this.btn_staffDelete.Name = "btn_staffDelete";
            this.btn_staffDelete.Size = new System.Drawing.Size(309, 47);
            this.btn_staffDelete.TabIndex = 3;
            this.btn_staffDelete.Text = "Delete";
            this.btn_staffDelete.UseVisualStyleBackColor = true;
            this.btn_staffDelete.Click += new System.EventHandler(this.btn_staffDelete_Click);
            // 
            // btn_staffAdd
            // 
            this.btn_staffAdd.Location = new System.Drawing.Point(351, 67);
            this.btn_staffAdd.Name = "btn_staffAdd";
            this.btn_staffAdd.Size = new System.Drawing.Size(309, 47);
            this.btn_staffAdd.TabIndex = 3;
            this.btn_staffAdd.Text = "Add";
            this.btn_staffAdd.UseVisualStyleBackColor = true;
            this.btn_staffAdd.Click += new System.EventHandler(this.btn_staffAdd_Click);
            // 
            // txt_bookYear
            // 
            this.txt_bookYear.Location = new System.Drawing.Point(114, 260);
            this.txt_bookYear.Name = "txt_bookYear";
            this.txt_bookYear.Size = new System.Drawing.Size(220, 22);
            this.txt_bookYear.TabIndex = 1;
            // 
            // txt_bookPageCount
            // 
            this.txt_bookPageCount.Location = new System.Drawing.Point(114, 232);
            this.txt_bookPageCount.Name = "txt_bookPageCount";
            this.txt_bookPageCount.Size = new System.Drawing.Size(220, 22);
            this.txt_bookPageCount.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Year:";
            // 
            // txt_bookLanguage
            // 
            this.txt_bookLanguage.Location = new System.Drawing.Point(114, 120);
            this.txt_bookLanguage.Name = "txt_bookLanguage";
            this.txt_bookLanguage.Size = new System.Drawing.Size(220, 22);
            this.txt_bookLanguage.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Page Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Language:";
            // 
            // txt_bookCount
            // 
            this.txt_bookCount.Location = new System.Drawing.Point(114, 204);
            this.txt_bookCount.Name = "txt_bookCount";
            this.txt_bookCount.Size = new System.Drawing.Size(220, 22);
            this.txt_bookCount.TabIndex = 1;
            // 
            // txt_bookAuthor
            // 
            this.txt_bookAuthor.Location = new System.Drawing.Point(114, 92);
            this.txt_bookAuthor.Name = "txt_bookAuthor";
            this.txt_bookAuthor.Size = new System.Drawing.Size(220, 22);
            this.txt_bookAuthor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Author:";
            // 
            // txt_bookType
            // 
            this.txt_bookType.Location = new System.Drawing.Point(114, 176);
            this.txt_bookType.Name = "txt_bookType";
            this.txt_bookType.Size = new System.Drawing.Size(220, 22);
            this.txt_bookType.TabIndex = 1;
            // 
            // txt_bookName
            // 
            this.txt_bookName.Location = new System.Drawing.Point(114, 64);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(220, 22);
            this.txt_bookName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name:";
            // 
            // txt_bookPublisher
            // 
            this.txt_bookPublisher.Location = new System.Drawing.Point(114, 148);
            this.txt_bookPublisher.Name = "txt_bookPublisher";
            this.txt_bookPublisher.Size = new System.Drawing.Size(220, 22);
            this.txt_bookPublisher.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publisher:";
            // 
            // txt_bookId
            // 
            this.txt_bookId.Location = new System.Drawing.Point(114, 36);
            this.txt_bookId.Name = "txt_bookId";
            this.txt_bookId.Size = new System.Drawing.Size(220, 22);
            this.txt_bookId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id:";
            // 
            // groupBox_bookSearch
            // 
            this.groupBox_bookSearch.Controls.Add(this.pictureBox1);
            this.groupBox_bookSearch.Controls.Add(this.txt_bookSearch);
            this.groupBox_bookSearch.Controls.Add(this.btn_bookRefresh);
            this.groupBox_bookSearch.Controls.Add(this.btn_bookSearch);
            this.groupBox_bookSearch.Controls.Add(this.label10);
            this.groupBox_bookSearch.Location = new System.Drawing.Point(690, 323);
            this.groupBox_bookSearch.Name = "groupBox_bookSearch";
            this.groupBox_bookSearch.Size = new System.Drawing.Size(424, 302);
            this.groupBox_bookSearch.TabIndex = 2;
            this.groupBox_bookSearch.TabStop = false;
            this.groupBox_bookSearch.Text = "Book Search";
            // 
            // txt_bookSearch
            // 
            this.txt_bookSearch.Location = new System.Drawing.Point(64, 145);
            this.txt_bookSearch.Name = "txt_bookSearch";
            this.txt_bookSearch.Size = new System.Drawing.Size(309, 22);
            this.txt_bookSearch.TabIndex = 1;
            // 
            // btn_bookRefresh
            // 
            this.btn_bookRefresh.Location = new System.Drawing.Point(64, 235);
            this.btn_bookRefresh.Name = "btn_bookRefresh";
            this.btn_bookRefresh.Size = new System.Drawing.Size(309, 47);
            this.btn_bookRefresh.TabIndex = 0;
            this.btn_bookRefresh.Text = "Refresh";
            this.btn_bookRefresh.UseVisualStyleBackColor = true;
            this.btn_bookRefresh.Click += new System.EventHandler(this.btn_bookRefresh_Click);
            // 
            // btn_bookSearch
            // 
            this.btn_bookSearch.Location = new System.Drawing.Point(64, 179);
            this.btn_bookSearch.Name = "btn_bookSearch";
            this.btn_bookSearch.Size = new System.Drawing.Size(309, 47);
            this.btn_bookSearch.TabIndex = 0;
            this.btn_bookSearch.Text = "Search";
            this.btn_bookSearch.UseVisualStyleBackColor = true;
            this.btn_bookSearch.Click += new System.EventHandler(this.btn_bookSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Book Id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StuffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1126, 637);
            this.Controls.Add(this.groupBox_bookSearch);
            this.Controls.Add(this.groupBox_staff);
            this.Controls.Add(this.dataGridView_staff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StuffPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Page";
            this.Load += new System.EventHandler(this.StuffPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            this.groupBox_staff.ResumeLayout(false);
            this.groupBox_staff.PerformLayout();
            this.groupBox_bookSearch.ResumeLayout(false);
            this.groupBox_bookSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.GroupBox groupBox_staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bookLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bookId;
        private System.Windows.Forms.TextBox txt_bookPageCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bookCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bookType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bookPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bookYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn booklanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktype;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpagecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookyear;
        private System.Windows.Forms.Button btn_staffClear;
        private System.Windows.Forms.Button btn_staffUpdate;
        private System.Windows.Forms.Button btn_staffDelete;
        private System.Windows.Forms.Button btn_staffAdd;
        private System.Windows.Forms.GroupBox groupBox_bookSearch;
        private System.Windows.Forms.Button btn_bookSearch;
        private System.Windows.Forms.Button btn_bookRefresh;
        private System.Windows.Forms.TextBox txt_bookSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}