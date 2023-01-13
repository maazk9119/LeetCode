namespace MySolutions._1443.MinimumTimeToCollectAllApplesInATree
{
    internal class Apples
    {
        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            for (int i = 0; i < edges.Length; i++)
            {
                int u = edges[i][0], v = edges[i][1];
                graph[u].Add(v);
                graph[v].Add(u);
            }


            return DFS(graph, hasApple, new bool[n], 0)[1];
        }

        private int[] DFS(Dictionary<int, List<int>> graph, IList<bool> hasApple, bool[] visited, int current)
        {
            int[] result = new int[2];

            visited[current] = true;
            if (hasApple[current]) result[0] = 1;

            foreach (int i in graph[current])
            {
                if (!visited[i])
                {
                    int[] childResult = DFS(graph, hasApple, visited, i);
                    if (childResult[0] == 1)
                    {
                        result[0] = 1;
                        result[1] = result[1] + childResult[1] + 2;
                    }
                }
            }

            return result;
        }
    }
}
