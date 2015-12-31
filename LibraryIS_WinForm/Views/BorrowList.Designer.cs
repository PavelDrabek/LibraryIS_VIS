namespace LibraryIS_WinForm.Views
{
    partial class BorrowList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvBorrows = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Returned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvBorrows
            // 
            this.lvBorrows.AllowColumnReorder = true;
            this.lvBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBorrows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.Returned,
            this.Book,
            this.User});
            this.lvBorrows.FullRowSelect = true;
            this.lvBorrows.Location = new System.Drawing.Point(0, 0);
            this.lvBorrows.MultiSelect = false;
            this.lvBorrows.Name = "lvBorrows";
            this.lvBorrows.Size = new System.Drawing.Size(661, 398);
            this.lvBorrows.TabIndex = 17;
            this.lvBorrows.UseCompatibleStateImageBehavior = false;
            this.lvBorrows.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 32;
            // 
            // Date
            // 
            this.Date.Text = "Datum vypujceni";
            this.Date.Width = 127;
            // 
            // Returned
            // 
            this.Returned.Text = "Vraceno";
            this.Returned.Width = 126;
            // 
            // Book
            // 
            this.Book.Text = "Kniha";
            this.Book.Width = 77;
            // 
            // User
            // 
            this.User.Text = "Uzivatel";
            // 
            // BorrowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvBorrows);
            this.Name = "BorrowList";
            this.Size = new System.Drawing.Size(661, 398);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvBorrows;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Returned;
        private System.Windows.Forms.ColumnHeader Book;
        private System.Windows.Forms.ColumnHeader User;
    }
}
