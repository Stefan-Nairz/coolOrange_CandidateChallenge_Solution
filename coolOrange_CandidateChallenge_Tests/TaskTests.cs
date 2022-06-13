using NUnit.Framework;
using coolOrange_CandidateChallenge_Solution;

namespace coolOrange_CandidateChallenge_Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void CompareToTest()
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

            Assert.AreEqual(doingHomework, eatingLunch.CompareTo(doingHomework));
            Assert.AreEqual(programming, eatingLunch.CompareTo(programming));
            Assert.AreEqual(doingHomework, doingHomework.CompareTo(eatingLunch));
            Assert.AreEqual(doingHomework, doingHomework.CompareTo(programming));
            Assert.AreEqual(doingHomework, programming.CompareTo(doingHomework));
            Assert.AreEqual(programming, programming.CompareTo(eatingLunch));
        }
    }
}
