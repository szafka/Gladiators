using Gladiator.Model.Gladiators;
using System;

namespace Gladiator.Model
{
    public class Combat
    {
        public BaseGladiator Simulate(BaseGladiator red, BaseGladiator blue)
        {
            if (red == null && blue != null)
            {
                return blue;
            }
            if (red != null && blue == null)
            { 
                return red;
            }
            if (red == null && blue == null)
            {
                return null;
            }

            var randomAttacker = GetRandomGenerator.GetRandom(1,3);
            BaseGladiator attacker;
            BaseGladiator defender;
            if (randomAttacker == 1)
            {
                attacker = red;
                defender = blue;
            }
            else 
            { 
                attacker = blue;
                defender = red;
            }
            HitMoment(attacker, defender);
            return null;
        }
        private bool HitMoment(BaseGladiator attacker, BaseGladiator deffender)
        {
            int leftBound = 1;
            int rightBound = 100;
            int leftRange = 10;
            int rightRange = 100;
            int differenceDEX = attacker.BaseDEX - deffender.BaseDEX;
            int moduloDiff;
            int drawHitPoint = GetRandomGenerator.GetRandom(leftBound, rightBound + 1);

            if (differenceDEX <= leftRange)
            {
                moduloDiff = leftRange;
            }
            else if (differenceDEX >= rightRange)
            {
                moduloDiff = rightRange;
            }
            else moduloDiff = differenceDEX;
            
            if (moduloDiff <= drawHitPoint)
            {
                return true;
            }
            else return false;
        }
        private double HitDamage(BaseGladiator attacker, BaseGladiator defender)
        {
            var damageMultiplier = (double)GetRandomGenerator.GetRandom(1, 6) / 10;
            return (int)(attacker.BaseSP * damageMultiplier);
        }
    }
}