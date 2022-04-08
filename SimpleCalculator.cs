using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result is : "+result);
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction result is : "+result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result is :"+result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is :"+result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator ( +, -, *, /)");
            string op = Console.ReadLine();

            if(op == "+")
            {
                Program.Addition(num1, num2);
            }
            else if(op == "-")
            {
                Program.Substraction(num1, num2);
            }
            else if(op == "*")
            {
                Program.Multiplication(num1, num2);
            }
            else if(op == "/")
            {
                Program.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator !! Enter Valied Operator");
            }

            Console.ReadLine();
            
        }
    }
}
