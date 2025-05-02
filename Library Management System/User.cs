using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class User : Person
    {
        public User(int id, string name) : base(id, name)
        {
            BorrwedBooks=  new List<Book>();
        }

        List<Book> BorrwedBooks { get; set; }

        public void Borrwed_Books(Book b)
        {
            if (b.isavailable)
            {
                BorrwedBooks.Add(b);
                b.isavailable = false;
            }
        }

        public void Return_Books(Book b)
        {
            if (BorrwedBooks.Contains(b))
            {
                BorrwedBooks.Remove(b);
                b.isavailable = true;
            }
        }

        public override void displayinfo()
        {
            Console.WriteLine($" id : {id} name :  {name}");

        }
        public void Display_Brrowed_Books()
        {
            displayinfo();
                    }


    }
}
