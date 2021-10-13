using System;
using System.IO;
using System.Threading.Tasks;



namespace MyDungeon
{
    [Serializable]

    public class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            
            Start();
            Encounter.FirstEncounter();
            //here is where I create the loop for the game
            while (mainLoop)
            {
                Encounter.RandomEncounter();
            }
        }

        //initiate beginning (method)
        static void Start()
        {
            Console.WriteLine("Welcome to My Dungeon");
            Console.WriteLine("Who are you?: ");
            //waiting for user response
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a weird cold dark empty room. You think it's a dungeon");
            Console.WriteLine("Feeling dazed, confused, and absolutely drained you can't remember anything");
            if (currentPlayer.name == "")
                Console.WriteLine("Oh god, you can't even remember your name....");
            else
                Console.WriteLine("How did you end up here? You only remember your name is " + currentPlayer.name);
            Console.ReadKey();//console read key will wait till the keys pressed to pass this point
            Console.Clear();
            Console.WriteLine("You try to get up and realize you're in a bath of maple syrup.\n" +
                "You muster up all your strength, and pull yourself out of this sticky situation.\n" +
                "You find a large wooden door in what appears to be a dungeon.\n" +
                "You open the door to find your captor is Lord Farquaad?!?!");

        }//ENDSTART()

      

    }//ENDCLASS
}//ENDNAMESPACE