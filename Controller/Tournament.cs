using Gladiator.Model;
using Gladiator.Model.Gladiators;
using Gladiator.View;
using System;
using System.Collections.Generic;
using System.IO;

namespace Gladiator.Controller
{
    public class Tournament
    {
        private IView ViewMod;
        public List<BaseGladiator> TournamentGladiators { get; set;  }
        public List<BaseGladiator> WinnersOfTour { get; set; }
        public List<BaseGladiator> SelectedNumbersOfGladiators { get; set; }
        public Tournament()
        {
            TournamentGladiators = new List<BaseGladiator>();
            SelectedNumbersOfGladiators = new List<BaseGladiator>();
            WinnersOfTour = new List<BaseGladiator>();
            GenerateGladiators(new GladiatorFactory());
            ViewMod = new TournamentView();
        }
        public void GetWinner(GladiatorFactory gladiatorFactory)
        {
        }
        internal void GenerateGladiators(GladiatorFactory gladiatorFactory)
        {
            string[] readNames = File.ReadAllLines(@"C:\Dokumenty\gladiator-csharp-szafka\Names.txt");
            int gladiatorsNumber = readNames.Length;
            for (int i = 0; i <= gladiatorsNumber--; i++)
            {
                TournamentGladiators.Add(gladiatorFactory.GenerateRandomGladiator());
            }
        }
        public void StartTournamentEngine()
        {
            int tournamentSize = StartIntro.GetChosenFromMenu();
            var testTournament = new Tournament();
            int tournamentSizeToDisplay = tournamentSize;
            var gladiators = testTournament.TournamentGladiators.GetRange(0, tournamentSize);
            var tourWinners = testTournament.WinnersOfTour;
            int z = 0;
            int j = 0;
            ViewMod.NewView();
            foreach (var gladiator in gladiators)
            {
                j++;
                ViewMod.DisplayMsg($" {j}:  ** {gladiator.SpeclizationName} {gladiator.Name} {gladiator.Level} **");
            }
            ViewMod.WaitForAnyInput();
            while (gladiators.Count > 1)
            {
                z++;
                for (int i = 0; i < tournamentSize / 2; i++)
                {
                    BaseGladiator red = gladiators[0];
                    BaseGladiator blue = gladiators[1];
                    DisplayPairsBeforeFight(i, red, blue);
                    BaseGladiator winner = new Combat().Simulate(red, blue);
                    DisplayPairWinner(z, i, winner);
                    MoveGladiatrosAfterFight(gladiators, tourWinners, red, blue, winner);
                    ViewMod.WaitForAnyInput();
                }
                tournamentSize = tournamentSize / 2;
                gladiators = tourWinners;
                if (tournamentSize > 1)
                {
                NewMethod(gladiators, j);
                }
                else DisplayTournamentWinner(tournamentSizeToDisplay, gladiators);
            }
        }

        private static int NewMethod(List<BaseGladiator> gladiators, int j)
        {
            j = 0;
            foreach (var gladiator in gladiators)
            {
                j++;
                Console.WriteLine($"{j}: { gladiator.SpeclizationName} { gladiator.Name}, level: { gladiator.Level}");
            }

            return j;
        }

        private void DisplayPairsBeforeFight(int i, BaseGladiator red, BaseGladiator blue)
        {
            string redName = $"{red.SpeclizationName} {red.Name}, HP: {red.BaseHP}";
            string blueName = $"{blue.SpeclizationName} {blue.Name}, HP: {blue.BaseHP}";
            ViewMod.DisplayMsg("* * * * * * * * * * * * * *");
            ViewMod.DisplayMsg($" {i+1} { redName} vs { blueName}");
            ViewMod.DisplayMsg(" * * * * * * * * * * * * * *");
        }

        private static void MoveGladiatrosAfterFight(List<BaseGladiator> gladiators, List<BaseGladiator> tourWinners, BaseGladiator red, BaseGladiator blue, BaseGladiator winner)
        {
            winner.HealUp();
            winner.LevelUp();
            tourWinners.Add(winner);
            gladiators.Remove(red);
            gladiators.Remove(blue);
        }

        private void DisplayPairWinner(int z, int i, BaseGladiator winner)
        {
            ViewMod.DisplayMsg("--------------------------------------");
            ViewMod.DisplayMsg($" Winner {i + 1} pair of {z} stage: {winner.SpeclizationName} {winner.Name}");
            ViewMod.DisplayMsg("======================================");
        }
        private void DisplayTournamentWinner(int tournamentSizeToDisplay, List<BaseGladiator> gladiators)
        {
            ViewMod.DisplayMsg($"Winner of the [{tournamentSizeToDisplay}] Gladiators Tournament is: ** {gladiators[0].SpeclizationName} {gladiators[0].Name} **");
            ViewMod.WaitForAnyInput();
        }
    }
}