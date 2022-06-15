using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public class BowWeapon : FantasyWeapon
    {
        public BowWeapon(int arrowCount, int arrowCapacity, WeaponRarity rarity, int level, int maxDamage, int cost) : 
            base(rarity, level, maxDamage, cost)
        {
            _symbol = WeaponSymbol.Bow;
            ArrowCount = arrowCount;
            ArrowCapacity = arrowCapacity;
        }
        
        public int ArrowCount { get; private set; }
        public int ArrowCapacity { get; private set; }
    }
}
