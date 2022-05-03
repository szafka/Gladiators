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
        }
        public static void Menu()
        {
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("  " + "S H O W    A L L   G L A D I A T O R S              :   S E L E C T   1    A N D   P R E S S   E N T E R");
            Thread.Sleep(500);
            Console.WriteLine("\t");
            Console.WriteLine("  " + "S H O W    A L L   S P E C I A L I T I S            :   S E L E C T   2    A N D   P R E S S   E N T E R");
            Thread.Sleep(500);
            Console.WriteLine("\t");
            Console.WriteLine("  " + "A D D    R A N D O M   1 6   G L A D I A T O R S    :   S E L E C T   3    A N D   P R E S S   E N T E R");
            Thread.Sleep(500);
            Console.WriteLine("\t");
            Console.WriteLine("  " + "S H O W   A D D E D   G L A D I A T O R S           :   S E L E C T   4    A N D   P R E S S   E N T E R");
            Thread.Sleep(500);
            Console.WriteLine("\t");
            Console.WriteLine("  " + "S T A R T   N E W   T U R N A M E N T               :   S E L E C T   6    A N D   P R E S S   E N T E R");
            Thread.Sleep(500);
            Console.WriteLine("\t");
            Console.WriteLine("  " + "E X I T                                             :   S E L E C T   7    A N D   P R E S S   E N T E R");
        }
    }
}
