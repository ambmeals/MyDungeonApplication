using System;
using System.IO;
using System.Threading.Tasks;
using DungeonLibrary;



namespace MyDungeon
{
  
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
            Console.Title = " Dungeon of DOOM! ft. Shrek LOL: ";
            Console.WriteLine("               Welcome to My Dungeon     ");
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

        public class Encounter
        {   //Create randomizer for attack
            static Random rand = new Random();


            //Encounter Generic


            //Encounters
            //void will not return a variable
            public static void FirstEncounter()
            {
                Console.WriteLine("You stumble over piles of books while trying to reach your captor.\n" +
                    "Luckily, while stumbling, you're able to grab a sharp fork.");
                Console.WriteLine("Lord Farquaad begins to turn around....");
                Console.ReadKey();
                Combat(false, "Lord Farquaad", 1, 3);
            }

            public static void BasicFightEncounter()
            {
                Console.Clear();
                Console.WriteLine(" You turn the corner and there you see another figure in your way...\n");
                Console.ReadKey();
                Combat(true, "", 0, 0);
            }

            //EXTRA ENOUNTERS
            public static void Rumplestiltskin()
            {
                Console.Clear();
                Console.WriteLine(" The door suddenly bursts open with a gust of wind.\n" +
                    " You see a short man covered in gold...\n");
                Console.WriteLine(" He claps his hands and suddenly is holding two gold knives...\n ");
                Console.ReadKey();
                Combat(false, " Rumplestiltskin", 2, 3);
            }

            public static void WaffleMan()
            {
                Console.Clear();
                Console.WriteLine(" You peer down the long dark hallway...\n" +
                    " It reeks of alcohol and syrup ");
                Console.WriteLine(" A large....WAFFLE MAN?! Appears before you.\n " +
                    "Maybe he had something to do with your syrup bath....");
                Console.ReadKey();
                Combat(false, " Waffle Man", 1, 3);
            }

            public static void FairyGodmother()
            {
                Console.Clear();
                Console.WriteLine(" You open a window to maybe jump out of this place...\n" +
                    " Suddenly, a sound of buzzing fills your ears ");
                Console.WriteLine(" Fairy Godmother appears right in your face and smacks your nose with her wand!\n " +
                    " Are you going to take that from a bedazzled lady?! ");
                Console.ReadKey();
                Combat(false, " Fairy Godmother", 1, 4);
            }

            public static void CaptainHook()
            {
                Console.Clear();
                Console.WriteLine(" You turn a corner and feel like you might be getting out of this maze...\n" +
                    " A hearty laugh comes from behind you ");
                Console.WriteLine(" Captain Hook stands behind you, creating a melody with his hook\n" +
                    " You can't lie, the tune is a BOP! Too bad it is about your impending doom...");
                Console.ReadKey();
                Combat(false, " Captain Hook ", 2, 4);
            }

            public static void JackandJill()
            {
                Console.Clear();
                Console.WriteLine(" You're catching your breathe when you suddenly smell something terribly to sweet ");
                Console.WriteLine(" Two plump figures with terrible haircuts and out of season lederhosen stand before you\n" +
                    " You can't tell if they are couple or related...gross...");
                Console.ReadKey();
                Combat(false, " Jack and Jill ", 3, 4);
            }

            public static void PuppetMaster()
            {
                Console.Clear();
                Console.WriteLine(" Suddenly you are surrounded by tiny puppets hitting your knees ");
                Console.WriteLine(" At first it's funny, maybe even charming...\n" +
                    "Then a puppet pulls out a fight and you know you what you must do!");
                Console.ReadKey();
                Combat(false, " Puppet Master ", 2, 4);
            }

            public static void Shrek()
            {
                Console.Clear();
                Console.WriteLine(" You hear a loud stomping coming from down the hall ");
                Console.WriteLine(" It rattles the stones beneath your feet...\n" +
                    " Shrek comes from behind the wall and is using a human bone to pluck his teeth!\n" +
                    " You think he is there to help but he starts licking his lips as he is looking at you.\n" +
                    "Says, 'he hopes you've kept the fork for him to use on you! ");
                Console.ReadKey();
                Combat(false, " Shrek ", 1, 4);
            }



            //Encounter Tools
            public static void RandomEncounter()
            {
                switch (rand.Next(0, 8))
                {
                    case 0:
                        BasicFightEncounter();
                        break;
                    case 1:
                        Rumplestiltskin();
                        break;
                    case 2:
                        WaffleMan();
                        break;
                    case 3:
                        FairyGodmother();
                        break;
                    case 4:
                        CaptainHook();
                        break;
                    case 5:
                        JackandJill();
                        break;
                    case 6:
                        PuppetMaster();
                        break;

                }
            }

