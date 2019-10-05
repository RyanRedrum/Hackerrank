using Hackerrank.Arrays;
using NUnit.Framework;

namespace Hackerrank.Tests.Arrays
{
    [TestFixture]
    public class Challenge2Tests
    {

        [Test(Description = "Calculates solution correctly.")]
        public void CalculatesCorrectly()
        {
            var result = Challenge2.RotLeft(new[] {1, 2, 3, 4, 5}, 4);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(3, result[3]);
            Assert.AreEqual(4, result[4]);
        }
        
    }
}