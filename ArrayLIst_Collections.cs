using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            data.Add(10);
            data.Add("Sanjay");
            data.Add(32);
            data.Add(32.5);
            data.Add("Ajay");
            //print using foreach loop
            foreach(var num in data)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
