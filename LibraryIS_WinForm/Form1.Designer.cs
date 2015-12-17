namespace LibraryIS_WinForm
{
    partial class Form1
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
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnSelectById = new System.Windows.Forms.Button();
            this.btnUpdatePages = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnInsertPages = new System.Windows.Forms.Button();
            this.btnDeleteById = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(13, 12);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(31, 79);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 1;
            // 
            // btnSelectById
            // 
            this.btnSelectById.Location = new System.Drawing.Point(13, 142);
            this.btnSelectById.Name = "btnSelectById";
            this.btnSelectById.Size = new System.Drawing.Size(75, 23);
            this.btnSelectById.TabIndex = 2;
            this.btnSelectById.Text = "Select by ID";
            this.btnSelectById.UseVisualStyleBackColor = true;
            this.btnSelectById.Click += new System.EventHandler(this.btnSelectById_Click);
            // 
            // btnUpdatePages
            // 
            this.btnUpdatePages.Location = new System.Drawing.Point(94, 142);
            this.btnUpdatePages.Name = "btnUpdatePages";
            this.btnUpdatePages.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePages.TabIndex = 4;
            this.btnUpdatePages.Text = "Update Pgs";
            this.btnUpdatePages.UseVisualStyleBackColor = true;
            this.btnUpdatePages.Click += new System.EventHandler(this.btnUpdatePages_Click);
            // 
            // tbPages
            // 
            this.tbPages.Location = new System.Drawing.Point(55, 105);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(100, 20);
            this.tbPages.TabIndex = 5;
            // 
            // btnInsertPages
            // 
            this.btnInsertPages.Location = new System.Drawing.Point(175, 142);
            this.btnInsertPages.Name = "btnInsertPages";
            this.btnInsertPages.Size = new System.Drawing.Size(75, 23);
            this.btnInsertPages.TabIndex = 7;
            this.btnInsertPages.Text = "Insert Pgs";
            this.btnInsertPages.UseVisualStyleBackColor = true;
            this.btnInsertPages.Click += new System.EventHandler(this.btnInsertPages_Click);
            // 
            // btnDeleteById
            // 
            this.btnDeleteById.Location = new System.Drawing.Point(256, 142);
            this.btnDeleteById.Name = "btnDeleteById";
            this.btnDeleteById.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteById.TabIndex = 10;
            this.btnDeleteById.Text = "Delete ID";
            this.btnDeleteById.UseVisualStyleBackColor = true;
            this.btnDeleteById.Click += new System.EventHandler(this.btnDeleteById_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteById);
            this.Controls.Add(this.btnInsertPages);
            this.Controls.Add(this.tbPages);
            this.Controls.Add(this.btnUpdatePages);
            this.Controls.Add(this.btnSelectById);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnSelectAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnSelectById;
        private System.Windows.Forms.Button btnUpdatePages;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnInsertPages;
        private System.Windows.Forms.Button btnDeleteById;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

