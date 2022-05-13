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

            int j = 0;
            foreach (var gladiator in gladiators)
            {
                j++;
                ViewMod.DisplayMsg($"{j}: {gladiator.SpeclizationName} {gladiator.Name} {gladiator.Level}");
            }
            while (gladiators.Count > 1)
            {
                for (int i = 0; i < tournamentSize / 2; i++)
                {
                    BaseGladiator red = gladiators[0];
                    BaseGladiator blue = gladiators[1];
                    string redName = red.SpeclizationName + " " + red.Name + " " + red.BaseHP;
                    string blueName = blue.SpeclizationName + " " + blue.Name + " " + blue.BaseHP;
                    ViewMod.DisplayMsg("* * * * * * * * * * * * * *");
                    ViewMod.DisplayMsg(i + 1 + " " + redName + " vs " + blueName);
                    ViewMod.DisplayMsg("* * * * * * * * * * * *");
                    BaseGladiator winner = new Combat().Simulate(red, blue);
                    ViewMod.DisplayMsg("--------------------------------------");
                    ViewMod.DisplayMsg(winner.SpeclizationName + " " + winner.Name);
                    ViewMod.DisplayMsg("======================================");
                    winner.HealUp();
                    winner.LevelUp();
                    tourWinners.Add(winner);
                    gladiators.Remove(red);
                    gladiators.Remove(blue);
                }
                tournamentSize = tournamentSize / 2;
                gladiators = tourWinners;
                foreach (var gladiator in gladiators)
                {
                    j++;
                    Console.WriteLine(j + ": " + gladiator.SpeclizationName + " " + gladiator.Name + " " + gladiator.Level);
                }
            }
            ViewMod.DisplayMsg($"Winner of the [{tournamentSizeToDisplay}] Gladiators Tournament is: ** {gladiators[0].SpeclizationName} {gladiators[0].Name} **");
        }
    }
}