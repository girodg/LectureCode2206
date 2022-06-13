using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; private set; }
        public int Level { get; private set; }
        public int MaxDamage { get; private set; }
        public int Cost { get; private set; }

        public int DoDamage()
        {
            Random rando = new Random();
            return (int)(MaxDamage * rando.NextDouble());
        }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }
    }
}
