using Gladiator.Model;
using Gladiator.Model.Gladiators;
using Gladiator.View;
using System;
using System.Collections.Generic;

namespace Gladiator.Controller
{
    public class Tournament
    {
        private IView ViewMod;
        public static List<BaseGladiator> TournamentGladiators { get; set;  }
        public Tournament()
        {
        TournamentGladiators = new List<BaseGladiator>();
            GenerateGladiators(GladiatorFactory );
        }
        public void GetWinner(GladiatorFactory gladiatorFactory)
        {
        }
        internal void GenerateGladiators(GladiatorFactory gladiatorFactory)
        {
            int gladiatorsNumber = 2;
            for (int i = 0; i == gladiatorsNumber; i++)
            {
                TournamentGladiators.Add(gladiatorFactory.GenerateRandomGladiator());
            }
        }
    }
}