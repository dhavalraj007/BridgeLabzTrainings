using MyApp;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadShouldReturnSad()
        {
            string expected = "Sad";
            string input = "I am Sad";
            MoodAnalyser md = new MoodAnalyser();

            string output= md.analyseMood(input);
            
            Assert.AreEqual(expected, output); 
        }

        [TestMethod]
        public void AnyShouldReturnHappy()
        {
            string expected = "Happy";
            string input = "I am in Any mood";
            MoodAnalyser md = new MoodAnalyser();

            string output = md.analyseMood(input);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void NullShouldReturnHappy()
        {
            string expected = "Happy";
            string input = null;
            MoodAnalyser md = new MoodAnalyser();

            string output = md.analyseMood(input);

            Assert.AreEqual(expected, output);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void CorrectFirstName()
        {
            Assert.AreEqual(true, UserRegex.ValidName("Drake"));
        }
        [TestMethod]
        public void WrongFirstName()
        {
            Assert.AreEqual(false, UserRegex.ValidName("drake"));
        }

        [TestMethod]
        public void CorrectPhone()
        {
            Assert.AreEqual(true, UserRegex.ValidPhoneNumber("91 1234567890"));
        }
        [TestMethod]
        public void WrongPhone()
        {
            Assert.AreEqual(false, UserRegex.ValidPhoneNumber("911234567890"));
        }
        [TestMethod]
        public void CorrectEmail()
        {
            Assert.AreEqual(true, UserRegex.ValidEmail("abc.xyz@bl.co.in"));
        }
        [TestMethod]
        public void WrongEmail()
        {
            Assert.AreEqual(false, UserRegex.ValidEmail("abcbl.co.in"));
            Assert.AreEqual(false, UserRegex.ValidEmail("abc@blco.in"));
            Assert.AreEqual(false, UserRegex.ValidEmail("abc@co.in"));
        }

        [TestMethod]
        public void CorrectPassword()
        {
            Assert.AreEqual(true, UserRegex.ValidPassword("A1#456789"));
        }
        [TestMethod]
        public void WrongPassword()
        {
            Assert.AreEqual(false, UserRegex.ValidPassword("a1#456789"));
            Assert.AreEqual(false, UserRegex.ValidPassword("A1#4567"));
        }

    }
}