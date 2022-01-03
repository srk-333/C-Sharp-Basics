using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO HUMAN");

            //calling class1 method
            Class1 class1 = new Class1();
            class1.Run();
        }

    }
}
