namespace MySolutions._57.InsertInterval
{
    internal class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<List<int>> list = intervals.Select(x => x.ToList()).ToList();
            List<List<int>> result = new List<List<int>>();
            int resultIndex = 0;

            list.Add(newInterval.ToList());
            list = list.OrderBy(x => x[0]).ToList();
            result.Add(list[0]);


            for (int i = 1; i < list.Count; i++)
            {
                if (list[i][0] > result[resultIndex][1])
                {
                    result.Add(list[i]);
                    resultIndex++;
                }
                else
                {
                    if (list[i][0] < result[resultIndex][0])
                    {
                        result[resultIndex][0] = list[i][0];
                    }
                    if (list[i][1] > result[resultIndex][1])
                    {
                        result[resultIndex][1] = list[i][1];
                    }
                }
            }

            return result.Select(x => x.ToArray()).ToArray();
        }
    }
}
