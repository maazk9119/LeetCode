namespace MySolutions._1519.NumberOfNodesInATreeWithSameLabel
{
    internal class TreeSameLabel
    {
        private const int alphabetsNum = 26;

        public int[] CountSubTrees(int n, int[][] edges, string labels)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            foreach (var edge in edges)
            {
                int u = edge[0], v = edge[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }

            int[] result = new int[n];
            DFS(graph, result, 0, labels);

            return result;
        }

        public int[] DFS(Dictionary<int, List<int>> graph, int[] result, int node, string labels)
        {
            int[] alphabetsFrequency = new int[alphabetsNum];
            result[node] = 1;

            foreach (var n in graph[node])
            {
                if (result[n] == 0)
                {
                    var childAlpaFreq = DFS(graph, result, n, labels);
                    for (int i = 0; i < 26; i++)
                    {
                        alphabetsFrequency[i] = alphabetsFrequency[i] + childAlpaFreq[i];
                    }
                }
            }

            alphabetsFrequency[labels[node] - 'a']++;
            result[node] = alphabetsFrequency[labels[node] - 'a'];

            return alphabetsFrequency;
        }
    }
}
