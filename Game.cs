using System;
public class Game {

    public static bool canPlay = true;

    public Game () {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo";
        Cave.StartMessage = "You have entered a cave.";
    }

    //Runs at the start of the game
    public void Start (){
        Console.WriteLine("Please type in your name");
        name = Console.ReadLine();
        Console.WriteLine("Your Player Name is" + name);
        Cave.Enter();
        while(Game.canPlay) {
            System.Threading.Thread.Sleep(2000);
            Walk();
        }
        Console.WriteLine("You Died"); 
       
    }

    private void Walk (){
        Random randomNum = new Random();
        
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }
    //Game Levels
    private LevelBase Cave = new LevelBase();
    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    
    //Game Weapons
    private WeaponBase Gun = new WeaponBase();

    private WeaponBase Rifle = new WeaponBase();

    private WeaponBase Knife = new WeaponBase();

    private static bool canPlay = true;

    public string name;

    private int score;
}
 /*
        After prompt the game for a name we:
        Enter a cave
        find Health.
        Meet a dragon. (need an enemy class)
        Pick weapon.
        Battle dragon. (Battle class)
        If dragon wins: get Health and ammo
        if dragon wins: lose Health;
        */