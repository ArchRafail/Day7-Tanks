using System;
using MyClassLib;
using MyClassLib.WorldOfTanks;

namespace Day7_Tanks_
{
    class Program
    {
        static string Name(string type)
        {
            string name;
            Console.WriteLine($"Dear user, give a name for tank {type}: ");
            name = Console.ReadLine();
            return name;
        }
        static void Main(string[] args)
        {
            Tank[] t34 = {
                new T34(Name("T34")),
                new T34(Name("T34")),
                new T34(Name("T34")),
                new T34(Name("T34")),
                new T34(Name("T34"))
            };
            Console.WriteLine();
            Tank[] pantera = {
                new Pantera (Name("Pantera")),
                new Pantera (Name("Pantera")),
                new Pantera (Name("Pantera")),
                new Pantera (Name("Pantera")),
                new Pantera (Name("Pantera")),
            };
            Tank winner;
            int count=0;
            Console.WriteLine();
            for (int i = 0; i < t34.Length && i < pantera.Length; i++)
            {
                Console.WriteLine($"Tanks battle. Wave {i+1}");
                Console.WriteLine("On the left side of battle field.");
                Console.WriteLine($"Tank type: T34 \t\t Tank name: {t34[i].GetName()} \t Weapon: {t34[i].GetWeaponry()} \t Armor: {t34[i].GetArmor()} \t Maneuvry: {t34[i].GetManeuvry()}");
                Console.WriteLine("On the right side of battle field.");
                Console.WriteLine($"Tank type: Pantera \t Tank name: {pantera[i].GetName()} \t Weapon: {pantera[i].GetWeaponry()} \t Armor: {pantera[i].GetArmor()} \t Maneuvry: {pantera[i].GetManeuvry()}");
                winner = t34[i] * pantera[i];
                Console.WriteLine($"\nWinner in {i + 1} wave");
                Console.WriteLine($"Tank name: {winner.GetName()} \t Weapon: {winner.GetWeaponry()} \t Armor: {winner.GetArmor()} \t Maneuvry: {winner.GetManeuvry()}");
                count = (winner is T34) ? count++ : count--;
                Console.WriteLine();
            }
            Console.Write("The winner of battle is ");
            Console.WriteLine((count > 0) ? "T34 team." : "Pantera team.");
        }
    }
}
