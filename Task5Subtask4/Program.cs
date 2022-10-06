using System;
using System.Xml.Linq;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName = "Владимир";
        Console.WriteLine("Привет, мир");
        Console.WriteLine();
        Console.WriteLine("Меня зовут {0}", MyName);

        //0 — позиция нашей переменной. То есть переменная будет на позиции 0.


        //Также мы можем вставить в строку не переменную, а строковый литерал:
        Console.WriteLine("Меня зовут {0}", "Маша");


        //И, естественно, мы можем использовать несколько переменных при выводе. В этом случае располагаем их в порядке нумерации «мест».
        var age = 27;
        var weight = 74;
        Console.WriteLine("Возраст {0} \n Вес {1}", age, weight);

        //Для выполнения задания добавим переменных
        string name;
        string favcolor = "Лавандовый";

        name = MyName;

        Console.WriteLine("{0}\n{1}\n{2}", name, age, favcolor);

        Console.ReadKey();
    }
}