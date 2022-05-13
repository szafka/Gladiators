using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gladiator.View
{
    public class StartIntro
    {
        StartIntro()
        {
        }
        public static int GetChosenFromMenu()
        {
            string selected = Console.ReadLine();
            int intSelected = 0;
            int tournamentSize = 0;
            Boolean validSelection = false;
            while (!validSelection)
            {
                var conditionales1 = string.IsNullOrEmpty(selected) || selected.Length != 1 || !Char.IsDigit(selected[0]);
                if (conditionales1)
                {
                    Console.Clear();
                    StartIntro.FirstMenuAfterWrongSelect();
                }
                else
                {
                    intSelected = Int32.Parse(selected);
                    if (intSelected < 0 || intSelected > 4)
                    {
                        Console.Clear();
                        StartIntro.FirstMenuAfterWrongSelect();
                    }
                    else if (intSelected == 0) { Environment.Exit(0); }
                    if (intSelected == 0) { Environment.Exit(0); }
                    else if (intSelected == 1) { tournamentSize = 2; }
                    else if (intSelected == 2) { tournamentSize = 4; }
                    else if (intSelected == 3) { tournamentSize = 8; }
                    else if (intSelected == 4) { tournamentSize = 16; }
                }
                validSelection = true;
            }
            return tournamentSize;
        }
        public static void Intro()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("                               W E L C O M E      ");
            
            Thread.Sleep(1000);
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("                                   T O      ");
            
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("                         N E W    T O U R N A M E N T  ");

            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("                    * *  ***   ***   ****   ***   ***  * *");
            Console.WriteLine("                    *                                    *");
            Console.WriteLine("                     *                                  * ");
            Console.WriteLine("                    *    G  L  A  D  I  A  T  O  R  S    *");
            Console.WriteLine("                     *                                  * ");
            Console.WriteLine("                    *                                    *");
            Console.WriteLine("                    **   ***   ***   ****   ***   ***   **");
            Thread.Sleep(1500);
            Console.Clear();
        }
        public static void SelectTypeMenu()
        {
            string selectNumber;
            Console.Clear();
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Thread.Sleep(500);
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  2  G L A D I A T O R S   T O U R N A M E N T        :   S E L E C T   1    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------"); Thread.Sleep(500);
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  4  G L A D I A T O R S   T O U R N A M E N T        :   S E L E C T   2    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------"); Thread.Sleep(500);
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  8  G L A D I A T O R S   T O U R N A M E N T        :   S E L E C T   3    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------"); Thread.Sleep(500);
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  16  G L A D I A T O R S   T O U R N A M E N T       :   S E L E C T   4    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------"); Thread.Sleep(500);
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  E X I T                                             :   S E L E C T   0    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t");
            Console.WriteLine("     S E L E C T   N U M B E R  :");
        }
        public static void FirstMenuAfterWrongSelect()
        {
            Console.Clear();
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  2  G L A D I A T O R S   T O U R N A M E N T        :   S E L E C T   1    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  4  G L A D I A T O R S   T O U R N A M E N T        :   S E L E C T   2    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  8  G L A D I A T O R S   T O U R N A M E N T        :   S E L E C T   3    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  16  G L A D I A T O R S   T O U R N A M E N T       :   S E L E C T   4    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  E X I T                                             :   S E L E C T   0    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t");
            Console.WriteLine("     S E L E C T   N U M B E R  :");
            GetChosenFromMenu();
        }
    }
}
