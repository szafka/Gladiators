using System;

namespace Gladiator.Model
{
    public class GetRandomGenerator
    {
        private static Random RndGeneratorRange = new Random();

        public static int GetRandom(int leftBound, int rightBound)
        {
            return RndGeneratorRange.Next(leftBound, rightBound);
        }
    }
}
