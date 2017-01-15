using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Your task is to apply LINQ `First/FirstOrDefault/Last/LastOrDefault` methods, so all tests will be passed.
    /// Make sure to preview test data located in TestData.cs file.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have expected value(s).
    /// </summary>
    [TestClass]
    public class Element
    {
        [TestMethod]
        public void First_n()
        {
            // First test is solved to show you how to use these exercises.
            int result = TestData.Numbers.First();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void First_n_less_than_0()
        {
            int result = TestData.Numbers.First();

            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void Last_n_greater_than_0()
        {
            int result = TestData.Numbers.Last();

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void First_even_n()
        {
            int result = TestData.Numbers.First();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Last_even_n()
        {
            int result = TestData.Numbers.Last();

            Assert.AreEqual(-4, result);
        }

        [TestMethod]
        public void First_n_greater_than_10_if_not_found_return_0()
        {
            int result = TestData.Numbers.First();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Last_n_less_than_minus_1234_if_not_found_return_0()
        {
            int result = TestData.Numbers.Last();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Last_elephant()
        {
            string result = TestData.Animals.Last();

            Assert.AreEqual("elephant", result);
        }

        [TestMethod]
        public void First_string_having_4_letters()
        {
            string result = TestData.Animals.First();

            Assert.AreEqual("lion", result);
        }

        [TestMethod]
        public void Last_string_containg_g()
        {
            string result = TestData.Animals.Last();

            Assert.AreEqual("penguin", result);
        }

        [TestMethod]
        public void First_string_having_s_as_first_letter()
        {
            string result = TestData.Animals.First();

            Assert.AreEqual("swordfish", result);
        }

        [TestMethod]
        public void Last_three_letter_long_word_or_null()
        {
            string result = TestData.Animals.Last(s => s.Length == 3);

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void First_person_born_after_2000()
        {
            TestData.Person result = TestData.People.First();

            Assert.AreEqual(TestData.People[2], result);
        }

        [TestMethod]
        public void Last_person_with_lastname_ending_with_l()
        {
            TestData.Person result = TestData.People.Last();

            Assert.AreEqual(TestData.People[2], result);
        }

        [TestMethod]
        public void First_person_born_141th_day_of_year()
        {
            TestData.Person result = TestData.People.First();

            Assert.AreEqual(TestData.People[2], result);
        }

        [TestMethod]
        public void Last_person_whose_firstname_does_not_start_with_J_or_null()
        {
            TestData.Person result = TestData.People.Last();

            Assert.AreEqual(null, result);
        }
    }
}