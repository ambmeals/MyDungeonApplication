using DungeonLibrary;
using MyDungeon;
using System;
using System.Collections.Generic;
using System.Linq;



namespace MyDungeonApp
{
    public class Encounters
    {   //Create randomizer for attack
        static Random rand = new Random();

        //Encounters
        //void will not return a variable
        public static void FirstEncounter()
        {
            Print("You begin to charge at your captor.\n" +
                "Luckily, you're able to grab a candied sword.\n", 20);
            Print("Lord Farquaad begins to turn around....\n", 20);
            Print("Press Enter to begin.", 20);
            Console.ReadKey();
            Combat(false, "Lord Farquaad", 1, 3);

        }

        public static void BasicFightEncounter()
        {
            Console.Clear();
            Print("You turn the corner and there you see another figure in your way...\n" +
                "These halls seem like a never ending illusion.\n", 20);
            Print("Press Enter to begin.", 20);
            Console.ReadKey();
            Combat(true, "", 0, 1);
        }

        //EXTRA ENOUNTERS // NOT RANDOM
        public static void Rumplestiltskin()
        {
            Console.Clear();
            Print("You've found some solitude and safety in a room with wool threading spools.\n" +
                "You realize the threads on these spools are made of GOLD.\n" +
                "The door suddenly bursts open with a gust of wind.\n" +
                "You see a lean man covered in gold...\n", 20);
            Print("He claps his hands and suddenly has a gold knife in each hand...\n ", 20);
            Print("Press Enter to begin.", 20);
            Console.ReadKey();
            Combat(false, " Rumplestiltskin", 2, 4);
        }

        public static void WaffleMan()
        {
            Console.Clear();
            Print("You are running down the long never ending hallway...\n" +
                "You vere left and suddenly you run into a room that is filled with flour and maple syrup.\n" +
                "It reeks of alcohol and syrup...like an alcoholic waffle??\n", 20);
            Print("A large...WAFFLE MAN?! Appears before you.\n " +
                "Maybe he had something to do with your maple syrup bath...\n", 20);
            Print("Press Enter to begin.", 20);
            string title = @"    __  __             
 \ \        / /   / _|/ _| |    |  \/  |            
  \ \  /\  / /_ _| |_| |_| | ___| \  / | __ _ _ __  
   \ \/  \/ / _` |  _|  _| |/ _ \ |\/| |/ _` | '_ \ 
    \  /\  / (_| | | | | | |  __/ |  | | (_| | | | |
     \/  \/ \__,_|_| |_| |_|\___|_|  |_|\__,_|_| |_|";
            Console.WriteLine(title);
            Console.ReadKey();
            Combat(false, " Waffle Man", 1, 3);
        }

        public static void FairyGodmother()
        {
            Console.Clear();
            Print("You are finding escaping to be difficult.\n" +
                "You try to open a window to maybe jump out of this place...\n" +
                "It doesn't pry open easily and you kick the window out!\n" +
                "Suddenly, a sound of LOUD buzzing fills your ears\n", 20);
            Print("Fairy Godmother appears right in your face and smacks your nose with her wand!\n" +
                "Are you going to take that from a bedazzled lady?! \n", 20);
            Print("Press Enter to begin.\n", 20);
            string title = @"                .--.   _,
          .--;    \ /(_
         /    '.   |   '-._    . ' .
        |       \  \    ,-.)  -= * =-
         \ /\_   '. \((` .(    '/. '
          )\ /     \ )\  _/   _/
         /  \\    .-'   '--. /_\
        |    \\_.' ,        \/||
";
            Console.WriteLine(title);
            Console.ReadKey();
            Combat(false, " Fairy Godmother", 1, 4);
        }

        public static void CaptainHook()
        {
            Console.Clear();
            Print("You turn a corner and feel like you might be getting out of this maze...\n" +
                "You find a door placed at an odd angle...\n" +
                "You think it could be a reprieve. You see lots of treasure in here....\n" +
                "To the left of the room is a crocodile giving you side eye??\n" +
                "A hearty laugh comes from behind you\n", 20);
            Print("Captain Hook stands behind you, creating a melody with his hook\n" +
                "You can't lie, the tune is a BOP! Too bad it is about your impending doom...\n", 20);
            Console.WriteLine("");
            Print("Press Enter to begin.", 20);

            Console.ReadKey();
            Combat(false, " Captain Hook ", 1, 2);
        }

