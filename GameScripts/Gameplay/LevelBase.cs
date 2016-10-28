using System;
public class LevelBase {

    public string StartMessage;
    public bool entranceOpen = true;
    
    public string[] environment = {"Cold","Wet","Dark"};

    public string[] objects = {"Rocks","Ravine","River","Lava"};

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i){
        if(i < objects.Length-1) {
           Console.WriteLine("You've alked into " + objects[i]); 
           if(objects[i] == "Lava") {
               Program.canPlay = false;
           }
        } else {
            Console.WriteLine("Your path is clear");
        }
    }
}