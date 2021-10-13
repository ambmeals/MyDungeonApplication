﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeon
{
    public class Shop
    {

        public static void LoadShop(Player p)
        {
            RunShop(p);
        }


        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int difP;
            while (true)

            {
                potionP = 20 + 10 * p.mods;
                armorP = 50 * (p.armorValue + 1);
                weaponP = 75 * p.weaponValue;
                difP = 200 + 100 * p.mods;
                Console.Clear();
                Console.WriteLine("----------SHOP--------");
                Console.WriteLine(" [W]eapon:          $" + weaponP);
                Console.WriteLine(" [A]rmor:           $" + armorP);
                Console.WriteLine(" [P]otions:         $" + potionP);
                Console.WriteLine(" [D]ifficulty Mod:   $" + difP);
                Console.WriteLine("-----------------------");
                Console.WriteLine(" [E]xit Shop");
                Console.WriteLine();
                Console.WriteLine(p.name + "'s Stats");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Current Health: " + p.health);
                Console.WriteLine("Coins:           " + p.coins);
                Console.WriteLine("Weapon Strength: " + p.weaponValue);
                Console.WriteLine("Armor Strength: " + p.armorValue);
                Console.WriteLine("Potions: " + p.potion);
                Console.WriteLine("Weapon Strength: " + p.mods);
                Console.WriteLine("-----------------------");
                //Wait for input
                string input = Console.ReadLine().ToLower();
                if (input == "w" || input == "weapon")
                {
                    TryBuy("weapon", weaponP, p);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorP, p);
                }
                else if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionP, p);
                }
                else if (input == "d" || input == "difficultymod")
                {
                    TryBuy("dif", difP, p);
                }
                
                else if (input == "e" || input == "exit")
                    break;
            }


        }

        static void TryBuy(string item, int cost, Player p)
        {
            //checks to see if they have enough coins
            if (p.coins >= cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "weapon")
                    p.weaponValue++;
                else if (item == "armor")
                    p.armorValue++;
                else if (item == "dif")
                    p.mods++;

                //coins is going to subtract purchasiung cost
                p.coins -= cost;

            }
            else
            {
                Console.WriteLine(" You broke bloke, you need more gold! ");
                Console.ReadKey();
            }
        }


    }//END CLASS
}//END NAMESPACE
