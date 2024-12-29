using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace lab4
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

        public NodeT? Remove(int dane)
        {
            if(this.root==null)
                return null;
            NodeT doUsuniecia = ZnajdzWezel(dane);
            if (doUsuniecia == null)
                return null;
            if(doUsuniecia.lewe == null && doUsuniecia.prawe==null)
            {
                if (doUsuniecia == this.root)
                {
                    root = null;
                    return null;
                }
                else if (doUsuniecia == doUsuniecia.rodzic.lewe)
                {
                    doUsuniecia.rodzic.lewe = null;
                    doUsuniecia.rodzic = null;
                    //return doUsuniecia;
                }
                else
                {
                    doUsuniecia.rodzic.prawe=null;
                    doUsuniecia.rodzic=null;

                }
                return doUsuniecia;
            }
            else if((doUsuniecia.lewe == null) != (doUsuniecia.prawe == null))
            {
                if (doUsuniecia == this.root)
                {
                    if (doUsuniecia.lewe == null)
                    {
                        root = doUsuniecia.prawe;
                        doUsuniecia.prawe.rodzic = null;
                        doUsuniecia.prawe = null;
                    }
                    else
                    {
                        root = doUsuniecia.lewe;
                        doUsuniecia.lewe.rodzic = null;
                        doUsuniecia.lewe = null;
                    }
                    return doUsuniecia;
                }
                else
                {
                    if (doUsuniecia.lewe == null)
                    {
                        if(doUsuniecia.data>doUsuniecia.rodzic.data)
                            doUsuniecia.rodzic.prawe = doUsuniecia.prawe;
                        else
                            doUsuniecia.rodzic.lewe = doUsuniecia.prawe;
                        doUsuniecia.prawe.rodzic = doUsuniecia.rodzic;
                        doUsuniecia.prawe = null;
                        
                        
                    }
                    else
                    {
                        if (doUsuniecia.data > doUsuniecia.rodzic.data)
                            doUsuniecia.rodzic.prawe = doUsuniecia.lewe;
                        else
                            doUsuniecia.rodzic.lewe = doUsuniecia.lewe;
                        doUsuniecia.lewe.rodzic = doUsuniecia.rodzic;
                        doUsuniecia.lewe = null;
                    }
                    doUsuniecia.rodzic = null;
                    //return doUsuniecia;
                }
                return doUsuniecia;
            }
            else
            {
                var zastepca = ZnajdzMin(doUsuniecia.prawe);
                var temp = zastepca.data;
                zastepca = Remove(zastepca.data);
                NodeT zwracana = new NodeT(doUsuniecia.data);
                doUsuniecia.data = temp;
                return zwracana;

            }

        }
        public void RemoveElement0(NodeT n)
        {
            if (n == null)
                return;

            if(this.root == n)
            {
                this.root = null;
            }
            else
            {
                if(n.rodzic.lewe == n)
                {
                    n.rodzic.lewe = null;
                }
                else if(n.rodzic.prawe == n)
                {
                    n.rodzic.prawe = null;
                }
                n.rodzic = null;
            }
        }
        public NodeT RemoveElement1(NodeT n)
        {
            NodeT dziecko = null;
            if(n.lewe != null)
            {
                dziecko = n.lewe;
            }
            else if(n.prawe != null)
            {
                dziecko = n.prawe;
            }
            this.RemoveElement0(dziecko);
            return dziecko;
        }

        public NodeT Min(NodeT n)
        {
            var temp = n;
            while(temp.lewe!=null)
            {
                temp = temp.lewe;
            }
            return temp;
        }


        public void RemoveElement(NodeT n)
        {
            switch(n.LiczbaDzieci())
            {
                case 0:
                    break;
                case 1:
                    //var temp1 = this.Min(n.prawe);
                    var dziecko = this.RemoveElement1(n);
                    var rodzic = n.rodzic;
                    this.RemoveElement0(n);
                    if (rodzic == n)
                        rodzic.PolaczPrawe(dziecko);
                    else
                        rodzic.PolaczLewe(dziecko);
                    break;
                case 2:
                    var temp = this.Min(n.prawe);
                    this.RemoveElement(temp);
                    temp.rodzic = n.rodzic;
                    n.rodzic = null;
                    temp.lewe = n.lewe;
                    n.lewe = null;
                    temp.prawe = n.prawe;
                    n.prawe = null;
                    break;

            }


        }


















        /*public NodeT UsunLisc(NodeT doUsuniecia)
        {
            if (doUsuniecia == this.root)
            {
                root = null;
                return null;
            }
            else if (doUsuniecia == doUsuniecia.rodzic.lewe)
            {
                doUsuniecia.rodzic.lewe = null;
                doUsuniecia.rodzic = null;
                //return doUsuniecia;
            }
            else
            {
                doUsuniecia.rodzic.prawe = null;
                doUsuniecia.rodzic = null;

            }
            return doUsuniecia;
        }*/

        public NodeT ZnajdzWezel(int liczba)
        {
            var temp = this.root;
            while (temp != null)
            {
                if (temp.data > liczba)
                {
                    temp = temp.lewe;
                }
                else if (temp.data < liczba)
                {
                    temp = temp.prawe;
                }
                else
                {
                    return temp;
                }

            }
            return null;
        }

        public NodeT ZnajdzMin(NodeT wezel)
        {
            var temp = wezel;
            while (temp.lewe != null)
            {
                temp = temp.lewe;
            }
            return temp;
        }



        public void CPDPre(NodeT wezel, Label label1)
        {
            if (wezel == null)
                return;
            //pre
            label1.Text += wezel.data + " ";
            CPDPre(wezel.lewe, label1);
            //in

            CPDPre(wezel.prawe, label1);
            //post
        }
        public void CPDIn(NodeT wezel, Label label1)
        {
            if (wezel == null)
                return;
            //pre

            CPDIn(wezel.lewe, label1);
            //in
            label1.Text += wezel.data+" ";
            CPDIn(wezel.prawe, label1);
            //post
        }
        public void CPDPost(NodeT wezel, Label label1)
        {
            if (wezel == null)
                return;
            //pre
            CPDPost(wezel.lewe, label1);
            //in

            CPDPost(wezel.prawe, label1);
            //post
            label1.Text += wezel.data + " ";

        }

    }
}
