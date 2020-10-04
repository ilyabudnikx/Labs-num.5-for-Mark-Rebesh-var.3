using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Printer //вывод инфы
    {
        public void iAmPrinting(ICarManagment someobj)
        {
            Console.WriteLine(someobj.GetType());
            Console.WriteLine(someobj.ToString());
        }
    }
}
