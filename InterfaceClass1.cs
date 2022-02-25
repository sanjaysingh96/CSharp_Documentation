using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Car
    {
        void speed();
        void color();
    }
    class Bmw : Car
    {
        public void speed()
        {
            Console.WriteLine("Bmw Car Maximum Speed Is 400km/h :");
        }
        public void color()
        {
            Console.WriteLine("Bmw Car Color is Red :");
        }
    }
    class Thar : Car
    {
        public void speed()
        {
            Console.WriteLine("Thar Car Maximum Speed is 300km/h :");
        }
        public void color()
        {
            Console.WriteLine("Thar Car Color is Black :");
        }
    }
}
