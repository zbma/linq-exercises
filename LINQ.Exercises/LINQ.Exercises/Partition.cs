using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Look here for a primer:
    /// http://code.msdn.microsoft.com/LINQ-Partitioning-Operators-c68aaccc
    /// HINTS: Use TakeWhile, TakeWhile - indexed: TakeWhile( (element, index) => etc ), Skip, SkipWhile - indexed  e.g. SkipWhile((element, index) => etc )
    /// Please refer to the MSDN documentation if you have any trouble.
    /// Make sure to preview test data located in TestData.cs file.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have expected value(s).
    /// </summary>
    [TestClass]
    public class Partition
    {
        [TestMethod]
        public void GetFirstThreeNumbers_returns_3_ints()
        {
            // First test is solved to show you how to use these exercises.
            IEnumerable<int> result = TestData.PartitionNumbers.Take(3);

            Assert.IsTrue(result.SequenceEqual(new[] { 5, 4, 1 }));
        }

        // Get the first two numbers in the array
        [TestMethod]
        public void GetFirstTwoNumbers_returns_2_ints()
        {
            IEnumerable<int> result = TestData.PartitionNumbers;

            Assert.IsTrue(result.SequenceEqual(new[] { 5, 4 }));
        }

        // return everything in the array but the first four numbers
        [TestMethod]
        public void IgnoreFirstFourNumbers_returns_4_ints()
        {
            IEnumerable<int> result = TestData.PartitionNumbers;

            Assert.IsTrue(result.SequenceEqual(new[] { 9, 8, 6, 7, 2, 0 }));
        }

        // return elements starting from the beginning of the array
        // until a number is hit that is not less than 6
        [TestMethod]
        public void Enumerate_Till_You_Get_A_Number_NotLessThanSix_returns_4_ints()
        {
            IEnumerable<int> result = TestData.PartitionNumbers;

            Assert.IsTrue(result.SequenceEqual(new[] { 5, 4, 1, 3 }));
        }

        // return elements starting from the beginning of the array
        // until a number is hit that is less than its position in the array
        [TestMethod]
        public void Enumerate_Till_A_Number_Hit_Which_is_less_than_its_own_array_position_returns_2_ints()
        {
            IEnumerable<int> result = TestData.PartitionNumbers;

            Assert.IsTrue(result.SequenceEqual(new[] { 5, 4 }));
        }

        // get the elements of the array
        // starting from the first element divisible by 3
        [TestMethod]
        public void GetElementsOfArrayStartingFromTheFirstElementDivisibleByThree_Return7ints()
        {
            IEnumerable<int> result = TestData.PartitionNumbers;

            Assert.IsTrue(result.SequenceEqual(new[] { 3, 9, 8, 6, 7, 2, 0 }));
        }

        // get the elements of the array
        // starting from the first element less than its position.
        [TestMethod]
        public void GetElementsStartingFromFirstElementLessThanItsPosition_Return8ints()
        {
            IEnumerable<int> result = TestData.PartitionNumbers;

            Assert.IsTrue(result.SequenceEqual(new[] { 1, 3, 9, 8, 6, 7, 2, 0 }));
        }
    }
}