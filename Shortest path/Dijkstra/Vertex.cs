using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra
{
    class Vertex
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public Vertex(int x,int y,string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
