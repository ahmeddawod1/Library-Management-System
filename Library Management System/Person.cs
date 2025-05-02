using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
   abstract class Person
    {
        protected Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public   int id { get; set; }
       public string name { get; set; }

      public  abstract void displayinfo();

    }
}
