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

        protected WeaponSymbol _symbol;

        public int DoDamage()
        {
            Random rando = new Random();
            return (int)(MaxDamage * rando.NextDouble());
        }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            _symbol = WeaponSymbol.Sword;

            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }

        internal char GetSymbol()
        {
            return (char)_symbol;
        }

        public virtual string Display()
        {
            return $"I have a level {Level} {Rarity} weapon {GetSymbol()} that can do {MaxDamage} damage. And it cost {Cost}.";

        }
        public override string ToString()
        {
            return Display();
        }
    }
}
