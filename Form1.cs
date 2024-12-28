using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        //kitap sinifi
        public class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }

            public Book(string name, string author)
            {
                Name = name;
                Author = author;
            }

            public override string ToString()
            {
                return $"{Name} - {Author}";
            }
        }

        //kitap listesi
        private List<Book> bookList = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text.Trim();
            string authorName = txtAuthorName.Text.Trim();

            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(authorName))
            {
                MessageBox.Show("Book name or author name cannot empty. Please enter a book name and author name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bookList.Add(new Book(bookName, authorName));
            MessageBox.Show($"\"{bookName}\" adlý kitap eklendi.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBookName.Clear();
            txtAuthorName.Clear();
        }

    }
}