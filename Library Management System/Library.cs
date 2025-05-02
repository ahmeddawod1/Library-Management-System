using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Library
    {
        public Library()
        {
            Books = new List<Book>();
            Member = new List<Person>();
        }

        List<Book> Books { get; set; }
        List<Person> Member { get; set; }

        public bool AddBook(Book b)
        {
            if (Books.Contains(b))
            {
                return false;
            }
            Books.Add(b);
            return true;
        }
        public bool AddMember(Person P)
        {
            if (Member.Contains(P))
            {
                return false;
            }
            Member.Add(P);
            return true;

        }

        public Book findBook(int id)

        {
            foreach (var b in Books)
            {
                if (b.id == id) { return b; }
            }
            return null;
        }

        public Person findmember(int id)

        {
            foreach (var m in Member)
            {
                if (m.id == id) { return m; }
            }
            return null;
        }

        
        public void DisplayBooks()
        {
            Console.WriteLine("List of Books:");
            foreach (var book in Books)
            {
                book.dispalyinfo();
            } }


        public void DisplayMember()
        {
            Console.WriteLine("List of Members:");
            foreach (var member in Member)
            {
                member.displayinfo();
            }

        }
    }
}
