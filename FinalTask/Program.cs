using System;

namespace FinalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age;
            bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("Enter your birthdate:");
            string birthdate = Console.ReadLine();
            
            Console.WriteLine("Your birthdate is {0}", birthdate);

            Console.ReadKey();
            
        }
    }
}