        public static void JackandJill()
        {
            Console.Clear();
            Print("You're able to fit yourself through a crack in the wall...\n" +
                "It leads you to a room filled with candy covered in blood?!\n" +
                "It reeks of a sweet sick situation.\n", 20);
            Print("Two plump figures with terrible haircuts and out of season lederhosen appear before you\n" +
                "You can't tell if they are married or related...\n", 20);
            Console.WriteLine();
            Print("Press Enter to begin.", 20);
            string title = @"

       o   oo                     
     o         o   o                
        ___o o   o                  
       /`._;o       o               
      |   /   o                     
      ;_  |                        
        `-'  
          
                ____
              .' /  '.
             / (  .- '\
            | '.__\/__  |
            |    /\  '.|
             \.-'  )  /
              '.__/_.'
                    ____
                  .' /:::.
                 / (:::-'\
                |:\__\/ __ |

                |::::/\:::\|
                 \::'  )::/
                  '.__/::";
            Console.WriteLine(title);
            Console.ReadKey();
            Combat(false, " Jack and Jill ", 2, 4);
        }

        public static void PuppetMaster()
        {
            Console.Clear();
            Print("You find a charming room that is quiet. There is a stage and rows of empty seats...\n"
               , 20);
            Print("Suddenly you are surrounded by tiny puppets hitting your knees\n", 20);
            Print("At first it's funny, maybe even charming...\n" +
                "Then a puppet pulls out a knife and you know you what you must do!\n", 20);
            Console.WriteLine("");

            Print("Press Enter to begin.", 20);
            string title = @"     __     __
           (( \---/ ))
            )__   __(
           / ()___() \
           \  /(_)\  /
            \ \_|_/ /
      _______>     <_______
     //\      |>o<|      /\\
     \\/___           ___\//
           |         |
           |         |
           |         |
           |         |
           `--....---'
             \     \
              \     `.    
               \      `.
";
            Console.WriteLine(title);
            Console.ReadKey();
            Combat(false, " Puppet Master ", 1, 4);
        }



        public static void GingerBreadMan()
        {
            Console.Clear();
            Print("Wow, the room you have stumbled upon smells like Christmas!\n" +
                "You can't help but notice most of the furniture is made of candy canes and gum dropes...\n" +
                "You look down and a Ginger Breadman is running straight at you.\n" +
                "This no longer feels like Christmas and suddenly feels like your DOOM!\n"
                , 20);
            Print("Press Enter to begin.", 20);
            string title = @"      ,-.
                                   _(*_*)_      
                                  (_  o  _)
                                    / o \
                                   (_/ \_)      
";
            Console.WriteLine(title);
            Console.ReadKey();
            if (IsChristmas())
                Combat(false, "Santa", 3, 5);
            Combat(false, " Ginger BreadMan", 1, 3);
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
                case 7:
                    GingerBreadMan();
                    break;
                case 8:
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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("---------------------");
                Console.WriteLine("| [A]ttack [D]efend |");
                Console.WriteLine("| [R]un    [H]eal   |              [E]xit                                 ");
                Console.WriteLine("---------------------");
                Console.WriteLine("   Potions:  " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //ATTACK
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Print("With quick and impeccable reflexes, you stick your weapon right into your enemy!\n" +
                        "The " + n + " gives you a sock on the back\n", 20);


                    //power of the enemy minus your current player armor
                    //higher armor value will not damage as easily
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)//need to make sure the damage does not go negative
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4) + ((Program.currentPlayer.currentClass == Player.PlayerClass.Defender) ? 2 : 0);//if they are Attacker, they get +2 of attack
                    Print("You lose " + damage + " health and deal " + attack + " damage \n", 20);
                    Print("Press Enter to continue", 20);
                    //subtract from the value that the current player health already is
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //DEFEND
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("As " + n + " prepares to smack it down on you,\n" +
                        "you ready your sharp fork for defense... \n");

                    //the power of the opponent will be divided by 4
                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)//need to make sure the damage does not go negative
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Print("You lose " + damage + " health and deal " + attack + " damage\n", 20);

                    //subtract from the value that the current player health already is
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //RUN                                       //Donkey will be able to run away no matter what
                    if (Program.currentPlayer.currentClass != Player.PlayerClass.Runner && rand.Next(0, 2) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Print("As you dash away from, " + n + " scratches your shoulder and strikes you.\n" + " You fly forward. \n", 20);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.\n");
                        Print("Press Enter to continue", 20);
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You use your ninja like reflexes to evade " + n + " and you sucessfully get away!\n");
                        Print("Press Enter to continue", 20);

                        //go to store
                        Shop.LoadShop(Program.currentPlayer);

                    }

                }
                else if (input.ToLower() == "e" || input.ToLower() == "exit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //HEAL
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;//case for empty
                        Console.WriteLine("Groppin' around desperately, you grasp for a potion.\n" +
                            "Unfortunately you only find used tissues. ");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("" + n + "  smacks your head and you and candy drops see butterflies. \n" +
                            "You lose " + damage + " health! ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You reach into your sack and pull out a neon green tube.\n " +
                            "You guzzle it down..... ");
                        //fighter mod code
                        int potionV = 5 + ((Program.currentPlayer.currentClass == Player.PlayerClass.Fighter) ? +4 : 0);
                        Console.WriteLine("You gain " + potionV + " health");
                        Console.WriteLine("You gain " + potionV + " health");
                        Program.currentPlayer.health += potionV;
                        Program.currentPlayer.potion--;
                        Console.WriteLine("As you were distracted, " + n + " charged forward and struck you! ");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        if (Program.currentPlayer.health >= 0)
                            Console.WriteLine(" You lose " + damage + " health. ");
                        //DEATH CODE
                        if (Program.currentPlayer.health <= 0)
                        {
                            Console.WriteLine(n + " stands proudly over you. \n You've been murdered by the mighty" + n + "\n    GAME  OVER");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                    }

                }
                Console.ReadKey();
            }
           


            int c = rand.Next(10, 50);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAs you stand victorious over "+ n +" there body dissolves into the ground. \nYou collect " + c + " on gold coins\n");
            Program.currentPlayer.coins += c;
            Console.ReadKey();

        }

        //RANDOM ENCOUNTERS
        public static string GetName()
        {

            if (IsChristmas())
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        return "Deranged Elf";
                    case 1:
                        return "Vicious Santa";
                    case 2:
                        return "Frost Snowgolem";
                    case 3:
                        return "Enraged Reindeer";

                }
            }

            switch (rand.Next(0, 10))
            {
                case 0:
                    return "Pinocchio";
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

        public static bool IsChristmas()
        {
            DateTime time = DateTime.Now;//Christmas event time
            if (time.Month == 12 && time.Day >= 20)
                return true;
            return false;
        }
        //arguments go within the parens
        public static void Print(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }//END CLASS


        }//END NAMESPACE

    }
}

