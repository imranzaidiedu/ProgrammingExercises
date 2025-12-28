namespace CSharp.Problems.Arrays
{
    public static class SumOfArray
    {
        public static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        
        public static int SumPositive(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if (num > 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}