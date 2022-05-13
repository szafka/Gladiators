using Gladiator.Controller;
using Gladiator.Model;
using Gladiator.Model.Gladiators;
using System;
using System.IO;
using System.Threading;
using System.Linq;

namespace Gladiator.View
{
    public class MenuConsole
    {
        public static void StartMenu()
        {
            StartIntro.Intro();
            Thread.Sleep(1000);
            StartIntro.SelectTypeMenu();
            new Tournament().StartTournamentEngine();
        }
    }
}