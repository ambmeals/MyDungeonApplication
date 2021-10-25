using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeonApp
{
    public class Weapon
    {
        static Random rand = new Random();

        //field
        private int _minDamage;

        //prop
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 00 && value <= MaxDamage)
                { //minDamage cannot be more than maxDamage && cannot be less than 1
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }//endELSE
            }//endSET
        }//endPROPERTY


        public Weapon(int maxDamage, string name, int bonusHitChance, bool isTwoHanded, int minDamage)
        {
            //the order in which you do the assigments below doesn't matter UNLESS
            //you have a biz rule that compares one property to another (minDamage)
            //you have to assign a value to the prop used in the comparison (maxDamage) FIRST
            //so you are not comparing a null value

            //maxDamage is used as a comparison for minDamage, MUST have a value before minDamage
            //MinDamage = minDamage MaxDamage = maxDamage WRONG WRONG WRONG!!!!
            //ORDER MATTERS WHEN YOU COMPARE

            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            MinDamage = minDamage;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"{Name}\t{MinDamage} to {MaxDamage}" +
                $"\nBonus Hit: {BonusHitChance}%\n" +
                $"Is Two Handed? {(IsTwoHanded ? "yes" : "no")}");
        }
    }
}
