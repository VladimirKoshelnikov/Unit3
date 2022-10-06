using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string MyName = "Владимир";
        byte age = 27;
        Console.WriteLine("Привет, Мир");
        Console.WriteLine();
        Console.WriteLine($"Меня зовут {MyName}");
        Console.WriteLine($"Мой возраст {age}");

        Console.ReadKey();
    }
}