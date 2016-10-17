using System;

namespace ConsoleApplication
{
    public class Program
    {

        public static PowerUps Health;
        public static PowerUps Ammo;
        static string myString = "Hello World.";
        public static void Main(string[] args)
        {
            Health.RunPowerUP();
            Ammo.RunPowerUP();
            Console.WriteLine(myString);
        }
    }
}
