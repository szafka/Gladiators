using Gladiator.Model.Gladiators;
using System;
using System.Threading;

namespace Gladiator.View
{
    public class ConsoleView : IView
    {
        public void writeLine(string text)
        {
            Console.WriteLine(text);
        }
        public static void Run()
        {
            StartIntro.Intro();
            Thread.Sleep(1000);
            StartIntro.MenuGeneral();
            int intSelected = 0;
            int numOfChoises = 1;
            CheckSelectedNumberMenuGeneral(numOfChoises);
            switch (intSelected)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("S E L E C T   N U M B E R   O F   G L A D I A T O R S :" +
                        "1 : 2   G L A D I A T O R S" +
                        "2 : 4   G L A D I A T O R S" +
                        "3 : 8   G L A D I A T O R S" +
                        "4 : 16  G L A D I A T O R S");
                        numOfChoises = 4;
                    CheckSelectedNumberMenuGeneral(numOfChoises);
                    break;
            }
        }
        public static int CheckSelectedNumberMenuGeneral(int numOfChoises)
        {
            Boolean validSelection = false;
            int intSelected = 0;
            while (!validSelection)
            {
                string selected = Console.ReadLine().ToUpper();
                    if (string.IsNullOrEmpty(selected) || selected.Length != 1 || !Char.IsDigit(selected[0]))
                    {
                        Console.Clear();
                        StartIntro.FirstMenuAfterWrongSelect();
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