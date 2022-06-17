using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public static class Extensions
    {
        public static string GetSymbol(this WeaponSymbol weapon)
        {
            return $"{(char)weapon}";
        }

        public static List<BowWeapon> Bows(this Inventory inv)
        {
            List<BowWeapon> bows = new List<BowWeapon>();
            foreach (FantasyWeapon item in inv.Items)
            {
                if (item is BowWeapon bow)//downcast
                    bows.Add(bow);
            }
            return bows;
        }
    }
}
