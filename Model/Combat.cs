﻿using Gladiator.Model.Gladiators;
using Gladiator.View;
using System;

namespace Gladiator.Model
{
    public class Combat
    {
        private IView ViewMod;
        public Combat()
        {
            ViewMod = new CombatView();
        }
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
            int damage;
            bool isStillAlive = true;
            BaseGladiator attacker, defender, winner;
            FirstAttacerMethod(red, blue, out attacker, out defender);

            while (isStillAlive)
            {
                if (HitMoment(attacker, defender) == true)
                {
                    damage = HitDamage(attacker);
                    defender.DecreaseHpBy(damage);
                    DisplayDamageMessage(damage, attacker);
                }
                else
                {
                    DisplayMissMessage(attacker);
                }
                if (defender.IsDead())
                {
                    DisplayDeadMessage(attacker, defender);
                    return attacker;
                }
                else
                {
                    (attacker, defender) = (defender, attacker);

                } 
            }
            winner = attacker;
            return winner;
        }

        private void DisplayDeadMessage(BaseGladiator attacker, BaseGladiator defender)
        {
            ViewMod.DisplayMsg($" {defender.SpeclizationName} {defender.Name} is dead.");
        }

        private void DisplayMissMessage(BaseGladiator attacker)
        {
            ViewMod.DisplayMsg($" {attacker.SpeclizationName} {attacker.Name} missed");
        }

        private void DisplayDamageMessage(int damage, BaseGladiator attacker)
        {
            ViewMod.DisplayMsg($" { attacker.SpeclizationName} {attacker.Name} deals {damage} damage");
        }

        private static void FirstAttacerMethod(BaseGladiator red, BaseGladiator blue, out BaseGladiator attacker, out BaseGladiator defender)
        {
            var randomAttacker = GetRandomGenerator.GetRandom(1, 3);
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
        private int HitDamage(BaseGladiator attacker)
        {
            var damageMultiplier = (double)GetRandomGenerator.GetRandom(1, 6) / 10;
            return (int)(attacker.BaseSP * damageMultiplier);
        }
    }
}