using System;
using System.IO;
using System.Threading.Tasks;
using DungeonLibrary;
using MyDungeonApp;

namespace MyDungeon
{
  
    public class Program
    {
        //intiating player new player instance
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;
        
        static void Main(string[] args)
        {
            
            Start();
            Encounters.FirstEncounter();
            //here is where I create the loop for the game
            while (mainLoop)
            {
                Encounters.RandomEncounter();
            }
        }
        
        //initiate beginning (method)
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = " Dungeon of DOOM! ft. Shrek LOL: ";
            Print("               Welcome to My Dungeon     ", 20);
            string title =

               
                @"                    ______
                  .-      -.
                 /            \
                |              |
                |,  .-.  .-.  ,|
                | )(__/  \__)( |
                |/     /\     \|
      (@_       (_     ^^     _)
 _     ) \_______\__|IIIIII|__/__________________________
(_)@8@8{}<________|-\IIIIII/-|___________________________>
       )_/        \          /
      (@           `--------` 


                                              ";


            Console.WriteLine(title);
            Print("Who are you?: ", 30);
            //waiting for user response
            currentPlayer.name = Console.ReadLine();
            Print("Specialty: Fighter, Defender, Runner", 20);
            Weapon sword = new Weapon(8, "Silver Sword", 10, false, 1);
            

            //initiating user class selection in a while loop
            bool flag = false;
            while (flag == false)
            {
                flag = true;
                string input = Console.ReadLine().ToLower();
                if (input == "fighter")
                    
                    currentPlayer.currentClass = Player.PlayerClass.Fighter;
                else if (input == "defender")
                    currentPlayer.currentClass = Player.PlayerClass.Defender;
                else if (input == "runner")
                    currentPlayer.currentClass = Player.PlayerClass.Runner;
                else
                {
                    Console.WriteLine("Please choose a specialty.");
                    flag = false;
                }
               
            }
            //begin first encounter
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Print("You awake in a weird cold dark empty room. You think it is a dungeon...", 20);
            Print("Feeling dazed, confused, and absolutely drained you can't remember a thing...", 20);
            if (currentPlayer.name == "")
                Print("Oh lord, your memory is terrible...\n" +
                    "You can't even remember your name....", 30);
            else
             Print("How did you end up here? You only remember your name is " + currentPlayer.name, 20);
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();//console read key will wait till the keys pressed to pass this point
            Console.Clear();
            Print("You try to get up and realize you're in a bath of maple syrup.\n" +
                "You muster up all your strength, and pull yourself out of this sticky situation.\n" +
                "You find a large wooden door in what appears to be a dungeon.\n" +
                "You open the door to find your captor is Lord Farquaad?!?!\n", 20);

        }//ENDSTART()

        //arguments go within the parens
        public static void Print(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();

	    }


        public static void ProgressBar(string fillerChar, string backgroundChar, decimal value, int size)
        {   //creating XP ProgressBar
            int dif = (int)(value * size);
            for (int i = 0; i < size; i++)
            {
                if (i < dif)
                    Console.Write(fillerChar);
                else
                    Console.WriteLine(backgroundChar);
            }
        }



} //END CLASS
    }//END NAMESPACE

