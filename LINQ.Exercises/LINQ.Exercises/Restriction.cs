using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        #region Advanced - list of persons

        private class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public DateTime Born { get; set; }

            public Person(string firstname, string lastname, DateTime born)
            {
                this.FirstName = firstname;
                this.LastName = lastname;
                this.Born = born;
            }
        }

        // this is test data, do not change it
        private IList<Person> people = new List<Person>
        {
            new Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
            new Person("Jean", "Gean", new DateTime(1950, 12, 1)),
            new Person("Jill", "Lill", new DateTime(2001, 5, 21)),
            new Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
        };

        [TestMethod]
        public void Where_person_firstname_and_lastname_starts_with_same_letter()
        {
            IEnumerable<Person> result = people;

            Assert.IsTrue(new[] { people[3] }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_person_was_born_before_1990()
        {
            IEnumerable<Person> result = people;

            Assert.IsTrue(new[] { people[1], people[3] }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_person_was_born_on_day_with_even_number()
        {
            IEnumerable<Person> result = people;

            Assert.IsTrue(new[] { people[0], people[3] }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_person_was_born_on_monday_21st()
        {
            IEnumerable<Person> result = people;

            Assert.IsTrue(new[] { people[2] }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_person_had_18_years_or_more_in_2000()
        {
            IEnumerable<Person> result = people;

            Assert.IsTrue(new[] { people[1], people[3] }.SequenceEqual(result));
        }

        [TestMethod]
        public void Where_person_lastname_contains_ll_and_sum_of_year_month_day_is_greater_than_2000()
        {
            IEnumerable<Person> result = people;

            Assert.IsTrue(new[] { people[2] }.SequenceEqual(result));
        }

        #endregion
    }
}
