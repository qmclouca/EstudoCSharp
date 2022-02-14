/*racing video game has 3 difficulty levels: Easy, Medium, and Hard.
Each difficulty level is assigned maximum time to complete the track: the higher the difficulty, the lower the time.
The program you are given defines Player class and Difficulty enum, and creates 3 Player objects with different difficulties as parameter for the constructor.
Complete the Player constructor, which takes the enum as a parameter to check the time for each difficulty option and outputs the corresponding message:
Easy => "You have 3 minutes 45 seconds"
Medium = > "You have 3 minutes 20 seconds"
Hard => "You have 3 minutes" */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class enumsPractice{
    static void Main(string[] args){
        Player player1 = new Player(Difficulty.Easy);
        Player player2 = new Player(Difficulty.Medium);
        Player player3 = new Player(Difficulty.Hard);
    }    
    /*
    Easy => "You have 3 minutes 45 seconds"
    Medium = > "You have 3 minutes 20 seconds"
    Hard => "You have 3 minutes"
    */

    class Player
    {
        public Player(Difficulty x)
        {
            Difficulty xx = x; 
            Console.WriteLine(xx);         

            switch (xx.ToString()){
                case "Easy":
                    Console.WriteLine("You have 3 minutes 45 seconds");
                    break;
                case "Medium":
                    Console.WriteLine("You have 3 minutes 20 seconds");
                    break;
                case "Hard":
                    Console.WriteLine("You have 3 minutes");                
                    break;
            }            
        }
    }
    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}
