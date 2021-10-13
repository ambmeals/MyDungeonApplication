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
            //creating the functionality to save the game
            if (!Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }

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
            Console.WriteLine("You awake in a weird cold dark empty room. You think it's a basement.");
            Console.WriteLine("Feeling dazed, confused, and absolutely drained you can't remember anything");
            if (currentPlayer.name == "")
                Console.WriteLine("Oh god, you can't even remember your name....");
            else
                Console.WriteLine("How did you end up here? You only remember your name is " + currentPlayer.name);
            Console.ReadKey();//console read key will wait till the keys pressed to pass this point
            Console.Clear();
            Console.WriteLine("You try to get up and realize you're in a basement.\n" +
                "Quickly, you start banging your hands on the walls until you feel a door handle.\n" +
                "The handle is not easy to budge but you're able to turn it.\n" +
                "Your captor is a Zombie Cyborg??!");

        }//ENDSTART()

        public static void Save()
        {

        }
        public static void Load()
        {

        }


    }//ENDCLASS
}//ENDNAMESPACE
