namespace MySolutions._645.SetMisMatach
{
    internal class MissMatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int element = 0; //missing element 
            int duplicateIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (duplicateIndex == -1)
                {
                    duplicateIndex = nums.ToList().IndexOf(nums[i], i + 1);
                }
                if (!nums.Contains(i + 1))
                {
                    element = i + 1;
                }
            }

            return new int[] { nums[duplicateIndex], element };
        }
    }
}
