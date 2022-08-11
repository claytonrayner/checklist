using System;

namespace Checklist // Note: actual namespace depends on the project name.
{

    internal class Program
    {

        private static void promptForTaskCompletion(TodoTask task)
        {
            var timeStr = task.count == 1 ? "time" : "times";
            Console.WriteLine($"Did you finish your {task.name}? You were supposed to do it {task.count} {timeStr} (y/n)");

            if (task.previousTask != null)
            {
                Console.WriteLine($"Remember, you were supposed to do this AFTER {task.previousTask.name}");
            }

            while (Console.ReadLine() != "y")
            {
                Console.WriteLine($"Ok. Did you finish your {task.name} yet? (y/n)");
            }
        }

        static void Main(string[] args)
        {
            var name = "Clayton";

            Console.WriteLine("Hello master " + name);

            Console.WriteLine("Time to get your tasks done...");

            var writingTask = new TodoTask
            {
                name = "writing",
                count = 1
            };

            var tasks = new List<TodoTask> {
                new TodoTask
                {
                    name = "programming lesson",
                    count = 1
                },
                writingTask,
                new TodoTask
                {
                    name = "speed painting",
                    count = 1,
                    previousTask = writingTask
                },
                new TodoTask
                {
                    name = "drink water",
                    count = 8
                },
            };

            foreach (var t in tasks)
            {
                promptForTaskCompletion(t);
            }

            Console.WriteLine("Good for you homie. Clap clap clap.");
        }
    }

    internal class TodoTask
    {
        internal string name;
        internal int count = 1;
        internal TodoTask previousTask;
    }
}
