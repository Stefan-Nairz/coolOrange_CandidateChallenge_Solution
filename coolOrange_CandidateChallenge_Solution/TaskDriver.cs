using System;

namespace coolOrange_CandidateChallenge_Solution
{
    class TaskDriver : Task
    {
        static void Main(string[] args)
        {
            Task doingHomework = new Task("Doing Homework");
            doingHomework.SetPriority(10);
            doingHomework.SetComplexity(8);

            Task eatingLunch = new Task("Eating Lunch");
            eatingLunch.SetPriority(1);
            eatingLunch.SetComplexity(2);

            Task programming = new Task("Programming");
            programming.SetPriority(5);
            programming.SetComplexity(5);

            Task[] tasks = new Task[] { doingHomework, eatingLunch, programming };

            Task highestTask = tasks[0];

            for (int i = 0; i < tasks.Length; i++)
            {
                highestTask = highestTask.CompareTo(tasks[i]);
            }

            Console.WriteLine("TO-DO\n_________\n");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.GetName(), -15} priority: {task.GetPriority(), -3} complexity: {task.GetComplexity()}");
            }
            Console.WriteLine($"\n{highestTask.GetName()} is one of the most important tasks");
            
        }

    }
}
