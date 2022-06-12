using coolOrange_CandidateChallenge_Solution;
using NUnit.Framework;

namespace coolOrange_CandidateChallenge_Tests
{
    [TestFixture]
    public class ArrayTests
    {        
        [Test]
        public void FindMaxValueTest()
        {
            Assert.AreEqual(50, Array.FindMaxValue(new int[] { 10, 20, 30, 40, 50 }, 0, 4));    
            Assert.AreEqual(1, Array.FindMaxValue(new int[] { 1, 1, 1, 1, 1 }, 0, 4));          
            Assert.AreEqual(3, Array.FindMaxValue(new int[] { 3, 4, 5, 2, 1 }, 0, 0));          
            Assert.AreEqual(100, Array.FindMaxValue(new int[] { 10, 20, 100, 40, 50 }, 1, 4));  
            Assert.AreEqual(0, Array.FindMaxValue(new int[] {  }, 1, 4));                       
            Assert.AreEqual(50, Array.FindMaxValue(new int[] { 10, 20, 100, 40, 50 }, 4, 3));   
            Assert.AreEqual(100, Array.FindMaxValue(new int[] { 10, 20, 100, 40, 50 }, -3, 6)); 
        }

        [Test]
        public void FindMinValueTest()
        {
            Assert.AreEqual(10, Array.FindMinValue(new int[] { 10, 20, 30, 40, 50 }, 0, 4));    
            Assert.AreEqual(1, Array.FindMinValue(new int[] { 1, 1, 1, 1, 1 }, 0, 4));          
            Assert.AreEqual(3, Array.FindMinValue(new int[] { 3, 4, 5, 2, 1 }, 0, 0));          
            Assert.AreEqual(20, Array.FindMinValue(new int[] { 10, 20, 100, 40, 50 }, 1, 4));   
            Assert.AreEqual(0, Array.FindMinValue(new int[] { }, 1, 4));                        
            Assert.AreEqual(40, Array.FindMinValue(new int[] { 10, 20, 100, 40, 50 }, 4, 3));   
            Assert.AreEqual(10, Array.FindMinValue(new int[] { 10, 20, 100, 40, 50 }, -3, 6));  
        }

        [Test]
        public void SwapTest()
        {
            int[] arrTest1 = new int[] { 1, 2, 3, 4 };
            Array.Swap(arrTest1, 0, 3);
            Assert.AreEqual(new int[] { 4, 2, 3, 1 }, arrTest1);

            int[] arrTest2 = new int[] { };
            Array.Swap(arrTest2, 0, 3);
            Assert.AreEqual(new int[] { }, arrTest2);

            int[] arrTest3 = new int[] { 1, 2, 3, 4 };
            Array.Swap(arrTest3, -20, 20);
            Assert.AreEqual(new int[] { 4, 2, 3, 1 }, arrTest3);

            int[] arrTest4 = new int[] { 1, 2, 3, 4 };
            Array.Swap(arrTest4, 0, 0);
            Assert.AreEqual(new int[] { 1, 2, 3, 4 }, arrTest4);
        }

        [Test]
        public void ShiftLeftByOneTest()
        {
            int[] arrTest1 = new int[] { 1, 2, 3, 4, 5, 6 };
            Array.ShiftLeftByOne(arrTest1, 1, 4);
            Assert.AreEqual(new int[] { 1, 3, 4, 0, 5, 6 }, arrTest1);

            int[] arrTest2 = new int[] { 1, 2, 3, 4, 5, 6 };
            Array.ShiftLeftByOne(arrTest2, 0, 0);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, arrTest2);

            int[] arrTest3 = new int[] { 1, 2, 3, 4, 5, 6 };
            Array.ShiftLeftByOne(arrTest3, -10, 10);
            Assert.AreEqual(new int[] { 2, 3, 4, 5, 0, 6 }, arrTest3);

            int[] arrTest4 = new int[] { 1, 2, 3, 4, 5, 6 };
            Array.ShiftLeftByOne(arrTest4, 3, 0);
            Assert.AreEqual(new int[] { 2, 3, 0, 4, 5, 6 }, arrTest4);
        }

        [Test]
        public void CreateRandomArrayTest()
        {
            int size = 10;
            int minValue = -100;
            int maxValue = 100;
            int[] solutionArr = Array.CreateRandomArray(size, minValue, maxValue);
            for (int i = 0; i < solutionArr.Length; i++)
            {
                Assert.IsTrue(solutionArr[i] < 100 && solutionArr[i] > -100);
            }
        }

        [Test]
        public void CreateRandomMatrixTest()
        {
            int rows = 5;
            int columns = 5;
            int minValue = -100;
            int maxValue = 100;
            int[,] solutionArr = Array.CreateRandomMatrix(rows, columns, minValue, maxValue);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Assert.IsTrue(solutionArr[i,j] < 100 && solutionArr[i,j] > -100);
                }
            }
        }

        [Test]
        public void CopyArrayTest()
        {
            int[] arrTest1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[,] solutionArr = Array.CopyArray(arrTest1);
            Assert.AreEqual(new int[,] { { 1, 2, 3, 4, 5, 6 },
                                         { 1, 2, 3, 4, 5, 6 } }, solutionArr);
        }

        [Test]
        public void FindInSortedArrayTest()
        {
            Assert.AreEqual(0, Array.FindInSortedArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1));
            Assert.AreEqual(-1, Array.FindInSortedArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 20));
        }
    }
}