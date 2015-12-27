namespace LibraryIS_WinForm.Forms
{
    partial class FormNewBook
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
            this.bookDetail1 = new LibraryIS_WinForm.Forms.BookDetail();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(36, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(117, 292);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // bookDetail1
            // 
            this.bookDetail1.author = null;
            this.bookDetail1.genre = null;
            this.bookDetail1.ID = 0;
            this.bookDetail1.ISBN = "";
            this.bookDetail1.Language = "";
            this.bookDetail1.Location = new System.Drawing.Point(13, 13);
            this.bookDetail1.Name = "bookDetail1";
            this.bookDetail1.publisher = null;
            this.bookDetail1.Size = new System.Drawing.Size(199, 273);
            this.bookDetail1.TabIndex = 0;
            this.bookDetail1.Title = "";
            // 
            // FormNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 327);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bookDetail1);
            this.MaximumSize = new System.Drawing.Size(245, 365);
            this.MinimumSize = new System.Drawing.Size(245, 365);
            this.Name = "FormNewBook";
            this.Text = "New book";
            this.ResumeLayout(false);

        }

        #endregion

        private BookDetail bookDetail1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;


    }
}