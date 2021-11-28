using System;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        protected string name;
        protected int weaponry;
        protected int armor;
        protected int maneuvry;
        public Tank(string name)
        {
            this.name = name;
            SetWeaponry();
            SetArmor();
            SetManeuvry();
        }
        protected void SetWeaponry() { this.weaponry = StaticRandom.Random.Next(0, 99); }
        protected void SetArmor() { this.armor = StaticRandom.Random.Next(0, 99); }
        protected void SetManeuvry() { this.maneuvry = StaticRandom.Random.Next(0, 99); }
        public string GetName() => name;
        public int GetWeaponry() => weaponry;
        public int GetArmor() => armor;
        public int GetManeuvry() => maneuvry;
        public static Tank operator *(Tank A, Tank B)
        {
            if (A.GetWeaponry() > B.GetWeaponry())
                if (A.GetArmor() > B.GetArmor() || A.GetManeuvry() > B.GetManeuvry())
                    return A;
                else return B;
            else if (B.GetArmor() > A.GetArmor() || B.GetManeuvry() > A.GetManeuvry())
                return B;
            else return A;
        }
    }
}
