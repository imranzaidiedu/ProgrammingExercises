namespace CSharp.Problems.Arrays
{
    public static class ArraysMinimum
    {
        /// <summary>
        /// Question: Given an integer array, return the minimum value in the array.
        /// - Input: int[] nums (may be null or empty)
        /// - Output: int (the minimum element)
        /// Requirements: Do not use LINQ's Min or other built-in helpers; implement the logic yourself.
        /// Edge cases to consider:
        ///  - If `nums` is null, throw ArgumentNullException.
        ///  - If `nums` is empty, throw ArgumentException (no elements to compare).
        ///  - Arrays may contain negative numbers and duplicates.
        ///
        /// NOTE: This method intentionally has no implementation so it can be used as a practice question.
        /// Implementors should return the minimum integer present in `nums`.
        /// </summary>
        public static int FindMinimum(int[] nums)
        {
            // TODO: Implement this method as an exercise. Example approach:
            //  - Validate inputs
            //  - Initialize `min = nums[0]`
            //  - Iterate from i=1 to nums.Length-1 and update min
            //  - Return min
            
            if (nums == null)
            {
                throw new ArgumentNullException(nameof(nums), "Input array cannot be null.");
            }

            if (nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be empty.", nameof(nums));
            }
            
            int min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
        }
    }
}