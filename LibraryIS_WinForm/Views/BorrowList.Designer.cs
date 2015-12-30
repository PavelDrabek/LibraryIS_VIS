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
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Username,
            this.Firstname,
            this.Lastname});
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
            // Username
            // 
            this.Username.Text = "Uziv. jmeno";
            this.Username.Width = 127;
            // 
            // Firstname
            // 
            this.Firstname.Text = "Jmeno";
            this.Firstname.Width = 126;
            // 
            // Lastname
            // 
            this.Lastname.Text = "Prijmeni";
            this.Lastname.Width = 77;
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
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.ColumnHeader Lastname;
    }
}
