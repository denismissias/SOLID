using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class MyFavouritePrinter : IMachine
    {
        public void Print(Document d)
        {
            Console.WriteLine("I'm printing a document");
        }

        public void Scan(Document d)
        {
            Console.WriteLine("I'm scanning a document");
        }

        public void Fax(Document d)
        {
            Console.WriteLine("I'm faxing a document");
        }
    }
}
