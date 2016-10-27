    using System;

    public class Program
    {

        public static PowerUp Health = new PowerUp();
        
        public static PowerUp Ammo = new PowerUp();
        public static void Main(string[] args)
        {
            Health = new PowerUp();
            Health.duration = 10;
            Health.RunPowerUp();
            Console.WriteLine(Health.duration);

            Health.RechargePowerUp(20);
            Ammo.RechargePowerUp(300);
        }
    }

