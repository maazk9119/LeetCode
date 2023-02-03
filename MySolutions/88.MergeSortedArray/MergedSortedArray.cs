namespace MySolutions._88.MergeSortedArray
{
    internal class MergedSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int count = 0;

            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (nums1[i] == 0 && count < nums2.Length)
                {
                    nums1[i] = nums2[count];
                    count++;
                }
            }

            Array.Sort(nums1);
        }
    }
}
