using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Graf1
    {
        public List<NodeG1> nodes;
        public List<Edge> edges;
        Graf1(Edge k)
        {
            this.nodes.Add(k.start);
            this.nodes.Add(k.end);
            this.edges.Add(k);
        }
        public void Add(Edge k)
        {
            if(!this.nodes.Contains(k.start))
                this.nodes.Add(k.start);
            if (!this.nodes.Contains(k.end))
                this.nodes.Add(k.end);
            //if(!this.edges.Contains(k))
            edges.Add(k);
        }
        public int IleNowychWezlow(Edge k)
        {
            int wynik = 0;
            if (!this.nodes.Contains(k.start))
                wynik++;
            if (!this.nodes.Contains(k.end))
                wynik++;
            return wynik;
        }
        public void Join(Graf1 g1)
        {
            foreach(Edge e in g1.edges)
            {
                this.Add(e);
            }
        }

        /*public List<Edge> Rozpinajace()
        {
            
        }*/
    }
}
