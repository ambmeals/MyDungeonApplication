using System;
using System.IO;
using System.Threading.Tasks;
using DungeonLibrary;
using MyDungeonApp;

namespace MyDungeon
{
  
    public class Program
    {

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
            Print("Who are you?: ", 60);
            //waiting for user response
            currentPlayer.name = Console.ReadLine();
            Print("Class: Shrek, Fiona, Donkey", 30);


            bool flag = false;
            while (flag == false)
            {
                flag = true;
                string input = Console.ReadLine().ToLower();
                if (input == "shrek")
                    currentPlayer.currentClass = Player.PlayerClass.Shrek;
                else if (input == "fiona")
                    currentPlayer.currentClass = Player.PlayerClass.Fiona;
                else if (input == "donkey")
                    currentPlayer.currentClass = Player.PlayerClass.Donkey;
                else
                {
                    Console.WriteLine("Please choose an existing class");
                    flag = false;
                }
               
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Print("You awake in a weird cold dark empty room. You think it is a dungeon...", 30);
            Print("Feeling dazed, confused, and absolutely drained you can't remember a thing...", 30);
            if (currentPlayer.name == "")
                Print("Oh god, you can't even remember your name....", 60);
            else
                Print("How did you end up here? You only remember your name is " + currentPlayer.name, 30);
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();//console read key will wait till the keys pressed to pass this point
            Console.Clear();
            Print("You try to get up and realize you're in a bath of maple syrup.\n" +
                "You muster up all your strength, and pull yourself out of this sticky situation.\n" +
                "You find a large wooden door in what appears to be a dungeon.\n" +
                "You open the door to find your captor is Lord Farquaad?!?!\n", 30);
           

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
        {
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

