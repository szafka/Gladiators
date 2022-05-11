
using System;

namespace Gladiator.View
{
    public interface IView
    {
        void DisplayMsg(string text);
        void NewView()
        {
            Console.Clear();
        }
    }
}