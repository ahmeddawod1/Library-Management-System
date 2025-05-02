using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Book
    {
        public Book(int id, string title, string authername)
        {
            this.id = id;
            this.title = title;
            this.authername = authername;
        }

        public  int id { get; set; }
       public  string title { get; set; }
        public string authername { get; set; }
        public bool isavailable { get; set; } = false;
        public void dispalyinfo()
        {
            Console.WriteLine($"id : {id} , Auther Name : {authername} , title : {title} ");
        }
    }

    
}
