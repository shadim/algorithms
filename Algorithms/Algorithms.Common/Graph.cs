using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public class Graph<T>
    {
        private Vertex<T>[] vertexs;
        private bool[,] adjacencyMatrix;
        private int max;
        private int index;

        public Graph(int max)
        {
            this.max = max;
            this.index = 0;
            this.vertexs = new Vertex<T>[max];
            this.adjacencyMatrix = new bool[max, max];

            for (int y = 0; y < max; y++)
            {
                for (int x = 0; x < max; x++)
                {
                    adjacencyMatrix[x, y] = false;
                }
            }
        }

        public Vertex<T> this[int index]
        {
            get
            {
                if (!(index > -1 && index < max))
                    throw new IndexOutOfRangeException();

                return vertexs[index];
            }
        }

        public void AddVertex(Vertex<T> v)
        {
            if (index >= max)
                throw new OutOfMemoryException();

            vertexs[index++] = v;
        }

        public void AddEdge(int start, int end)
        {
            SetAdjacency(start, end, true);
        }

        public void RemoveEdge(int start, int end)
        {
            SetAdjacency(start, end, false);
        }

        private void SetAdjacency(int start, int end, bool p)
        {
            if (!(start > -1 && start < max) || !(end > -1 && end < max))
                throw new IndexOutOfRangeException();

            adjacencyMatrix[start, end] = p;
            adjacencyMatrix[end, start] = p;
        }

        public Vertex<T> getUnvisitedChildNode(Vertex<T> n)
        {
            int i = 0;
            for (; i < max; i++)
            {
                if (vertexs[i] == n)
                    break;
            }

            for (int j = 0; j < max; j++)
            {
                if (adjacencyMatrix[i, j] == true && vertexs[j].isVisited == false)
                    return vertexs[j];
            }
            return null;
        }
    }
}
