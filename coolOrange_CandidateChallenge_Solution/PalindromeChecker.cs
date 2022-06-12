using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge_Solution
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            // My first solution

            /*
            var charArr = new char[s.Length];
            var p = 0;

            for (int i = 0; i < s.Length; i++)
            {
                charArr[i] = s[i];
            }

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == charArr[charArr.Length -(i+1)]) { p = p+1; }
            }

            return p == s.Length ? true : false;
            */

            // Solution with a recursive algorithm 

            if (s.Length == 0 || s.Length == 1) { return true; }
            if (s.Length == 2 && s[0] == s[1]) { return true; }

            if (s[0] == s[s.Length-1]) { return IsPalindrome(s.Substring(1, s.Length - 2)); }
            else { return false; }

        }
    }
}
