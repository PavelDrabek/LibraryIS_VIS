namespace LibraryIS_WinForm.Forms
{
    partial class FormNewBorrow
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChooseBook = new System.Windows.Forms.Button();
            this.bookDetail1 = new LibraryIS_WinForm.Forms.BookDetail();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseUser = new System.Windows.Forms.Button();
            this.userDetail1 = new LibraryIS_WinForm.Views.UserDetail();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(159, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Zrusit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Location = new System.Drawing.Point(240, 311);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Pujcit";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.bookDetail1);
            this.groupBox1.Controls.Add(this.btnChooseBook);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kniha";
            // 
            // btnChooseBook
            // 
            this.btnChooseBook.Location = new System.Drawing.Point(7, 20);
            this.btnChooseBook.Name = "btnChooseBook";
            this.btnChooseBook.Size = new System.Drawing.Size(208, 23);
            this.btnChooseBook.TabIndex = 1;
            this.btnChooseBook.Text = "Vybrat";
            this.btnChooseBook.UseVisualStyleBackColor = true;
            this.btnChooseBook.Click += new System.EventHandler(this.btnChooseBook_Click);
            // 
            // bookDetail1
            // 
            this.bookDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDetail1.author = null;
            this.bookDetail1.genre = null;
            this.bookDetail1.ID = 0;
            this.bookDetail1.ISBN = "";
            this.bookDetail1.Location = new System.Drawing.Point(7, 50);
            this.bookDetail1.Name = "bookDetail1";
            this.bookDetail1.NumOfPages = 0;
            this.bookDetail1.publisher = null;
            this.bookDetail1.Size = new System.Drawing.Size(208, 239);
            this.bookDetail1.TabIndex = 2;
            this.bookDetail1.Title = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.userDetail1);
            this.groupBox2.Controls.Add(this.btnChooseUser);
            this.groupBox2.Location = new System.Drawing.Point(240, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uzivatel";
            // 
            // btnChooseUser
            // 
            this.btnChooseUser.Location = new System.Drawing.Point(7, 20);
            this.btnChooseUser.Name = "btnChooseUser";
            this.btnChooseUser.Size = new System.Drawing.Size(208, 23);
            this.btnChooseUser.TabIndex = 1;
            this.btnChooseUser.Text = "Vybrat";
            this.btnChooseUser.UseVisualStyleBackColor = true;
            this.btnChooseUser.Click += new System.EventHandler(this.btnChooseUser_Click);
            // 
            // userDetail1
            // 
            this.userDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDetail1.Location = new System.Drawing.Point(7, 50);
            this.userDetail1.Name = "userDetail1";
            this.userDetail1.Size = new System.Drawing.Size(208, 117);
            this.userDetail1.TabIndex = 2;
            // 
            // FormNewBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 346);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.MaximumSize = new System.Drawing.Size(489, 384);
            this.MinimumSize = new System.Drawing.Size(489, 384);
            this.Name = "FormNewBorrow";
            this.Text = "FormNewBorrow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseBook;
        private BookDetail bookDetail1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChooseUser;
        private Views.UserDetail userDetail1;
    }
}