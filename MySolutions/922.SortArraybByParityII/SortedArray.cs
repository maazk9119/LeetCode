namespace MySolutions._922.SortArraybByParityII
{
    internal class SortedArray
    {
        public int[] SortArrayByParityII(int[] nums)
        {
            int i = 0;
            int j = 1;
            int[] result = new int[nums.Length];

            for (int p = 0; p < nums.Length; p++)
            {
                if (nums[p] % 2 == 0)
                {
                    result[i] = nums[p];
                    i = i + 2;
                    continue;
                }

                result[j] = nums[p];
                j = j + 2;
            }

            return result;
        }
    }
}
