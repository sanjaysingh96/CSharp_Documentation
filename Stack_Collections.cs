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
            Stack data = new Stack();
            data.Push("Sanjay");
            data.Push("Ajay");
            data.Push("Vipul");
            data.Push("Rahul");
            data.Push("Rohan");
            data.Pop();
            //print using foreach loop
            foreach(object num in data)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("------last Value Peek------");
            Console.WriteLine(data.Peek());
            Console.ReadLine();
        }
    }
}
