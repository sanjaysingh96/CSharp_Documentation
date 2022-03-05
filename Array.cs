using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_array = new int[3];
            my_array[0] = 10;
            my_array[1] = 20;
            my_array[2] = 30;
            Console.WriteLine(my_array[0]);
            Console.WriteLine(my_array[1]);
            Console.WriteLine(my_array[2]);
            //find array length
            string[] myarray1 = new string[] { "Sanjay", "Ajay", "Amit","Sumit" };
            Console.WriteLine("Array Length is "+myarray1.Length);
            //print array using foreach loop
            Console.WriteLine("-------Foreach loop--------");
            string[] myarray2 = { "Ram", "Shyam", "Mohan", "Sohan" };
            foreach(string arr in myarray2)
            {
                Console.WriteLine(arr);
            }
            //print array using for loop
            Console.WriteLine("--------for  loop--------");
            int[] myarray3 = new int[] { 11, 22, 33, 44, 55 };
            for(int i = 0; i < myarray3.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
