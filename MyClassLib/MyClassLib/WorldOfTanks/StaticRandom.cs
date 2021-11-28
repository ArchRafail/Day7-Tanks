using System;

namespace MyClassLib.WorldOfTanks
{
    static class StaticRandom
    {
        public static Random Random { get; } = new Random();
        static StaticRandom() { }
    }
}
