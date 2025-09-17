using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10_LibraryBookManagement
{
    public partial class Form1 : Form
    {
        private List<Book> books;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            books = new List<Book>
            {
                new Book("C# Programming", "John Smith"),
                new Book("The Lord of the Rings", "J.R.R. Tolkien"),
                new Book("Introduction to Algorithms", "Thomas H. Cormen"),
                new Book("A Brief History of Time", "Stephen Hawking")
            };

            listBoxBooks.Items.Clear(); // clear listbox

            // add items mula sa List<Book>
            foreach (Book book in books)
            {
                listBoxBooks.Items.Add(book);
            }
        }
    }
}
