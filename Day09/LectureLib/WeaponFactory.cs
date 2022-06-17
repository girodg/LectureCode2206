using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public static class WeaponFactory
    {
        public static int WeaponsCreated { get; set; } = 0;

        public static FantasyWeapon MakeWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            WeaponsCreated++;
            return new FantasyWeapon(rarity, level, maxDamage, cost);
        }
    }
}
