using System;
using System.Collections.Generic;

namespace LINQ.Exercises
{
    /// <summary>
    /// Data used for tests.
    /// Don't change it
    /// </summary>
    internal static class TestData
    {
        internal static IEnumerable<int> Integers
        {
            get
            {
                return new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };
            }
        }

        internal static ICollection<string> Strings
        {
            get
            {
                return new[] { "tiger", "lion", "swordfish", "penguin", "elephant", "shark" };
            }
        }

        internal static IList<Person> People
        {
            get
            {
                return new[]
                {
                    new Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                    new Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                    new Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                    new Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                };
            }
        }

        internal class Person
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
    }
}
