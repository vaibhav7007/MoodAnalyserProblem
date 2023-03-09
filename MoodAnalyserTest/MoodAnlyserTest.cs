using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnlyserTest
    {
        [Test]
        public void GivenSadMood_WhenAnalysed_SholudReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Sad");
            Assert.Pass();
        }
        [Test]
        public void GivenSadMood_WhenAnalysed_SholudReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
            Assert.Pass();
        }
    }
}