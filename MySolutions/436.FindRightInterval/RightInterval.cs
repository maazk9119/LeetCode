namespace MySolutions.FindRightInterval
{
    internal class RightInterval
    {
        public static int[] Solution(int[][] intervals)
        {
            Dictionary<Tuple<int, int>, int> position = new Dictionary<Tuple<int, int>, int>();
            Dictionary<Tuple<int, int>, int> result = new Dictionary<Tuple<int, int>, int>();
            
            //save positions of intervals
            int index = 0;
            foreach (var interval in intervals)
            {
                position.Add(new Tuple<int, int>(interval[0], interval[1]), index); index++;
            }

            List<List<int>> intervalsList = intervals.Select(x => x.ToList()).ToList().OrderBy(x => x[0]).ToList();
            bool isTrue = false;

            //iterate & right interval
            for (int i = 0; i < intervalsList.Count(); i++)
            {
                Tuple<int, int> q = new Tuple<int, int>(intervalsList[i][0], intervalsList[i][1]);
                for (int j = i + 1; j < intervalsList.Count(); j++)
                {
                    //interval start == end is equal 
                    if (intervalsList[i][0] == intervalsList[i][1])
                    {
                        Tuple<int, int> p = new Tuple<int, int>(intervalsList[i][0], intervalsList[i][1]);
                        result.Add(p, position[p]);
                        isTrue = true;
                        break;
                    }
                    //minimize start of j interval
                    if (intervalsList[i][1] <= intervalsList[j][0])
                    {
                        Tuple<int, int> t = new Tuple<int, int>(intervalsList[j][0], intervalsList[j][1]);
                        result.Add(q, position[t]);
                        isTrue = true;
                        break;
                    }
                }

                if (!isTrue)
                {
                    result.Add(q, -1);
                }

                isTrue = false;
            }

            //validate last sub-set 
            if (intervalsList[intervalsList.Count() - 1][0] == intervalsList[intervalsList.Count() - 1][1])
            {
                Tuple<int, int> t = new Tuple<int, int>(intervalsList[intervalsList.Count() - 1][0], intervalsList[intervalsList.Count() - 1][1]);
                result[t] = position[t];
            }

            //save actual position
            foreach (var i in position)
            {
                position[i.Key] = result[i.Key];
            }

            return position.Select(x => x.Value).ToArray();
        }
    }
}
