namespace MySolutions._35.SearchInsertPosition
{
    internal class InsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            List<int> list = nums.ToList();

            if (!list.Contains(target))
            {
                list.Add(target);
                list.Sort();

                return list.IndexOf(target);
            }

            return list.IndexOf(target);
        }
    }
}
