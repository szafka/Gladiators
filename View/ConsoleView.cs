using Gladiator.Model.Gladiators;
using System;
using System.Threading;

namespace Gladiator.View
{
    public class ConsoleView
    {
        static BaseGladiator baseGladiator = new BaseGladiator();
        public static void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Dokumenty\gladiator-csharp-szafka\Names.txt");
            //baseGladiator.Names.AddRange(lines);
            //foreach (var line in lines)
            //{
            //    baseGladiator.Names.Add(line);
            //}
            StartIntro.Intro();
            Thread.Sleep(1000);
            StartIntro.MenuGeneral();
            int intSelected = 0;
            CheckSelectedNumberMenuGeneral();
            switch (intSelected)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;

            }
        }
        public static int CheckSelectedNumberMenuGeneral()
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
                    if (intSelected < 0 || intSelected > 6)
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