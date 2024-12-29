using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Bst
    {
        public NodeT? root;


        public NodeT SzukajRodzica(NodeT dziecko)
        {
            var tmp = this.root;
            while (true)
            {
                if (tmp.data > dziecko.data)
                {
                    if (tmp.lewe == null)
                        return tmp;
                    else
                    {
                        tmp = tmp.lewe;
                    }
                }
                else
                {
                    if (tmp.prawe == null)
                        return tmp;
                    else
                        tmp = tmp.prawe;
                }
            }
        }

        public void Add(int liczba)
        {
            NodeT dziecko = new NodeT(liczba);

            if (this.root == null)
            {
                root = dziecko;
                return;
            }
            //NodeT? obecny = root;
            var rodzic = this.SzukajRodzica(dziecko);

            

            dziecko.rodzic = rodzic;
            if (dziecko.data < rodzic.data)
            {

                rodzic.lewe = dziecko;
            }
            else
            {
                rodzic.prawe = dziecko;
            }
        }
    }
}
