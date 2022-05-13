using System;

namespace Gladiator.Model
{
    public class GetRandomGenerator
    {
        private static Random RndGeneratorRange = new Random();
        private static Random RndShuffleArray = new Random();

        public static int GetRandom(int leftBound, int rightBound)
        {
            return RndGeneratorRange.Next(leftBound, rightBound);
        }
        public static int ShuffleArrayList()
        {
            return RndShuffleArray.Next();
        }
    }
}
