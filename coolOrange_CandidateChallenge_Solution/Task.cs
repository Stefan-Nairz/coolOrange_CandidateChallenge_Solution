using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge_Solution
{
    public class Task : IComparable, IComplexity, IPriority
    {
        
        private string name;
        private int priority;
        private int complexity;

        public Task(string name)
        {
            this.name = name;
            this.priority = IPriority.MED_PRIORITY;
            this.complexity = 0;
        }
        
        public Task()
        {

        }

        public Task CompareTo(Task task)
        {
            return this.priority < task.priority ? task : this;
        }

        public int GetComplexity()
        {
            return complexity;
        }

        public int GetPriority()
        {
            return priority;
        }

        public string GetName()
        {
            return name;
        }

        public void SetComplexity(int value)
        {
            complexity = value;
        }

        public void SetPriority(int value)
        {
            priority = value;
        }

        public void SetName(string value)
        {
            name = value;
        }

    }
}
