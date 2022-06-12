using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge_Solution
{
    public class Array
    {
        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            if (array.Length == 0) { return 0; }
            if (position1 > position2) { ChangeTwoValues(ref position1, ref position2); }
            if (position1 < 0) { position1 = 0; }
            if (position2 > array.Length) { position2 = array.Length -1; }         

            int maxValue = array[position1];

            for (int i = position1; i < position2; i++)
            {
                if (maxValue < array[i + 1]) { maxValue = array[i + 1]; }
            }

            return maxValue;
            
        }

        public static int FindMinValue(int[] array, int position1, int position2)
        {
            if (array.Length == 0) { return 0; }
            if (position1 > position2) { ChangeTwoValues(ref position1, ref position2); }
            if (position1 < 0) { position1 = 0; }
            if (position2 > array.Length) { position2 = array.Length - 1; }

            int minValue = array[position1];

            for (int i = position1; i < position2; i++)
            {
                if (minValue > array[i + 1]) { minValue = array[i + 1]; }
            }

            return minValue;

        }

        public static void Swap(int[] array, int position1, int position2)
        {
            if (array.Length > 0)
            {
                if (position1 < 0) { position1 = 0; }
                if (position2 > array.Length) { position2 = array.Length - 1; }

                int temp = array[position1];
                array[position1] = array[position2];
                array[position2] = temp;
            }
        }

        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
            if (position1 > position2) { ChangeTwoValues(ref position1, ref position2); }
            if (position1 < 0) { position1 = 0; }
            if (position2 > array.Length) { position2 = array.Length - 1; }

            if (array.Length > 0 && position2 - position1 > 1)
            {
                for (int i = position1; i < position2; i++)
                {
                    _ = array[i + 1] == array[position2] ? (array[i] = 0) : array[i] = array[i + 1];
                                        
                }
            }

        }

        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            var rand = new Random();         

            if (minValue > maxValue) { ChangeTwoValues(ref minValue, ref maxValue); }
            if (size < 0) { size = 0; }

            var solutionArr = new int[size];

            for (int i = 0; i < solutionArr.Length; i++)
            {
                solutionArr[i] = rand.Next(minValue, maxValue);
            }

            return solutionArr;
        }

        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            var rand = new Random();

            if (minValue > maxValue) { ChangeTwoValues(ref minValue, ref maxValue); }
            if (rows < 0) { rows = 0; }
            if (columns < 0) { columns = 0; }

            var solutionArr = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    solutionArr[i,j] = rand.Next(minValue, maxValue);
                }
            }

            return solutionArr;
        }

        public static int[,] CopyArray(int[] array)
        {
            var solutionArr = new int[2, array.Length];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    solutionArr[i, j] = array[j];
                }
            }

            return solutionArr;
        }

        public static int FindInSortedArray(int[] array, int number)
        {
            // Linear search solution
            
            /*                                                      
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number) { return array[i]; }
            }
            return -1;
            */

            // Binary search solution

            var l = 0;
            var h = array.Length;
            var m = array.Length / 2;

            while (array[m] != number)
            {
                if (l == m || h == m) { break; }
                if (array[m] < number)
                {
                    l = m;
                    m = (l + h) / 2;
                }
                else
                {
                    h = m;
                    m = (l + h) / 2;
                }
            }

            return array[m] == number ? m : -1;
            
        }

        public static void ChangeTwoValues(ref int one, ref int two)
        {
            int tmp = one;
            one = two;
            two = tmp;
        }

    }
}
