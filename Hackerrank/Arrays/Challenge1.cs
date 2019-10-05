using System;
using System.Collections.Generic;

namespace Hackerrank.Arrays
{
    //https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    public static class Challenge1
    {

        public static int HourglassSum(int[][] arr)
        {
            var maxHourglass = int.MinValue;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var sum = CalculateHourglass(i, j, arr);
                    if (sum > maxHourglass)
                    {
                        maxHourglass = sum;
                    }
                }
            }

            return maxHourglass;
        }

        private static int CalculateHourglass(int x, int y, IReadOnlyList<int[]> arr)
        {
            var sum = 0;
            for (var i = y; i <= y + 2; i++)
            {
                for (var j = x; j <= x + 2; j++)
                {
                    if (i != y + 1 || (j != x && j != x + 2))
                    {
                        sum += arr[i][j];
                    }
                }
            }
            
            return sum;
        }
        
    }
}