using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test1
{
    [TestFixture]
    class CompressorTest
    {
        [TestCase("aabcccccaaa", "a2b1c5a3")]
        [TestCase("abcd", "abcd")]
        [TestCase("", "")]
        [TestCase("11123333", "132134")]


        public static void RunTests(string input, string expectedOutput)
        {
            Test(input, expectedOutput);
        }

        public static void Test(string input, string expectedResult)
        {
            var actualResult = Compressor.CompressionString(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
   
}
