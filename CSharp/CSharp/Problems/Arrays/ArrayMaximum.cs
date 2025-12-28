namespace CSharp.Problems.Arrays
{
    public static class ArrayMaximum
    {
        public static int FindMaximum(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException(nameof(nums), "Input array cannot be null.");
            }
            if (nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be empty.", nameof(nums));
            }
        
            int max = nums[0];
        
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
        
            return max;
        }
    }
}