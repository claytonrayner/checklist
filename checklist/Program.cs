using System;

namespace Checklist // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void promptForTaskCompletion(string task)
        {
            Console.WriteLine($"Did you finish your {task}? (y/n)");

            while (Console.ReadLine() != "y")
            {
                Console.WriteLine($"Ok. Did you finish your {task} yet? (y/n)");
            }
        }

        static void Main(string[] args)
        {
            var name = "Clayton";

            Console.WriteLine("Hello master " + name);

            Console.WriteLine("Time to get your tasks done...");

            var tasks = new List<string> { "programming lesson", "writing", "speed painting", "run" };

            foreach(var t in tasks)
            {
                promptForTaskCompletion(t);
            }

            Console.WriteLine("Good for you homie. Clap clap clap.");
        }
    }
}
