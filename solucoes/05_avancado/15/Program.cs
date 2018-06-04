using System;
using System.Collections.Generic;

namespace LP1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            WeaponComparer comparer = new WeaponComparer();
            List<Weapon> wpnList = new List<Weapon>();
            for (int i = 0; i < 4; i++)
            {
                wpnList.Add(new Weapon(random.Next(1, 10), random.Next(1, 10)));
            }
            wpnList.Sort();
            foreach (Weapon weapon in wpnList)
                Console.WriteLine($"A arma tem {weapon.AttackPower} de Poder de Ataque. \n");

            wpnList.Sort(comparer);
            foreach (Weapon weapon in wpnList)
                Console.WriteLine($"A arma tem {weapon.Durability} de Durabilidade. \n");
        }
    }
}
