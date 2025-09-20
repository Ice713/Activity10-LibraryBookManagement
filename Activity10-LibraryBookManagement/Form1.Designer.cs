namespace Activity10_LibraryBookManagement
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
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(200, 62);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(171, 69);
            this.listBoxBooks.TabIndex = 0;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.Location = new System.Drawing.Point(197, 162);
            this.labelBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(54, 17);
            this.labelBook.TabIndex = 1;
            this.labelBook.Text = "Book: ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(198, 188);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(197, 213);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status:";
            // 
            // buttonStatus
            // 
            this.buttonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatus.Location = new System.Drawing.Point(200, 238);
            this.buttonStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(170, 26);
            this.buttonStatus.TabIndex = 4;
            this.buttonStatus.Text = "Borrowed / Returned";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.listBoxBooks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Library Book Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonStatus;
    }
}

