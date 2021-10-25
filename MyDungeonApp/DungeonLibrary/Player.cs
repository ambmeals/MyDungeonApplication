using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDungeon;


namespace MyDungeon
{
    public class Player
    {
        Random rand = new Random();

        public string name;
        public int id;
        public int coins = 300;
        public int level = 1; 
        public int xp = 0;
        public int health = 50;
        public int armorValue = 0;
        public int potion = 5;
        public int weaponValue = 1;

        //making mods buyable at store
        public int mods = 0;

        public enum PlayerClass { Fighter, Defender, Runner};
        public PlayerClass currentClass = PlayerClass.Fighter;


        public int GetHealth()
        {
            int upper = (2 * mods + 7);
            //start of the game user will have lowest possible 
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }

        public int GetPower()
        {
            int upper = (2 * mods + 4);
            //start of the game user will have lowest possible 
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }

        public int GetCoins()
        {
            int upper = (15 * mods + 50);
            //start of the game user will have lowest possible 
            int lower = (10 * mods + 10);
            return rand.Next(lower, upper);
        }

        public int GetXp()
        {   //getting the player xp 
            int upper = (20 * mods + 50);
            int lower = (15 * mods + 10);
            return rand.Next(lower, upper);

        }

        public int GetLevelUpValue()
        {
            return 100 * level + 400;
        }

        public bool CanLevelUp()
        {
            if (xp >= GetLevelUpValue())
                return true;
            else
                return false;
        }

        public void LevelUp()
        {
            while (CanLevelUp())
            {
                xp -= GetLevelUpValue();
                level++;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Congrats! You are now level " + level + " !!!!");
            Console.ResetColor();

        }

    }
}
