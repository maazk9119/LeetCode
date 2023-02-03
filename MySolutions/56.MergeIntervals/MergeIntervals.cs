namespace MySolutions._56.MergeIntervals
{
    internal class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            List<List<int>> result = new List<List<int>>();
            int resultcount = 0;

            List<List<int>> listintervals = intervals.Select(x => x.ToList()).ToList().OrderBy(x => x[0]).ToList();

            result.Add(listintervals[0]);

            for (int i = 1; i < listintervals.Count; i++)
            {
                if (result[resultcount][1] < listintervals[i][0])
                {
                    result.Add(listintervals[i]);
                    resultcount++;
                }
                else
                {
                    if (result[resultcount][0] > listintervals[i][0])
                    {
                        result[resultcount][0] = listintervals[i][0];
                    }
                    if (result[resultcount][1] < listintervals[i][1])
                    {
                        result[resultcount][1] = listintervals[i][1];
                    }
                }
            }

            intervals = result.Select(x => x.ToArray()).ToArray();

            return intervals;
        }
    }
}
