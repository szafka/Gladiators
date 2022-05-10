﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gladiator.View
{
    public class StartIntro
    {
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
        public static void MenuGeneral()
        {
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(500);
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  S T A R T   N E W   T U R N A M E N T               :   S E L E C T   1    A N D   P R E S S   E N T E R   |");
            Thread.Sleep(500);
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  E X I T                                             :   S E L E C T   0    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t");
            Console.WriteLine("     S E L E C T   N U M B E R  :");
        }
        public static void FirstMenuAfterWrongSelect()
        {
            Console.WriteLine("     S E L E C T   N U M B E R  :");
            Console.WriteLine("\t");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  S T A R T   N E W   T U R N A M E N T               :   S E L E C T   1    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("    |  E X I T                                             :   S E L E C T   0    A N D   P R E S S   E N T E R   |");
            Console.WriteLine("    |                                                                                                             |");
            Console.WriteLine("     -------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t");
        }
    }
}
