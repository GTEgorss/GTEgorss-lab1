import java.util.LinkedList;
import java.util.Queue;

class Graph {
    private int V;

    private LinkedList<Integer>[] adj;
    private Queue<Integer> queue;

    public Graph(int v) {
        V = v;
        adj = new LinkedList[v];
        for (int i = 0; i < v; ++i) {
            adj[i] = new LinkedList<>();
        }
        queue = new LinkedList<>();
    }

    public void addEdge(int v, int w) {
        adj[v].add(w);
    }


    private void DFSUtil(int vertex, boolean nodes[]) {

        nodes[vertex] = true;
        int a;

        for (int i = 0; i < adj[vertex].size(); ++i) {
            a = adj[vertex].get(i);
            if (!nodes[a]) {
                DFSUtil(a, nodes);
            }
        }
    }

    public void DFS(int v) {
        boolean already[] = new boolean[V];
        DFSUtil(v, already);
    }

    public void BFS(int n) {

        boolean nodes[] = new boolean[V];
        int a;

        nodes[n] = true;
        queue.add(n);

        while (queue.size() != 0) {
            n = queue.poll();
            System.out.print(n + " ");

            for (int i = 0; i < adj[n].size(); ++i) {
                a = adj[n].get(i);
                if (!nodes[a]) {
                    nodes[a] = true;
                    queue.add(a);
                }
            }
        }
    }
}

