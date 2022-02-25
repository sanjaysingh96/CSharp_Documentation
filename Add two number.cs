using System;

namespace HelloWorld
{
 class Program
  {
  public int sum()
    {
    	Console.WriteLine("Enter First number :");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number :");
        int num2=int.Parse(Console.ReadLine());
        int summ=num1+num2;
        return summ;
    }
    static void Main(string[] args)
    {
    	Program obj= new Program();
        int res=obj.sum();
        Console.WriteLine("Sum ="+res);
        
    }
    
  }
}