public class Solution
{
    public int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        UnionFind alice = new(n);
        UnionFind bob = new(n);

        for (int i = 0; i < edges.Length; i++)
        {
            int[] edge = edges[i];
            if (edge[0] == 3)
            {
                alice.Union(edge[1], edge[2]);
                bob.Union(edge[1], edge[2]);
            }
        }
        int result = alice.redundant;
        alice.redundant = 0;
        bob.redundant = 0;

        for (int i = 0; i < edges.Length; i++)
        {
            int[] edge = edges[i];
            int type = edge[0];
            int u = edge[1];
            int v = edge[2];
            if (type == 1)
            {
                alice.Union(u, v);
            }
            if (type == 2)
            {
                bob.Union(u, v);
            }
        }

        if (alice.GetComponentCount() != 1 || bob.GetComponentCount() != 1)
        {
            return -1;
        }
        return result + alice.redundant + bob.redundant;
    }

    public class UnionFind
    {
        int[] parent;
        public int redundant = 0;
        
        public int GetComponentCount()
        {
            int componentCount = 1;
            for (int i = 1; i < parent.Length; i++)
            {
                int parent = Find(i);
                componentCount += parent == 1 ? 0 : 1;
            }

            return componentCount;
        }

        public UnionFind(int n)
        {
            parent = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                parent[i] = i;
            }
        }

        public int Find(int a)
        {
            if (parent[a] == a)
            {
                return parent[a];
            }

            int result = Find(parent[a]);
            parent[a] = result;
            return result;
        }

        public void Union(int a, int b)
        {
            int aParent = Find(a);
            int bParent = Find(b);
            if (aParent == bParent)
            {
                redundant++;
                return;
            }
            if (aParent < bParent)
            {
                parent[bParent] = aParent;
                return;
            }

            parent[aParent] = bParent;
        }
    }
}