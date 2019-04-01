using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();
            monitor.Input();
            monitor.GetInfo();
            Console.ReadKey();
        }
    }
}
