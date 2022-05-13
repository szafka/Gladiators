using Gladiator.Controller;
using Gladiator.Model.Gladiators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gladiator.Model
{
    public class GladiatorFactory
    {
        string[] readNames;
        public GladiatorFactory()
        {
            readNames = File.ReadAllLines(@"C:\Dokumenty\gladiator-csharp-szafka\Names.txt");

        }

        public BaseGladiator GenerateRandomGladiator()
        {
                readNames = readNames.OrderBy(x => GetRandomGenerator.ShuffleArrayList()).ToArray();
                string name = readNames[0];
                readNames = readNames.Where(x => x != readNames[0]).ToArray();
                string specName;
                int rndSpecialization = GetRandomGenerator.GetRandom(1, 6);
                int baseHP = GetRandomGenerator.GetRandom(25, 101);
                int baseSP = GetRandomGenerator.GetRandom(25, 101);
                int baseDEX = GetRandomGenerator.GetRandom(25, 101);
                int level = GetRandomGenerator.GetRandom(1, 6);
                switch (rndSpecialization)
                {
                    case 1:
                    specName = "Archer";
                        return new Archer(specName, name, level, baseHP, baseSP, baseDEX);
                    case 2:
                    specName = "Assassin";
                        return new Assassin(specName, name, level, baseHP, baseSP, baseDEX);
                    case 3:
                    specName = "Brutal";
                        return new Brutal(specName, name, level, baseHP, baseSP, baseDEX);
                    case 4:
                    case 5:
                    specName = "Brutal";
                        return new Swordsman(specName, name, level, baseHP, baseSP, baseDEX);
                }
            return null;
        }
        public static int ReadChosenNumber()
        {
            int number;
            string chosenValue = Console.ReadLine();
            var firstCondition = string.IsNullOrEmpty(chosenValue) && Char.IsDigit(chosenValue[0]) && chosenValue.Length == 1 && int.Parse(chosenValue) >= 0;
            bool validCondition = true;
            while (!validCondition)
            {
                if (!firstCondition)
                {
                    Console.WriteLine("C H O S E   C O R R E C T  N U M B E R");
                }
                else validCondition = true;
            }
            number = int.Parse(chosenValue);
            return number;
        }
    }
}
