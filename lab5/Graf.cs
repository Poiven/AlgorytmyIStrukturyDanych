using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Graf
    {
        public List<NodeG> nodes = new List<NodeG>();


        public List<NodeG> Wszerz(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>() { start };
            for (int i = 0; i < odwiedzone.Count; i++)
            {
                var tmp = odwiedzone[i];
                for (int j = 0; j < tmp.sasiedzi.Count; j++)
                {
                    if (!odwiedzone.Contains(tmp.sasiedzi[j]))
                        odwiedzone.Add(tmp.sasiedzi[j]);
                }

            }
            return odwiedzone;
        }

        public List<NodeG> Wglab(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
            Stack<NodeG> stos = new Stack<NodeG>();
            stos.Push(start);

            while (stos.Count > 0)
            {
                NodeG node = stos.Pop();
                if (!odwiedzone.Contains(node))
                {
                    odwiedzone.Add(node);
                    foreach (var sasiad in node.sasiedzi)
                    {
                        if (!odwiedzone.Contains(sasiad))
                        {
                            stos.Push(sasiad);
                        }
                    }
                }
            }
            return odwiedzone;
        }

        public List<NodeG> Wglab2(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
            WglabRekurencja(start, odwiedzone);
            return odwiedzone;
        }

        public void WglabRekurencja(NodeG node, List<NodeG> odwiedzone)
        {
            if (!odwiedzone.Contains(node))
            {
                odwiedzone.Add(node);
                foreach (var sasiad in node.sasiedzi)
                {
                    WglabRekurencja(sasiad, odwiedzone);
                }
            }
        }


    }

    
}
