using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_1
{
    public class Student
    {
        //Atriputes
        int id,level, age;
        string name;

        //Constructor
        public Student()
        {
            id = 1;
            name = "Ahmed";
            age = 6;
            level = 1;
        }

        //Encapsulation
        public int Id { set; get; }
        public string Name { set; get; }
        public int Level { set; get; }
        public int Age { get; set; }

        //Methode
        public void Read()
        {
            Console.Write("Enter Student Id: ");
            Id =int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            Name =Console.ReadLine();
            Console.Write("Enter Student Level: ");
            Level =int.Parse(Console.ReadLine());
            Console.Write("Enter Student Age: ");
            Age =int.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Student Id: "+Id);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Level: " + Level);
            Console.WriteLine("Student Age: " + Age);
        }
    }
}
