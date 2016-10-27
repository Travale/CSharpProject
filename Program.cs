<<<<<<< HEAD
﻿    using System;

    public class Program
    {
=======
using System;
>>>>>>> 80825164333b9a71bdcb7eb268370d3fe891e526

public class Program
{

    public static Game myGame = new Game();

    public static void Main(string[] args)
    {
        Console.WriteLine("Please type in your name");
        myGame.name = Console.ReadLine();
        Console.WriteLine("Your Player Name is" + myGame.name);
        myGame.Start();
    }
}