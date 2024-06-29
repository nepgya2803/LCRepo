public class Solution {
    public void DFS (int u, int current, int[][] edges, List<HashSet<int>> tempResult)
    {
        for(int i = 0; i<edges.Length; i++)
        {
            if(edges[i][0] == current && !tempResult[edges[i][1]].Contains(u))
            {
                tempResult[edges[i][1]].Add(u);
                DFS(u, edges[i][1], edges, tempResult);
            }
        }
    }
    public IList<IList<int>> GetAncestors(int n, int[][] edges) {
        List<HashSet<int>> tempResult = new List<HashSet<int>>();
        List<IList<int>> result = new List<IList<int>>();
        for(int i = 0; i<n; i++)
        {
            tempResult.Add(new HashSet<int>());
        }
        for(int i = 0; i<n; i++)
        {
            DFS(i, i, edges, tempResult);
        }
        for(int i = 0; i<n; i++)
        {
            result.Add(tempResult[i].ToList());
        }
        return result;
    }
}