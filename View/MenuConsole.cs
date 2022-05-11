using Gladiator.Controller;
using Gladiator.Model;
using Gladiator.Model.Gladiators;
using System;
using System.Threading;

namespace Gladiator.View
{
    public class MenuConsole
    {
        private IView ViewMod;
        public void StartMenu()
        {
            int gladiatorsNumber = 0;
            StartIntro.Intro();
            Thread.Sleep(1000);
            StartIntro.MenuGeneral();
           // GetChosenGladiatorsToStartList(gladiatorsNumber);
            
        }

        public int GetChosenGladiatorsToStartList(int gladiatorsNumber)
        {
            int intSelected = 0;
            int numOfChoises = 1;
            CheckSelectedNumberMenuGeneral(numOfChoises);
            if (intSelected == 0)
            { Environment.Exit(0); }
            else {
                    StartIntro.SelectTypeMenu();
                    numOfChoises = 4;
                    CheckSelectedNumberMenuGeneral(numOfChoises);
            }
            if (intSelected == 0) { Environment.Exit(0); }
            else if (intSelected == 1) { gladiatorsNumber = 2; }
            else if (intSelected == 2) { gladiatorsNumber = 4; } 
            else if (intSelected == 3) { gladiatorsNumber = 8; } 
            else if (intSelected == 4) { gladiatorsNumber = 16; }
            return gladiatorsNumber;
        }

        public int CheckSelectedNumberMenuGeneral(int numOfChoises)
        {
            Boolean validSelection = false;
            int intSelected = 0;
            while (!validSelection)
            {
                string selected = Console.ReadLine().ToUpper();
                var conditionales1 = string.IsNullOrEmpty(selected) || selected.Length != 1 || !Char.IsDigit(selected[0]);
                    if (conditionales1)
                    {
                        Console.Clear();
                        if (numOfChoises == 1) { StartIntro.FirstMenuAfterWrongSelect(); }
                        if (numOfChoises == 4) { StartIntro.SelectTypeMenu(); }
                    }
                    else
                    {
                    intSelected = Int32.Parse(selected);
                    if (intSelected < 0 || intSelected > numOfChoises)
                    {
                        Console.Clear();
                        StartIntro.FirstMenuAfterWrongSelect();
                    }
                    else
                        validSelection = true;
                }
            }
            return intSelected;
        }
    }
}