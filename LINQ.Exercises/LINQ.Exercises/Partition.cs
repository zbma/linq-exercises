using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

             // This is the test data
             // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
             IEnumerable<int> result = TestData.PartioningNumbers.Take(3);

             Assert.IsTrue(result.SequenceEqual(new [] {5,4,1} )) ;
         }

         [TestMethod]
         public void GetFirstTwoNumbers_returns_2_ints()
         {           
             // please complete the below so the test passes:
             // Get the first two numbers in the array

             IEnumerable<int> result = TestData.PartioningNumbers;          

             Assert.IsTrue(result.SequenceEqual(new[] { 5, 4 }));
         }         

         [TestMethod]
         public void IgnoreFirstFourNumbers_returns_4_ints()
         {
             // return everything in the array but the first four numbers:

             // please complete the below so the test passes:
             IEnumerable<int> result = TestData.PartioningNumbers;                        

             Assert.IsTrue(result.SequenceEqual(new[] { 9, 8, 6, 7, 2, 0 }));
         }

         [TestMethod]
         public void Enumerate_Till_You_Get_A_Number_NotLessThanSix_returns_4_ints()
         {
             // This is tricky. Please read the below very carefully:
             // return elements starting from the beginning of the array until a number is hit that is not less than 6.
            
             // please complete the below so the test passes:
              IEnumerable<int> result = TestData.PartioningNumbers;             

             Assert.IsTrue(result.SequenceEqual(new[] { 5,4,1,3 }));         
         }

         [TestMethod]
         public void Enumerate_Till_A_Number_Hit_Which_is_less_than_its_own_array_position_returns_2_ints()
         {
             // This is tricky. Please read the below very carefully:
             // return elements starting from the beginning of the 
             // array until a number is hit that is less than its position in the array.

             // please complete the below so the test passes:
             IEnumerable<int> result = TestData.PartioningNumbers;           

             Assert.IsTrue(result.SequenceEqual(new[] { 5, 4 }));

             #region Hint
             //  Use: TakeWhile             
             #endregion
         }

         [TestMethod]
         public void GetElementsOfArrayStartingFromTheFirstElementDivisibleByThree_Return7ints()
         {             
             // get the elements of the array starting from the first element divisible by 3.
             
             // please complete the below so the test passes:
             IEnumerable<int> result = TestData.PartioningNumbers;

             Assert.IsTrue(result.SequenceEqual(new[] { 3, 9, 8, 6, 7, 2, 0 }));
         }

        [TestMethod]
         public void GetElementsStartingFromFirstElementLessThanItsPosition_Return8ints()
         {
             // get the elements of the array starting from the first element less than its position.

             // please complete the below so the test passes:
             IEnumerable<int> result = TestData.PartioningNumbers;

             Assert.IsTrue(result.SequenceEqual(new[] { 1, 3, 9, 8, 6, 7, 2, 0 }));
         }
      
         // Want more questions? Want harder questions?
         // Your valuable input is required.
         // Why not contribute to this repo? YOU, yes you, can make a big difference!

    }
}
