using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public void insert(int Id, string Name, int Age)
        {
            id = Id;
            name = Name;
            age = Age;
        }
        public void display()
        {
            Console.WriteLine("Id is={0} Name is={1} Age is={2}",id,name,age);
        }
    }
    class Test
    {
        public static void Main(string [] args)
        {
            Student obj1 = new Student();
            obj1.insert(101,"Sanjay",20);
            obj1.display();
            Student obj2 = new Student();
            obj2.insert(102, "Ajay", 24);
            obj2.display();
            Console.ReadLine();
        }
    }
}
