namespace MySolutions._628.MaximumProductofThreeNumbers
{
    internal class ThreeNumberProduct
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);

            int i = nums[0] * nums[1] * nums[nums.Length - 1];
            int j = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];

            return i > j ? i : j;
        }
    }
}
