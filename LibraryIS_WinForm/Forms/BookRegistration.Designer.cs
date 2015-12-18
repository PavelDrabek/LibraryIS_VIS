namespace LibraryIS_WinForm.Forms
{
    partial class BookRegistration
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
            if (disposing && (components != null)) {
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
            this.Book = new System.Windows.Forms.GroupBox();
            this.bookDetail1 = new LibraryIS_WinForm.Forms.BookDetail();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookList1 = new LibraryIS_WinForm.Forms.BookList();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.Book.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // Book
            // 
            this.Book.Controls.Add(this.bookDetail1);
            this.Book.Location = new System.Drawing.Point(6, 47);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(232, 296);
            this.Book.TabIndex = 11;
            this.Book.TabStop = false;
            this.Book.Text = "Detail";
            // 
            // bookDetail1
            // 
            this.bookDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDetail1.Location = new System.Drawing.Point(7, 20);
            this.bookDetail1.Name = "bookDetail1";
            this.bookDetail1.Size = new System.Drawing.Size(219, 272);
            this.bookDetail1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bookList1);
            this.groupBox1.Location = new System.Drawing.Point(244, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 395);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam";
            // 
            // bookList1
            // 
            this.bookList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookList1.Location = new System.Drawing.Point(6, 19);
            this.bookList1.Name = "bookList1";
            this.bookList1.Size = new System.Drawing.Size(670, 370);
            this.bookList1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 433);
            this.tabControl1.TabIndex = 18;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.btnBorrow);
            this.tabBooks.Controls.Add(this.btnSave);
            this.tabBooks.Controls.Add(this.Book);
            this.tabBooks.Controls.Add(this.btnDelete);
            this.tabBooks.Controls.Add(this.btnNew);
            this.tabBooks.Controls.Add(this.groupBox1);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(932, 407);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Knihy";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(6, 18);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(232, 23);
            this.btnBorrow.TabIndex = 21;
            this.btnBorrow.Text = "Pridat";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Ulozit";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(85, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Vymazat";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 363);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(66, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Pridat";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(917, 459);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Clenove";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // BookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "BookRegistration";
            this.Text = "BookRegistration";
            this.Book.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Book;
        private System.Windows.Forms.GroupBox groupBox1;
        private BookDetail bookDetail1;
        private BookList bookList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBorrow;
    }
}