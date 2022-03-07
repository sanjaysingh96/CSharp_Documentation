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
            Hashtable data = new Hashtable();
            data.Add("Name", "Sanjay");
            data.Add("Age",20);
            data.Add("Id", 1096);
            data.Add("Salary", 15000);
            //print using foreach loop
            foreach(DictionaryEntry num in data)
            {
                Console.WriteLine(num.Key+" - "+num.Value);
            }
            Console.ReadLine();
        }
    }
}
