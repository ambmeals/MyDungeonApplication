using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeon
{
    public class Encounter
    {   //Create randomizer for attack
        static Random rand = new Random();


        //Encounter Generic


        //Encounters
        //void will not return a variable
        public static void FirstEncounter()
        {
            Console.WriteLine("You stumble over piles of books while trying to reach your captor.\n" +
                "Luckily, while stumbling, you grab a rusty fork.");
            Console.WriteLine("The Zombie Cyborg turns around....");
            Console.ReadKey();
            Combat(false, "Zombie Cyborg", 1, 4);
        }

        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine(" You turn the corner and there you see a grim shadow...\n");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        //EXTRA ENOUNTERS
        public static void WizardEnocunter()
        {
            Console.Clear();
            Console.WriteLine(" The door suddenly bursts open with a gust of wind.\n" +
                " You see a tall man in crazy ugly wrags...\n");
            Console.WriteLine(" He licks his lips as he looks at you like you're dinner.\n ");
            Console.ReadKey();
            Combat(false, " Cannibal Wizard, enjoys eating a brain or two ", 4, 2);
        }

        public static void PowerfulVampire()
        {
            Console.Clear();
            Console.WriteLine(" You peer down the long dark hallway...\n" +
                " It reeks of alcohol and cheetos ");
            Console.WriteLine(" A large sparkley vampire appears before you.\n ");
            Console.ReadKey();
            Combat(false, " Powerful Vampire, really enjoys drunk humans ", 6, 3);
        }



        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 2))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    WizardEnocunter();
                    break;
                case 2:
                    PowerfulVampire();
                    break;
            }
        }

        //bool will ask if the combat is a radnom creature or specilized
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
                    Console.WriteLine(" With ninja like reflexes, you stick your weapon right in their eye!\n" +
                        "The " + n + " bites your ankle ");
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
                    Console.WriteLine(" As the " + n + " prepares to smack it down on you,\n" +
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
                        Console.WriteLine(" As you dash away from, " + n + " it scratches your shoulder and strikes you.\n+" +
                            " You fly forward. ");
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
                        Console.WriteLine(" The " + n + "  smacks your head into see butterflies. You lose " + damage + " health! ");
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
                    Console.WriteLine(" As the" + n + " stands proudly over you, they easily strike you dead. " + n +
                        "/nEasily killed you");
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
                    return "Skeleton";
                case 1:
                    return "Flesh Eating Zombie";
                case 2:
                    return "Greater Mutant";
                case 3:
                    return "Ghoul";
                case 4:
                    return "Nightwraith";
                case 5:
                    return "Drowner";
                case 6:
                    return "Werewolf";
                case 7:
                    return "Pixie";
                case 8:
                    return "Siren";
                case 9:
                    return "Griffin";
                case 10:
                    return "Succubus";
            }
            return "Cyborg";
        }

    } //END CLASS
}//END NAMESPACE
