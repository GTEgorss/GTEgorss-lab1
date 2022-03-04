using System;
using System.Collections.Generic;

namespace Csharp_3
{
    public class Graph
    {
        private int Vertices;
        
        private List<Int32>[] adj;
        
        public Graph(int v)
        {
            Vertices = v;
            adj = new List<Int32>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }
        }
        
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        
        public void BFS(int s)
        {
            bool[] visited = new bool[Vertices];
            
            Queue<int> queue = new();
            visited[s] = true;
            queue.Enqueue(s);
            
            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.WriteLine("next->" + s);
                
                foreach (Int32 next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }
        
        public void DFS(int s)
        {
            bool[] visited = new bool[Vertices];
            
            Stack<int> stack = new();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
    }
}
