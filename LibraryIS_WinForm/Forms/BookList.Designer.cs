namespace LibraryIS_WinForm.Forms
{
    partial class BookList
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
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Location = new System.Drawing.Point(0, 2);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(440, 20);
            this.tbFilter.TabIndex = 12;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Titul",
            "Autor",
            "Zanr",
            "ISBN",
            "Vydavatelstvi",
            "Jazyk"});
            this.cbFilter.Location = new System.Drawing.Point(446, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(87, 21);
            this.cbFilter.TabIndex = 14;
            // 
            // lvBooks
            // 
            this.lvBooks.AllowColumnReorder = true;
            this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Language,
            this.Author,
            this.Genre,
            this.Publisher,
            this.Pages,
            this.ISBN});
            this.lvBooks.FullRowSelect = true;
            this.lvBooks.Location = new System.Drawing.Point(0, 28);
            this.lvBooks.MultiSelect = false;
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(614, 320);
            this.lvBooks.TabIndex = 11;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 32;
            // 
            // Title
            // 
            this.Title.Text = "Titul";
            this.Title.Width = 127;
            // 
            // Language
            // 
            this.Language.DisplayIndex = 6;
            this.Language.Text = "Jazyk";
            // 
            // Author
            // 
            this.Author.DisplayIndex = 2;
            this.Author.Text = "Autor";
            this.Author.Width = 126;
            // 
            // Genre
            // 
            this.Genre.DisplayIndex = 3;
            this.Genre.Text = "Zanr";
            this.Genre.Width = 77;
            // 
            // Publisher
            // 
            this.Publisher.Text = "Vydavatelstvi";
            // 
            // Pages
            // 
            this.Pages.DisplayIndex = 7;
            this.Pages.Text = "Pocet stran";
            this.Pages.Width = 67;
            // 
            // ISBN
            // 
            this.ISBN.DisplayIndex = 4;
            this.ISBN.Text = "ISBN";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(539, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filtrovat";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lvBooks);
            this.Controls.Add(this.btnFilter);
            this.Name = "BookList";
            this.Size = new System.Drawing.Size(614, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Language;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.ColumnHeader Pages;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.Button btnFilter;

    }
}
