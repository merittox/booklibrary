namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBooks = new ListBox();
            bottomtext = new Label();
            btnAddBook = new Button();
            btnSearchBook = new Button();
            btnListAllBook = new Button();
            txtBookName = new TextBox();
            txtAuthorName = new TextBox();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(12, 157);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(879, 439);
            lstBooks.TabIndex = 0;
            // 
            // bottomtext
            // 
            bottomtext.AutoSize = true;
            bottomtext.Location = new Point(12, 599);
            bottomtext.Name = "bottomtext";
            bottomtext.Size = new Size(0, 15);
            bottomtext.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(12, 99);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(273, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(12, 70);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(273, 23);
            btnSearchBook.TabIndex = 3;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // btnListAllBook
            // 
            btnListAllBook.Location = new Point(12, 128);
            btnListAllBook.Name = "btnListAllBook";
            btnListAllBook.Size = new Size(273, 23);
            btnListAllBook.TabIndex = 4;
            btnListAllBook.Text = "List All Books";
            btnListAllBook.UseVisualStyleBackColor = true;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(12, 12);
            txtBookName.Name = "txtBookName";
            txtBookName.PlaceholderText = "Enter book name";
            txtBookName.Size = new Size(273, 23);
            txtBookName.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(12, 41);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Enter author";
            txtAuthorName.Size = new Size(273, 23);
            txtAuthorName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 622);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookName);
            Controls.Add(btnListAllBook);
            Controls.Add(btnSearchBook);
            Controls.Add(btnAddBook);
            Controls.Add(bottomtext);
            Controls.Add(lstBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBooks;
        private Label bottomtext;
        private Button btnAddBook;
        private Button btnSearchBook;
        private Button btnListAllBook;
        private TextBox txtBookName;
        private TextBox txtAuthorName;
    }
}
