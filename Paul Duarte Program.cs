
using System;

namespace HelloInvestigation
{
    internal static class Program
    {
        private static void Main()
        {
            Greeting greeting = new Greeting();

            greeting.Name = "Ari";

            Console.WriteLine(greeting.BuildMessage());

            Console.WriteLine();
            Console.WriteLine("Welcome to SHARK SWEEPER!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("🐠 Find peaceful fish!");
            Console.WriteLine("🦈 Avoid the sharks!");
            Console.WriteLine("🚩 Place buoys to mark sharks!");
            Console.WriteLine();
            Console.WriteLine("Good luck exploring!");
        }
    }
}
