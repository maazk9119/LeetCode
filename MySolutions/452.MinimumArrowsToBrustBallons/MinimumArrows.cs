namespace MySolutions._452.MinimumArrowsToBrustBallons
{
    internal class MinimumArrows
    {
        public static int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
      
            int end = points[0][1], arrow = 1;
            for (int i = 1; i < points.Length; i++)
            {
                if (end >= points[i][0])
                    continue;

                arrow++;
                end = points[i][1];
            }

            return arrow;
        }
    }
}
