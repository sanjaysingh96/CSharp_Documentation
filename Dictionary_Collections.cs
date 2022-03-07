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
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"Name","Sanjay Singh" },
                {"Age","20" },
                {"Salary","15000" },
                {"Id","1010" },
            };
            //print using foreach loop
            foreach(object num in data)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
