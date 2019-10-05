using Hackerrank.Arrays;
using NUnit.Framework;

namespace Hackerrank.Tests.Arrays
{
    [TestFixture]
    public class Challenge1Tests
    {

        private static readonly int[][] ChallengeInput = {
            new[] {1, 1, 1, 0, 0, 0},
            new[] {0, 1, 0, 0, 0, 0},
            new[] {1, 1, 1, 0, 0, 0},
            new[] {0, 0, 2, 4, 4, 0},
            new[] {0, 0, 0, 2, 0, 0},
            new[] {0, 0, 1, 2, 4, 0}
        };

        private static readonly int[][] TestCase3Input =
        {
            new[] {-1, -1, 0, -9, -2, -2},
            new[] {-2, -1, -6, -8, -2, -5,},
            new[] {-1, -1, -1, -2, -3, -4},
            new[] {-1, -9, -2, -4, -4, -5},
            new[] {-7, -3, -3, -2, -9, -9},
            new[] {-1, -3, -1, -2, -4, -5}
        };
        
        [Test(Description = "Sum is calculated correctly.")]
        public void CalculateSum()
        {
            Assert.AreEqual(19, Challenge1.HourglassSum(ChallengeInput));
        }

        [Test(Description = "Calcluates test case 3 correctly.")]
        public void TestCase3()
        {
            Assert.AreEqual(-6, Challenge1.HourglassSum(TestCase3Input));
        }
        
    }
}