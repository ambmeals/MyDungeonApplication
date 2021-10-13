﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeon
{
    public class Player
    {
        Random rand = new Random();

        public string name;
        public int id;
        public int coins = 3000;
        public int health = 10;
        public int armorValue = 0;
        public int potion = 5;
        public int weaponValue = 1;

        public int mods = 0;


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
    }
}
