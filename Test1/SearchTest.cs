using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test1
{
    [TestFixture]
    class SearchTest
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 0, -1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 6, -1)]
        [TestCase(new[] { 1, 2, 4, 5 }, 3, -1)]
        [TestCase(new int[0], 3, -1)]

        public static void RunTests(int[] input, int searchElement, int expectedOutput)
        {
            Test(input, searchElement, expectedOutput);
        }

        public static void Test(int[] input, int searchElement, int expectedResult)
        {
            var actualResult = Search<int>.BinarySearch(input.ToList(), searchElement);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
