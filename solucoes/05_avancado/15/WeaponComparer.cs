using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1Exercises
{
    public class WeaponComparer : IComparer<Weapon>
    {
        public int Compare(Weapon x, Weapon y)
        {
            return x.Durability.CompareTo(y.Durability);
        }
    }
}
