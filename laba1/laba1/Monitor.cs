using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Monitor
    {
        //firma string
        //tip string
        //diagonal float
        public string firm { get; set; }
        public string type { get; set; }
        public float diagonal { get; set; }
        public Monitor()
        {
            firm = "";
            type = "";
            diagonal = 0;
        }
        public Monitor(string Firm, string Type, float Diagonal)
        {
            firm = Firm;
            type = Type;
            diagonal = Diagonal;
        }
        public void Input()
        {
            Console.WriteLine("Фирма");
            firm = Console.ReadLine();
            Console.WriteLine("Тип");
            type = Console.ReadLine();
            Console.WriteLine("Диагональ");
            diagonal = float.Parse(Console.ReadLine());
        }
        public void GetInfo()
        {
            Console.WriteLine($"Фирма: {firm}");
            Console.WriteLine($"Тип: {type}");
            Console.WriteLine($"Диагональ: {diagonal}");
        }
    }
}
