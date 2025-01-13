using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodowanieHuffmana
{
    public class NodeG
    {
        public NodeG lewe;
        public NodeG prawa;
        public NodeG rodzic;
        public int data; //czestosc

        public NodeG(int data)
        {
            this.data = data;
        }
        public NodeG()
        {

        }
    }
    public class CompareNodeG : IComparer<NodeG>
    {
        public int Compare(NodeG x, NodeG y)
        {
            int wynik = x.data.CompareTo(y.data);
            if(wynik == 0)
            {
                if (x.GetType() == y.GetType()) return 0;
                else if (x is NodeGS) return -1;
                else return 1;
            }
            return wynik;
        }
    }
}
