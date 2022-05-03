using Gladiator.View;
using System.Threading;

namespace Gladiator
{
    public static class Program
    {
        public static void Main()
        {
            // Start the program here
            StartIntro.Intro();
            Thread.Sleep(3000);
            StartIntro.Menu();
            ConsoleView.Run();
        }
    }
}