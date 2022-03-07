using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>()
            {
                12,22,75,87,45,97,75,34
            };
            foreach(int num in data)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
