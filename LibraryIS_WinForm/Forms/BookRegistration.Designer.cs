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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookList1 = new LibraryIS_WinForm.Forms.BookList();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.btnBookBorrow = new System.Windows.Forms.Button();
            this.btnBookEdit = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookNew = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.userList1 = new LibraryIS_WinForm.Views.UserList();
            this.btnUserBorrow = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bookList1);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 332);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam";
            // 
            // bookList1
            // 
            this.bookList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookList1.FilterText = "";
            this.bookList1.Location = new System.Drawing.Point(6, 19);
            this.bookList1.Name = "bookList1";
            this.bookList1.Size = new System.Drawing.Size(614, 307);
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
            this.tabControl1.Size = new System.Drawing.Size(646, 399);
            this.tabControl1.TabIndex = 18;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.btnBookBorrow);
            this.tabBooks.Controls.Add(this.btnBookEdit);
            this.tabBooks.Controls.Add(this.btnBookDelete);
            this.tabBooks.Controls.Add(this.btnBookNew);
            this.tabBooks.Controls.Add(this.groupBox1);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(638, 373);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Knihy";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // btnBookBorrow
            // 
            this.btnBookBorrow.Location = new System.Drawing.Point(6, 6);
            this.btnBookBorrow.Name = "btnBookBorrow";
            this.btnBookBorrow.Size = new System.Drawing.Size(232, 23);
            this.btnBookBorrow.TabIndex = 21;
            this.btnBookBorrow.Text = "Zapujcit";
            this.btnBookBorrow.UseVisualStyleBackColor = true;
            this.btnBookBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookEdit.Location = new System.Drawing.Point(488, 6);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBookEdit.TabIndex = 20;
            this.btnBookEdit.Text = "Upravit";
            this.btnBookEdit.UseVisualStyleBackColor = true;
            this.btnBookEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookDelete.Location = new System.Drawing.Point(569, 6);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(66, 23);
            this.btnBookDelete.TabIndex = 19;
            this.btnBookDelete.Text = "Vymazat";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBookNew
            // 
            this.btnBookNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookNew.Location = new System.Drawing.Point(416, 6);
            this.btnBookNew.Name = "btnBookNew";
            this.btnBookNew.Size = new System.Drawing.Size(66, 23);
            this.btnBookNew.TabIndex = 18;
            this.btnBookNew.Text = "Pridat";
            this.btnBookNew.UseVisualStyleBackColor = true;
            this.btnBookNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnUserBorrow);
            this.tabUsers.Controls.Add(this.btnUserEdit);
            this.tabUsers.Controls.Add(this.btnUserDelete);
            this.tabUsers.Controls.Add(this.btnUserAdd);
            this.tabUsers.Controls.Add(this.userList1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(638, 373);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Clenove";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // userList1
            // 
            this.userList1.FilterText = "";
            this.userList1.Location = new System.Drawing.Point(7, 35);
            this.userList1.Name = "userList1";
            this.userList1.Size = new System.Drawing.Size(625, 332);
            this.userList1.TabIndex = 0;
            // 
            // btnUserBorrow
            // 
            this.btnUserBorrow.Location = new System.Drawing.Point(7, 6);
            this.btnUserBorrow.Name = "btnUserBorrow";
            this.btnUserBorrow.Size = new System.Drawing.Size(232, 23);
            this.btnUserBorrow.TabIndex = 25;
            this.btnUserBorrow.Text = "Zapujcit";
            this.btnUserBorrow.UseVisualStyleBackColor = true;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserEdit.Location = new System.Drawing.Point(489, 6);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(75, 23);
            this.btnUserEdit.TabIndex = 24;
            this.btnUserEdit.Text = "Upravit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserDelete.Location = new System.Drawing.Point(570, 6);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(66, 23);
            this.btnUserDelete.TabIndex = 23;
            this.btnUserDelete.Text = "Vymazat";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserAdd.Location = new System.Drawing.Point(417, 6);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(66, 23);
            this.btnUserAdd.TabIndex = 22;
            this.btnUserAdd.Text = "Pridat";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            // 
            // BookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 424);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(515, 38);
            this.Name = "BookRegistration";
            this.Text = "BookRegistration";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BookList bookList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnBookEdit;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookNew;
        private System.Windows.Forms.Button btnBookBorrow;
        private Views.UserList userList1;
        private System.Windows.Forms.Button btnUserBorrow;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserAdd;
    }
}