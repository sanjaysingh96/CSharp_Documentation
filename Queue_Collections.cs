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
            Queue data = new Queue();
            data.Enqueue(12);
            data.Enqueue(13);
            data.Enqueue(58);
            data.Enqueue(74.5);
            data.Enqueue("sanjay");
            data.Enqueue(100);
            data.Dequeue();
            foreach(object num in data)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