            //bool will ask if the combat is a random creature or specilized
            public static void Combat(bool random, string name, int power, int health)
            {
                string n = "";
                int p = 0;
                int h = 0;
                if (random)
                {
                    n = GetName();
                    p = Program.currentPlayer.GetPower();
                    h = Program.currentPlayer.GetHealth();
                }
                else
                {
                    n = name;
                    p = power;
                    h = health;
                }
                //while health is greater than 0
                while (h > 0)
                {
                    Console.Clear();
                    Console.WriteLine(n);
                    Console.WriteLine(p + "/" + h);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("| [A]ttack [D]efend |");
                    Console.WriteLine("| [R]un    [H]eal   |      ");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("   Potions:  " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                    string input = Console.ReadLine();
                    if (input.ToLower() == "a" || input.ToLower() == "attack")
                    {
                        //ATTACK
                        Console.WriteLine(" With quick incredible reflexes, you stick your weapon right into your enemy!\n" +
                            "The " + n + " gives you a sock on the back ");
                        //power of the enemy minus your current player armor
                        //higher armor value will not damage as easily
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)//need to make sure the damage does not go negative
                            damage = 0;
                        int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                        Console.WriteLine(" You lose " + damage + " health and deal " + attack + " damage ");
                        //subtract from the value that the current player health already is
                        Program.currentPlayer.health -= damage;
                        h -= attack;
                    }
                    else if (input.ToLower() == "d" || input.ToLower() == "defend")
                    {
                        //DEFEND
                        Console.WriteLine(" As " + n + " prepares to smack it down on you,\n" +
                            " you ready your fork for defense... ");
                        //the power of the opponent will be divided by 4
                        int damage = (p / 4) - Program.currentPlayer.armorValue;
                        if (damage < 0)//need to make sure the damage does not go negative
                            damage = 0;
                        int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                        Console.WriteLine(" You lose " + damage + " health and deal " + attack + " damage ");
                        //subtract from the value that the current player health already is
                        Program.currentPlayer.health -= damage;
                        h -= attack;
                    }
                    else if (input.ToLower() == "r" || input.ToLower() == "run")
                    {
                        //RUN
                        if (rand.Next(0, 2) == 0)
                        {
                            Console.WriteLine(" As you dash away from, " + n + " scratches your shoulder and strikes you.\n" + " You fly forward. ");

                            int damage = p - Program.currentPlayer.armorValue;
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine(" You lose " + damage + " health and are unable to escape.");
                        }
                        else
                        {
                            Console.WriteLine(" You use your cat like reflxes to evade " + n + " and you sucessfully get away! ");
                            Console.ReadKey();

                            //go to store
                            Shop.LoadShop(Program.currentPlayer);

                        }

                    }
                    else if (input.ToLower() == "h" || input.ToLower() == "heal")
                    {
                        //HEAL
                        if (Program.currentPlayer.potion == 0)
                        {
                            Console.WriteLine(" Groppin' around desperatly, you grasp for a potion.\n" +
                                " Unfortunately you only find used tissues. ");
                            int damage = p - Program.currentPlayer.armorValue;
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine("" + n + "  smacks your head and you and candy drops see butterflies. \n" +
                                "You lose " + damage + " health! ");
                        }
                        else
                        {
                            Console.WriteLine(" You reach into your sack and pull out a neon green tube.\n " +
                                " You guzzle it down..... ");
                            int potionV = 5;
                            Console.WriteLine(" You gain " + potionV + " health ");
                            Program.currentPlayer.health += potionV;
                            Console.WriteLine(" As you were distracted, the " + n + " charged forward and struck you! ");
                            int damage = (p / 2) - Program.currentPlayer.armorValue;
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine(" You lose " + damage + " health. ");
                        }
                        Console.ReadKey();
                    }
                    if (Program.currentPlayer.health <= 0)
                    {
                        //DEATH CODE
                        Console.WriteLine(" As " + n + " stands proudly over you, they easily strike you dead. " + n +
                            "\nEasily killed you");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    Console.ReadKey();
                }

                int c = Program.currentPlayer.GetCoins();
                Console.WriteLine(" As you stand over your vanquished conquest the " + n + " its body dissovles " + c + " gold coins!");
                //this should add coins to your amount
                Program.currentPlayer.coins += c;
                Console.ReadKey();


            }

            public static string GetName()
            {
                switch (rand.Next(0, 10))
                {
                    case 0:
                        return "Captain of Duloc";
                    case 1:
                        return "Headless Horseman";
                    case 2:
                        return "Duloc Mascot";
                    case 3:
                        return "Angry Mob";
                    case 4:
                        return "Kyle";
                    case 5:
                        return "Cyclops";
                    case 6:
                        return "Gnomes";
                    case 7:
                        return "Dragon";
                    case 8:
                        return "Thumbelina";
                    case 9:
                        return "Pirates";
                    case 10:
                        return "Witches";
                }
                return "Prince Charming";
            }

        } //END CLASS
    }//END NAMESPACE




}//ENDCLASS
//ENDNAMESPACE