using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.View
{
    public class CombatView : IView
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
            Console.ReadKey();
        }
    }
}
