using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Semaphore MyFavoriteSColor;

        MyFavoriteSColor = Semaphore.Red;

        Console.WriteLine(MyFavoriteSColor);
    }
}

enum Semaphore : int
{
    Red = 200,
    Yellow  = 300,
    Green = 400
}