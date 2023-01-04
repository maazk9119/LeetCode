namespace MySolutions.TwoSum
{
    internal class TwoSumClass
    {
        public static int[] Solution(int[] nums, int target)
        {
            List<int> numbers = nums.ToList();
            int[] index = new int[2];

            for (int i = 0; i < numbers.Count; i++)
            {
                int notFound = target - numbers[i];
                int index2 = numbers.IndexOf(notFound, i + 1);

                if (index2 != -1)
                {
                    index[0] = i;
                    index[1] = index2;

                }
            }


            return index;
        }
    }
}
