using System;
using NUnit.Framework;

namespace codewars_solutions
{
    public class MarineDecorator : ISolutionRunner
    {
        public MarineDecorator()
        {
        }

        public void Run()
        {
            IMarine marine = new Marines(10, 1);

            Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
            Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
        }
    }


    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marines : IMarine
    {
        public Marines(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarineWeaponUpgrade : IMarine
    {
        private IMarine _marine;

        public MarineWeaponUpgrade(IMarine marine)
        {
            _marine = new Marines(marine.Damage, marine.Armor);
        }

        public int Damage { get { return ++_marine.Damage; } set { } }

        public int Armor { get; set; }
    }

    public class MarineArmorUpgrade : IMarine
    {
        private IMarine _marine;

        public MarineArmorUpgrade(IMarine marine)
        {
            _marine = new Marines(marine.Damage, marine.Armor);
        }

        public int Damage { get; set; }

        public int Armor { get { return ++_marine.Armor; } set { } }
    }
}
