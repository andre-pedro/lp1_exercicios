using System.Collections.Generic;

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
