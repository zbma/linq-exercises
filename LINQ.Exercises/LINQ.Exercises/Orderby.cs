using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Look here for a primer:
    /// https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
    /// https://msdn.microsoft.com/en-us/library/bb534966(v=vs.110).aspx
    ///
    /// Make sure to preview test data located in TestData.cs file.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so
    /// `result` variable will have expected value(s).
    ///
    /// Hint: use OrderBy, OrderByDescending, ThenBy, and ThenByDescending and Reverse
    /// sometimes you'll have to use a class which inherits from IComparer
    /// Create and implement the interface to acheive the desired outcome.
    /// Hint: use google to find out who to compare two strings alphabetically, ignoring case
    /// </summary>
    ///

    [TestClass]
    public class OrderBy
    {
        [TestMethod]
        public void OrderWordsAlphabetically_ReturnThreeWords()
        {
            // Solved for your benefit
            IEnumerable<string> result = TestData.OrderByWords.OrderBy(word => word);

            Assert.IsTrue(result.SequenceEqual(new string[] { "apple", "blueberry", "cherry" }));
        }

        // starting from a to z - order ascending
        [TestMethod]
        public void OrderWordsAlphabetically_Return5Words()
        {
            IEnumerable<string> result = TestData.OrderByWordsExtended;
            Assert.IsTrue(result.SequenceEqual(new string[] { "apple", "blueberry", "cherry", "tamarind", "zuchini" }));
        }

        [TestMethod]
        public void OrderWordsBySecondLetter_Return5Words()
        {
            IEnumerable<string> result = TestData.OrderByWordsExtended;

            Assert.IsTrue(result.SequenceEqual(new string[] { "tamarind", "cherry", "blueberry", "apple", "zuchini" }));
        }

        // remember has to be descending:
        [TestMethod]
        public void OrderWordsByFirstLetterDescendingAlphabetically_Return5Words()
        {
            IEnumerable<string> result = TestData.OrderByWordsExtended;

            Assert.IsTrue(result.SequenceEqual(new string[] { "zuchini", "tamarind", "cherry", "blueberry", "apple", }));
        }

        // order by the length (i.e. number of characters in each word):
        [TestMethod]
        public void OrderWordsByByLength_Return3Words()
        {
            IEnumerable<string> result = TestData.OrderByWords;

            Assert.IsTrue(result.SequenceEqual(new string[] { "apple", "cherry", "blueberry" }));
        }

        [TestMethod]
        public void OrderByPeopleByPersonsLastNameAlphabetically_returnOrderedPeople()
        {
            IEnumerable<TestData.Person> result = TestData.People;

            Assert.IsTrue(result.SequenceEqual(new TestData.Person[]
            {
                    new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                    new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                    new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                    new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12))
            }));
        }

        // hint: https://msdn.microsoft.com/en-us/library/bb549422(v=vs.110).aspx
        // you need to create a class that implements the IComparer interface
        // Strictly speaking, the MSDN documentation suggests that you should
        // not inherit from IComparer, but your class should inherit from
        // the Comparer<T> class. But for the purposes of this exercise
        // inheriting from IComparer will do just fine.
        [TestMethod]
        public void OrderAlphabeticallyAssumingCaseInsensitivity_ReturnCaseInsensitiveEnumeration()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words;

            Assert.IsTrue(result.SequenceEqual(new string[] {
                "AbAcUs", "aPPLE", "BlUeBeRrY", "bRaNcH", "cHeRry", "ClOvEr"
            }));
        }

        // The comparison can be more complex.
        // Let us compare two strings by a function of their lengths.
        // let us call this function the calculated_length of the string.
        // if the length is an odd number: then the calculated_length of the string
        // is the actual length of the string. but if the length of the string is an
        // even number, then the calculated_length of the string is twice the actual string's length.

        // let's order an array of strings: {"toy", "by"}
        // e.g. "toy" is of length 3 - which is odd - so the calculated length = 3
        // e.g. "by" is of length 2 - which is even - so the calculated length is 4.
        // we need to order by calculated_length
        // so the enumeration, assuming ascending order by calculated_length
        // should be "by" and then "toy"

        [TestMethod]
        public void OrderAssumingSpecialCondition_ReturnSpecialEnumeration()
        {
            IEnumerable<string> result = TestData.OrderByWordsExtended;

            Assert.IsTrue(result.SequenceEqual(new string[] { "apple", "zuchini", "blueberry", "cherry", "tamarind" }));
        }

        [TestMethod]
        public void OrderDoublesFromLargestToSmallest_returnDescendingEnumeration()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            IEnumerable<double> result = doubles;

            Assert.IsTrue(result.SequenceEqual(new double[] { 4.1, 2.9, 2.3, 1.9, 1.7 }));
        }

        [TestMethod]
        public void OrderByBirthDatesOldestToYoungest_returnPersonEnumeration()
        {
            IEnumerable<TestData.Person> result = TestData.People;

            Assert.IsTrue(result.SequenceEqual(new TestData.Person[] {
                    new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                    new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                    new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                    new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21))
            }));
        }

        [TestMethod]
        public void OrderByBirthDatesYoungestToOldest_returnPersonEnumeration()
        {
            IEnumerable<TestData.Person> result = TestData.People;

            Assert.IsTrue(result.SequenceEqual(new TestData.Person[] {
                    new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                    new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                    new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                    new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1))
            }));
        }

        [TestMethod]
        public void OrderByLengthAndThenAlphabetically_returnStringNumberation()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            IEnumerable<string> result = digits;

            Assert.IsTrue(result.SequenceEqual(new string[] { "one", "six", "two", "five", "four", "nine", "zero", "eight", "seven", "three" }));
        }

        // order by increasing length
        // then by alphabetically from a to z, ignoring case
        [TestMethod]
        public void OrderByLengthThenAlphabeticallyIgnoringCase_returnStringEnumeration()
        {
            #region hint

            // you will have to create a class which implements the IComparer<string> interface

            #endregion hint

            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            IEnumerable<string> result = words;

            Assert.IsTrue(result.SequenceEqual(new string[] { "aPPLE", "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr", "BlUeBeRrY" }));
        }

        // use Reverse to create a list of all digits in the array whose
        // second letter is 'i' that is reversed from the order in the original array.
        [TestMethod]
        public void ComplexQuery_returnStringEnumeration()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            IEnumerable<string> result = digits;

            Assert.IsTrue(result.SequenceEqual(new string[] { "nine", "eight", "six", "five" }));
        }
    }
}
