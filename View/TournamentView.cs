using Gladiator.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.View
{
    public class TournamentView : IView
    {
        public void DisplayMsg(string text)
        {
            Console.WriteLine(text);
        }

        public void NewView()
        {
            Console.Clear();
        }

        public void WaitForAnyInput()
        {
            Console.WriteLine("\nPress any key to continue ...\n");
            Console.ReadKey();
        }
    }
}
