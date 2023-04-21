using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
            Console.WriteLine(".-.");
            Console.WriteLine("(o o)");
            Console.WriteLine(" |o|");
            Console.WriteLine(" | |");
            Console.WriteLine(" .~~.");
            Console.WriteLine("Ghost");
            Console.WriteLine("c_" + "  " + "  " + "___");
            Console.WriteLine("  \\__|__|__");
            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
           // int newgf= Convert.ToInt32(weight);
            bool tf = true;
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(tf);

            Console.Write("Enter your favorite number!: ");
            int faveNumber = int.Parse(Console.ReadLine());
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);

        }
    }
}
