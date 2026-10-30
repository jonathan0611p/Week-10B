
using System;

namespace Sharksweeper
{
    public class Greeting
    {
        public string Name { get; set; } = "runner";

        public string BuildMessage()
        {
            return $"Welcome to Shark Sweeper, {Name}! 🌊";
        }
    }
}
