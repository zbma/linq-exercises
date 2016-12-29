using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Your task is to apply LINQ `Count/Sum/Min/Max/Average/Aggregate` methods, so all tests will be passed.
    /// Make sure to preview test data located in TestData.cs file.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have expected value(s).
    /// </summary>
    [TestClass]
    public class Aggregate
    {
        [TestMethod]
        public void Count_all_numbers()
        {
            // First test is solved to show you how to use these exercises.

            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Numbers.Count();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Count_all_occurences_of_1()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Numbers.Count();

            #region Answer
            // int result = TestData.Numbers.Where(x => x ==1).Count(); 
            #endregion

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Count_all_animals_having_character_count_equal_to_5()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            // hint: use nested count
            int result = TestData.Animals.Count();

            #region answer
            // int result = TestData.Animals.Where( animalString => animalString.Count() == 5).Count(); 
            #endregion

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Sum_all_numbers()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Numbers.Count();

            #region answers
            // int result = TestData.Numbers.Sum(); 
            #endregion

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Sum_all_characters_in_animal_names()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Animals.Count();

            #region answer
            // int result = TestData.Animals.Sum(animalString => animalString.Count());            
            #endregion

            Assert.AreEqual(38, result);
        }

        [TestMethod]
        public void Sum_all_birth_years()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.People.Count();

            #region answer
            //int result = TestData.People.Sum(person => person.Born.Year);            
            #endregion

            Assert.AreEqual(7915, result);
        }

        [TestMethod]
        public void Find_minimum_number()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Numbers.Count();

            #region answer
            //int result = TestData.Numbers.Min();            
            #endregion

            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Find_length_of_shortest_animal_name()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Animals.Count();

            #region MyRegion
            //    int result = TestData.Animals.Min(animalString => animalString.Count());            
            #endregion

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Find_earliest_birthday()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            DateTime result = TestData.People.First().Born;

            #region answer
            // DateTime result = TestData.People.Select(person => person.Born).Min();            
            #endregion

            Assert.AreEqual(new DateTime(1950, 12, 1), result);
        }

        [TestMethod]
        public void Find_maximum_number()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Numbers.Count();

            #region answer
            // int result = TestData.Numbers.Max(); 
            #endregion

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Find_length_of_longest_animal_name()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            int result = TestData.Animals.Count();

            #region answer
            // int result = TestData.Animals.Max(x => x.Count()); 
            #endregion

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Find_latest_birthday()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            DateTime result = TestData.People.First().Born;

            #region answer
                // DateTime result = TestData.People.Max(person => person.Born); 
            #endregion

            Assert.AreEqual(new DateTime(2001, 5, 21), result);
        }

        [TestMethod]
        public void Find_average_of_numbers()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            double result = TestData.Numbers.Count();

            #region answer
                // double result = TestData.Numbers.Average();            
            #endregion

            Assert.AreEqual(-0.2, result);
        }

        [TestMethod]
        public void Find_average_of_birth_years()
        {
            // This is the data used:
            // int[] Numbers = new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };

            double result = TestData.People.Count();

            #region answer
                // double result = TestData.People.Select(p => p.Born.Year).Average(); 
            #endregion

            Assert.AreEqual(1978.75, result);
        }

        [TestMethod]
        public void Aggregate_Sum_of_all_numbers()
        {
            // Aggregate is a little bit more complicated
            // so first test is solved to show you how to use it.
            int result = TestData.Numbers.Aggregate((sum, nextValue) => sum + nextValue);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Aggregate_Product_of_all_numbers()
        {
            // product is an result of multiplication
            int result = TestData.Numbers.Aggregate((product, nextValue) => 1);

            #region answer
                // int result = TestData.Numbers.Aggregate( (sum, nextNumber) => sum * nextNumber );            
            #endregion

            Assert.AreEqual(-1800, result);
        }

        [TestMethod]
        public void Aggregate_Secret_formula()
        {
            // secret formula is as follows
            // start with 256
            // for each person take the day of her/his birth date
            // if this day is bigger than 15, then substract 10 from it
            // else add 5 to it
            // and add resulting number to your aggregate
            int result = TestData.People.Aggregate(0, (sum, nextValue) => 1);

            // Left as an exercise for the student

            Assert.AreEqual(296, result);
        }
    }
}