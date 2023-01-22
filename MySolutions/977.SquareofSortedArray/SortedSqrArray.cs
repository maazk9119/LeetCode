namespace MySolutions._977.SquareofSortedArray
{
    internal class SortedSqrArray
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);

            return nums;
        }
    }
}
