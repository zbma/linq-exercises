using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Your task is to apply LINQ `Where` method, so all tests will be passed.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have expected value(s).
    /// </summary>
    [TestClass]
    public class Restriction
    {
        #region Basic - array of integers

        // this is test data, do not change it
        private IEnumerable<int> ints = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

        [TestMethod]
        public void Where_n_is_greater_than_1_return_3_ints()
        {
            // First test is solved to show you how to use these exercises.
            IEnumerable<int> result = ints.Where(n => n > 1);

            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void Where_n_is_less_than_or_equal_to_0_returns_expected_ints()
        {
            IEnumerable<int> result = ints;

            Assert.AreEqual(5, result.Count());
            Assert.IsTrue(new[] { -3, -1, -4, -1, -5 }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_n_multiplied_by_2_is_greater_than_5()
        {
            IEnumerable<int> result = ints;

            Assert.IsTrue(new[] { 3, 5 }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_n_is_even()
        {
            IEnumerable<int> result = ints;

            Assert.IsTrue(new[] { 2, -4 }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_index_of_n_is_odd()
        {
            IEnumerable<int> result = ints;

            Assert.IsTrue(new[] { 1, 1, 2, 3, 5 }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_n_is_even_and_n_is_less_than_0()
        {
            IEnumerable<int> result = ints;

            Assert.IsTrue(new[] { -4 }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_n_quare_minus_2_times_n_is_greater_than_n()
        {
            // n * n - 2 * n
            IEnumerable<int> result = ints;

            Assert.IsTrue(new[] { -3, -1, -4, -1, 5, -5 }.SequenceEqual(result));
        }

        #endregion

        #region Intermediate - collection of strings

        // this is test data, do not change it
        private IEnumerable<string> strings = new Collection<string>() { "tiger", "lion", "swordfish", "penguin", "elephant", "shark" };

        [TestMethod]
        public void Where_string_length_is_shorter_than_5_letters_returns_1_string()
        {
            IEnumerable<string> result = strings;

            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void Where_string_length_is_9_returns_expected_strings()
        {
            IEnumerable<string> result = strings;

            Assert.AreEqual(1, result.Count());
            Assert.IsTrue(new[] { "swordfish" }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_string_starts_with_s()
        {
            IEnumerable<string> result = strings;

            Assert.IsTrue(new[] { "swordfish", "shark" }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_string_has_i_as_a_second_letter()
        {
            IEnumerable<string> result = strings;

            Assert.IsTrue(new[] { "tiger", "lion" }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_string_contains_e()
        {
            IEnumerable<string> result = strings;

            Assert.IsTrue(new[] { "tiger", "penguin", "elephant" }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_string_ends_with_uppercase_t()
        {
            IEnumerable<string> result = strings;

            Assert.IsTrue(new[] { "elephant" }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_substring_equals_to_io()
        {
            IEnumerable<string> result = strings;

            Assert.IsTrue(new[] { "lion" }.SequenceEqual(result));
        }

        #endregion
    }
}
