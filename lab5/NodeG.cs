using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class NodeG
    {
        public List <NodeG> sasiedzi = new List <NodeG> ();
        public int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        public void Polacz(NodeG drugi)
        {
            this.sasiedzi.Add (drugi);
            drugi.sasiedzi.Add(this);
        }
    }
}
