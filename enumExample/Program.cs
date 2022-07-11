using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExample
{
    enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Month m = Month.Apr;
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
