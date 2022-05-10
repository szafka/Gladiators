using Gladiator.Model.Gladiators;
using System;
using System.Collections.Generic;
using System.IO;

namespace Gladiator.Model
{
    public class GladiatorFactory
    {
        public List<BaseGladiator> TournamentGladiators { get; }
        public GladiatorFactory()
        {
            TournamentGladiators = new List<BaseGladiator>();
        }

        public BaseGladiator GenerateRandomGladiator()
        {
            string[] readNames = File.ReadAllLines(@"C:\Dokumenty\gladiator-csharp-szafka\Names.txt");
            int chosenNumber =  Readline();
            bool validCondition = true;
            int numberOfGladiatorsToTournament;
            while (!validCondition)
            {
                if (chosenNumber > 4)
                {
                    Console.WriteLine("C H O S E   C O R R E C T  N U M B E R");
                }
                else if (chosenNumber == 1)
                    numberOfGladiatorsToTournament = 2;
                else if (chosenNumber == 2)
                    numberOfGladiatorsToTournament = 4;

                    for (int i = 0; i < numberOfGladiatorsToTournament; i++)
                    {
                    string name = readNames[GetRandomGenerator.GetRandom(0, readNames.Length)];
                    int rndSpecialization = GetRandomGenerator.GetRandom(1, 6);
                    int baseHP = GetRandomGenerator.GetRandom(25, 101);
                    int baseSP = GetRandomGenerator.GetRandom(25, 101);
                    int baseDEX = GetRandomGenerator.GetRandom(25, 101);
                    int level = GetRandomGenerator.GetRandom(1, 6);
                    switch (rndSpecialization)
                    {
                        case 1:
                            TournamentGladiators.Add(new Archer(name, level, baseHP, baseSP, baseDEX));
                            return new Archer(name, level, baseHP, baseSP, baseDEX);
                        case 2:
                            TournamentGladiators.Add(new Assassin(name, level, baseHP, baseSP, baseDEX));
                            return new Assassin(name, level, baseHP, baseSP, baseDEX);
                        case 3:
                            TournamentGladiators.Add(new Brutal(name, level, baseHP, baseSP, baseDEX));
                            return new Brutal(name, level, baseHP, baseSP, baseDEX);
                        case 4:
                        case 5:
                            TournamentGladiators.Add(new Swordsman(name, level, baseHP, baseSP, baseDEX));
                            return new Swordsman(name, level, baseHP, baseSP, baseDEX);
                    }
                    validCondition = true;
                }
            }
            return null;

        }

        public static int Readline()
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
