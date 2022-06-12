using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge_Solution
{
    interface IPriority
    {
        public const int MIN_PRIORITY = 1;
        public const int MED_PRIORITY = 5;
        public const int MAX_PRIORITY = 10;
        void SetPriority(int value);
        int GetPriority();
    }
}
