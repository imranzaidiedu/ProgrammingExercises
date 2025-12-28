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
    }
}