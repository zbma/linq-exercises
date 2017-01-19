using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Your task is to apply LINQ `Distinct/Union/Intersect/Except/OrderBy` methods,
    /// so all tests will be passed.
    /// Make sure to preview test data located in TestData.cs file.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so `result`
    /// variable will have expected value(s).
    /// Errata: please post an issue on github.
    /// Look here for a primer: https://code.msdn.microsoft.com/LINQ-Set-Operators-374f34fe
    /// But even better is to start at the MSDN pages for the above methods
    /// </summary>

    [TestClass]
    public class SetOperations
    {
        [TestMethod]
        public void GetDistinctNumbers_ReturnIEnumerable()
        {
            int[] randomNumbers = { 2, 2, 3, 5, 5, 2, 3, 4, 6, 4, 3, 8, 7, 5, 9, 4, 6, 3, 6, 34, 2, 2, 5, 7, 5, 4, 2, 6, 67, 5 };

            // I want to see an enumerable which contains only the unique numbers in the
            // above array

            IEnumerable<int> result = randomNumbers; // please edit/complete so that the test passes

            Assert.IsTrue(result.SequenceEqual(new int[] { 2, 3, 5, 4, 6, 8, 7, 9, 34, 67 }));
        }

        [TestMethod]
        public void GetUniqueNumbersFromTwoArraysInAscendingOrder_ReturnEnumerable()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // get the unique numbers
            // from both arrays combined
            // in ascending order from 1...9

            IEnumerable<int> result = numbersA; // please edit/complete so that the test passes

            Assert.IsTrue(result.SequenceEqual(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        [TestMethod]
        public void GetCommonValuesSharedByBothArrays_ReturnEnumerable()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            IEnumerable<int> result = numbersA; // please edit/complete so that the test passes

            Assert.IsTrue(result.SequenceEqual(new int[] { 5, 8 }));
        }

        [TestMethod]
        public void GetCharactersCommonToEveryonesFirstNamesUsingSetElements_ReturnCharEnumerable()
        {
            // we have a list of people
            // we have their first names
            // i need you to find out which letters are common
            // to all the first names

            // Hint: try to use set operations.
            // There are many ways to solve this.

            List<char> commonCharacters = new List<char>(); // please edit/complete so that the test passes

            Assert.IsTrue(commonCharacters.OrderBy(x => x).SequenceEqual(new char[] { 'a', 'i', 'J' }.OrderBy(x => x)));
        }

        [TestMethod]
        public void GetCharactersCommonToEveryonesFirstNamesNotUsingSetOperations_ReturnCharEnumerable()
        {
            // Bonus Question
            // we have a list of people
            // we have their first names
            // i need you to find out which letters are common
            // to all the first names names
            // But you are not allowed to use set operations.

            // Please edit the below and complete so that the test passes
            IEnumerable<char> result = new List<char>();

            Assert.IsTrue(result.OrderBy(x => x).SequenceEqual(new char[] { 'a', 'i', 'J' }.OrderBy(x => x)));
        }

        [TestMethod]
        public void GetNumbersInFirstArrayThatAreNotAlsoInSecondArray_ReturnIenumerableInt()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            IEnumerable<int> result = numbersA; // please complete so that the test passes

            Assert.IsTrue(result.OrderBy(x => x).SequenceEqual(new int[] { 0, 2, 4, 6, 9 }.OrderBy(x => x)));
        }

        [TestMethod]
        public void GetStringsInFirstArrayThatAreNotAlsoInSecondArray_ReturnIenumerableString()
        {
            string[] lettersA = { "a", "b", "c", "d", "e" };
            string[] lettersB = { "a", "c", "e" };

            IEnumerable<string> result = lettersA; // please complete so that the test passes

            Assert.IsTrue(result.OrderBy(x => x).SequenceEqual(new string[] { "b", "d" }));
        }
    }
}