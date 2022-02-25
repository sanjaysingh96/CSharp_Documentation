using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Bmw obj1 = new Bmw();
            obj1.color();
            obj1.speed();
            Thar obj2 = new Thar();
            obj2.color();
            obj2.speed();
            Console.ReadLine();
        }
    }
}
