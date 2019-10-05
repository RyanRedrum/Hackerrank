namespace Hackerrank.Arrays
{
    public static class Challenge2
    {

        public static int[] RotLeft(int[] a, int d)
        {
            var result = new int[a.Length];

            for (var i = 0; i < a.Length; i++)
            {
                result[(i + (a.Length - d)) % a.Length] = a[i];
            }
            
            return result;
        }
        
    }
}