using System;
using System.Collections.Generic;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex[] vertexArray = new Vertex[]{
                new Vertex(5, 3, "Vertex A") ,
                new Vertex(8, 9, "Vertex B") ,
                new Vertex(1, 7, "Vertex C") ,
                new Vertex(14, 2,"Vertex D") };
            //  A  B  C  D
            int[,] graph = new int[,] {{ 0, 4, 0, 0 },
                                       { 4, 0, 5, 8 },
                                       { 0, 4, 0, 2 },
                                       { 0, 8, 2, 0 }};


            const int START = 0; // The index of the vertex who will be used 
            const int END = 4; // The index of the vertex we are looking for 
            int numberOfVertex = vertexArray.Length;


            int[] minimumWeight = new int[numberOfVertex];
            Vertex[] precursor = new Vertex[numberOfVertex];

            List<Vertex> hasNotBeenVisited = new List<Vertex>();
            hasNotBeenVisited.AddRange(vertexArray);

           
            for (int i = 0; i < numberOfVertex; i++)
            {
                minimumWeight[i] = int.MaxValue;
                precursor[i] = null;
            }
            minimumWeight[START] = 0;



           
        }
    }
}


