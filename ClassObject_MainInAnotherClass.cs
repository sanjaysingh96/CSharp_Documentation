using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        public int id;
        public string name;
    }
    class Test
    {
        public static void Main(string [] args)
        {
            Program obj = new Program();
            obj.id = 12;
            obj.name = "Sanjay";
            Console.WriteLine("Id is ={0} Name is ={1}",obj.id,obj.name);
            Console.ReadLine();
        }
    }
}
