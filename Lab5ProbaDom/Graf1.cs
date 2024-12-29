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
        public Graf1() { }
        public Graf1(Edge k)
        {
            nodes = new List<NodeG1>();
            edges = new List<Edge>();

            this.nodes.Add(k.start);
            this.nodes.Add(k.end);
            this.edges.Add(k);
        }
        public void Add(Edge k)
        {
            if (this.nodes != null || this.edges != null)
            {
                if (!this.nodes.Contains(k.start))
                    this.nodes.Add(k.start);
                if (!this.nodes.Contains(k.end))
                    this.nodes.Add(k.end);
                if (!this.edges.Contains(k))
                    edges.Add(k);
            }else if(this.edges == null || this.nodes == null)
            {
                this.edges.Add(k);
                this.nodes.Add(k.start);
                this.nodes.Add(k.end);
            }
        }
        public int IleNowychWezlow(Edge k)
        {
            int wynik = 0;
            if (this.nodes != null)
            {
                if (!this.nodes.Contains(k.start))
                    wynik++;
                if (!this.nodes.Contains(k.end))
                    wynik++;
                return wynik;
            }
            else {
                return 2;
            }
        }
        public void Join(Graf1 g1)
        {
            foreach(Edge e in g1.edges)
            {
                this.Add(e);
            }
        }

        public List<Edge> Rozpinajace()
        {
            List<Edge> orderedEdges = this.edges.OrderBy(o=>o.weight).ToList();
            List<Edge> wynik = new List<Edge>();
            Graf1 nowyGraf = new Graf1(orderedEdges[0]);
            //wynik.Add(orderedEdges[0]);
            foreach (Edge e in orderedEdges)
            {
                Graf1 temp = nowyGraf;
                if (nowyGraf.IleNowychWezlow(e) == 0)
                {
                    temp.Add(e);
                    if (temp.nodes.Count - temp.edges.Count == 1)
                    {
                        nowyGraf.Add(e);
                        wynik.Add(e);
                    }

                }
                else if (nowyGraf.IleNowychWezlow(e) > 0)
                {    
                    nowyGraf.Add(e);
                    wynik.Add(e);
                }
            }            
            return wynik;
        }
    }
}
