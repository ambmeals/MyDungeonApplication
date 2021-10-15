using DungeonLibrary;
using MyDungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeonApp
{
    public class Encounters
    {   //Create randomizer for attack
        static Random rand = new Random();


        //Encounter Generic


        //Encounters
        //void will not return a variable
        public static void FirstEncounter()
        {
            Console.WriteLine("You can't believe how short all of the furniture is...\n" +
                "You stumble over piles of books while trying to reach your captor.\n" +
                "Luckily, while stumbling, you're able to grab a sharp fork.");
            Console.WriteLine("Lord Farquaad begins to turn around....");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, "Lord Farquaad", 1, 3);
        }

        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("You turn the corner and there you see another figure in your way...\n" +
                "These halls seem never ending like an illusion.");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        //EXTRA ENOUNTERS // NOT RANDOM
        public static void Rumplestiltskin()
        {
            Console.Clear();
            Console.WriteLine("You've found some solitude and safety in a room with wool threading spools.\n" +
                "THey all glitter covered in gold threads.\n" +
                "The door suddenly bursts open with a gust of wind.\n" +
                "You see a short man covered in gold...\n" +
                "He has gold pupils but read whites of his eyes.");
            Console.WriteLine("He claps his hands and suddenly, he is holding two gold knives...\n ");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Rumplestiltskin", 2, 3);
        }

        public static void WaffleMan()
        {
            Console.Clear();
            Console.WriteLine("Your running down the long dark hallway...\n" +
                "Suddenly you run into a room that is filled with flour and maple syrup.\n" +
                " It reeks of alcohol and syrup...like an acholic waffle??");
            Console.WriteLine(" A large....WAFFLE MAN?! Appears before you.\n " +
                "Maybe he had something to do with your syrup bath....");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Waffle Man", 1, 3);
        }

        public static void FairyGodmother()
        {
            Console.Clear();
            Console.WriteLine("Your finding escaping to be difficult.\n" +
                "You try to open a window to maybe jump out of this place...\n" +
                "It doesn't pry open easily and you kick the window out!" +
                "Suddenly, a sound of LOUD buzzing fills your ears");
            Console.WriteLine("Fairy Godmother appears right in your face and smacks your nose with her wand!\n " +
                " Are you going to take that from a bedazzled lady?! ");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Fairy Godmother", 1, 4);
        }

        public static void CaptainHook()
        {
            Console.Clear();
            Console.WriteLine("You turn a corner and feel like you might be getting out of this maze...\n" +
                "You find a door placed at an odd angle..." +
                "You think it could be a reprieve. You see lots of treasure in here...." +
                "To the left of the room is a crocodile giving you side eye??" +
                "A hearty laugh comes from behind you");
            Console.WriteLine("Captain Hook stands behind you, creating a melody with his hook\n" +
                "You can't lie, the tune is a BOP! Too bad it is about your impending doom...");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Captain Hook ", 2, 4);
        }

        public static void JackandJill()
        {
            Console.Clear();
            Console.WriteLine("You're able to fit yourself through a crack in the wall...\n" +
                "It leads you to a room filled with candy covered in....BLOOD?!?\n" +
                "It reeks of a sweet sick situation.\n");
            Console.WriteLine("Two plump figures with terrible haircuts and out of season lederhosen stand before you\n" +
                "You can't tell if they are couple or related...gross...");
            Console.WriteLine();
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Jack and Jill ", 3, 4);
        }

        public static void PuppetMaster()
        {
            Console.Clear();
            Console.WriteLine("You find a charming room that is quiet. There is a stage and rows of empty seats...\n" +
                "The stage is small and you wonder if you have entered a puppet room...");
            Console.WriteLine("Suddenly you are surrounded by tiny puppets hitting your knees");
            Console.WriteLine("At first it's funny, maybe even charming...\n" +
                "Then a puppet pulls out a knife and you know you what you must do!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Puppet Master ", 2, 4);
        }

        public static void Shrek()
        {
            Console.Clear();
            Console.WriteLine("You hear a loud stomping coming from down the hall ");
            Console.WriteLine("It rattles the stones beneath your feet...\n" +
                "You grab the doorhandle next to and hide yourself in what appears to be....Shrek's bedroom??\n" +
                "Finally! Maybe an ally in this stinky place..." +
                "Shrek opens the door and is using a human bone to pluck his teeth!\n" +
                "You think he is there to help but he starts licking his lips as he is looking at you.\n" +
                "Shrek says, 'he hopes you've kept the fork for him to use on you!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Shrek ", 1, 4);
        }

        public static void GingerBreadMan()
        {
            Console.Clear();
            Console.WriteLine("Wow, the room you have stumbled upon smells like Christmas!\n" +
                "You can help but notice most of the furniture is made of candy canes and gum dropes...\n" +
                "You hear a shrill tiny voice come from below your gaze...\n" +
                "You look down and a tiny shrill Ginger Breadman is coming right at you!!!\n" +
                "This no longer feel like comforting Chritmas and suddenly feels like the Christmas of death!\n" +
                "Ginger Breadman pulls out the tiniest shrpest candy can shiv and start right at you...");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadKey();
            Combat(false, " Rumplestiltskin", 2, 3);
        }



        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 9))
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
                    Shrek();
                        break;
                case 8:
                    GingerBreadMan();
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
                    Console.WriteLine("With quick incredible reflexes, you stick your weapon right into your enemy!\n" +
                        "The " + n + " gives you a sock on the back");
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
                    Console.WriteLine("As " + n + " prepares to smack it down on you,\n" +
                        "you ready your shard fork for defense... ");
                    //the power of the opponent will be divided by 4
                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)//need to make sure the damage does not go negative
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    //subtract from the value that the current player health already is
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //RUN
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you dash away from, " + n + " scratches your shoulder and strikes you.\n" + " You fly forward. ");

                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                    }
                    else
                    {
                        Console.WriteLine("You use your ninja like reflxes to evade " + n + " and you sucessfully get away!");
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
                        Console.WriteLine("Groppin' around desperately, you grasp for a potion.\n" +
                            " Unfortunately you only find used tissues. ");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("" + n + "  smacks your head and you and candy drops see butterflies. \n" +
                            "You lose " + damage + " health! ");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your sack and pull out a neon green tube.\n " +
                            "You guzzle it down..... ");
                        int potionV = 5;
                        Console.WriteLine("You gain " + potionV + " health");
                        Console.WriteLine("You gain " + potionV + " health");
                        Program.currentPlayer.health += potionV;
                        Console.WriteLine("As you were distracted, the " + n + " charged forward and struck you! ");
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
                    Console.WriteLine("As " + n + " stands proudly over you, without breaking a sweat they strike you dead. " + n +
                        "\nEasily killed you");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }

            int c = Program.currentPlayer.GetCoins();
            Console.WriteLine("As you stand over your vanquished conquest the " + n + " there body dissovles " + c + " gold coins!");
            //this should add coins to your amount
            Program.currentPlayer.coins += c;
            Console.ReadKey();


        }

        //RANDOM ENCOUNTERS
        public static string GetName()
        {
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

    } //END CLASS
}//END NAMESPACE
