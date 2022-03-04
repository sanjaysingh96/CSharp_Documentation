using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        string name;
        int age;
       static void Main(string[] args)
        {
            Program obj = new Program();
            obj.name=("Sanjay");
            obj.age=(21);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.ReadLine();
        }
    }
}
