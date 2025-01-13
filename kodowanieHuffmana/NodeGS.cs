using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodowanieHuffmana
{
    public class NodeGS:NodeG
    {
        public char symbol;
        public NodeGS(char symbol, int data)
        {
            this.symbol = symbol;
            this.data = data;
        }
    }
}
