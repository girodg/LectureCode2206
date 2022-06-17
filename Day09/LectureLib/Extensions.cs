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
    }
}
