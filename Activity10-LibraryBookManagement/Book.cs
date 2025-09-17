using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10_LibraryBookManagement
{
    internal class Book
    {
        private string title;
        private string author;
        private bool isCheckedOut;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        { 
            get { return author; } 
            set {  author = value; } 
        }
        
        public string IsCheckedOut
        {
            get 
            {
                if (isCheckedOut)
                    return "Checked out";
                else
                    return "Available";
            }   
        }

        public void Borrow()
            { isCheckedOut = true; }

        public void Return()
            { isCheckedOut = false; }

        public Book(string title, string  author)
        {
            this.title = title;
            this.author = author;
            this.isCheckedOut = false; // default ng books is available muna
        }

        public override string ToString()
        {
            return title;
        }
    }
}
