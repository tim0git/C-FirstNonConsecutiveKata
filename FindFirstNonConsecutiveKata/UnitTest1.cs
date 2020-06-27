using NUnit.Framework;

namespace FindFirstNonConsecutiveKata
{
    public class Tests
    {
        /*[SetUp]
        public void Setup()
        {
        }*/

        [Test]
        public void when_passed_a_consecutive_array_returns_null()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };

            string output = FindFirstNonConsecFunc.Class1.GetValue(input);
                            
            //Assert
            Assert.AreEqual(null, output);
        }

        [Test]
        public void when_passed_a_non_consecutive_array_at3_returns_4()
        {
            int[] input = { 1, 2, 4, 5, 6 };

            string output = FindFirstNonConsecFunc.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("4", output);
        }

        [Test]
        public void when_passed_a_non_consecutive_array_at5_returns_6()
        {
            int[] input = { 1, 2, 3, 4, 6 };

            string output = FindFirstNonConsecFunc.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("6", output);
        }

        [Test]
        public void when_passed_a_non_consecutive_array_at11_returns_12()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12 };

            string output = FindFirstNonConsecFunc.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("12", output);
        }

        [Test]
        public void when_passed_a_non_consecutive_array_at2_returns_3()
        {
            int[] input = { 1, 3, 4, 5, 6, 7, 8, 9, 10, 12 };

            string output = FindFirstNonConsecFunc.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("3", output);
        }
    }
}