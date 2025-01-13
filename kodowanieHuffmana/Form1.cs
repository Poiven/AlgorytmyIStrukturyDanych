using System.Xml.Linq;

namespace kodowanieHuffmana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        int zmienna;
        string tekst;

        private void button1_Click(object sender, EventArgs e)
        {
            tekst = textBox1.Text;
            /*Dictionary<char, int> testowy= new Dictionary<char, int>();
            testowy['a'] = 5;
            testowy['b'] = 9;
            testowy['c'] = 12;
            testowy['d'] = 13;
            testowy['e'] = 16;
            testowy['f'] = 45;
            */

            var koncowy = czestosc(tekst);
            var tesowaLista = TworzenieListy(koncowy);
            var zakodowane = new Dictionary<char, string>();
            zakodowane = Kodowanie(tesowaLista);


        }
        public Dictionary<char,int> czestosc(string teskt)
        {
            var slownikCzestosci = new Dictionary<char, int>();

            foreach(var litera in teskt)
            {
                if (slownikCzestosci.ContainsKey(litera))
                {
                    slownikCzestosci[litera]++;
                }
                else
                {
                    slownikCzestosci[litera] = 1;
                }
            }
            return slownikCzestosci;
        }
        public void wglab(NodeG n, string kod, Dictionary<char, string> slownik)
        {
            if(n == null) return;
            if (n.GetType() == typeof(NodeGS))
            {
                NodeGS nowe = (NodeGS)n;
                slownik[nowe.symbol] = kod;
            }
            wglab(n.lewe, kod + "0", slownik);
            wglab(n.prawa, kod + "1", slownik);
            
        }
        public List<NodeG> TworzenieListy(Dictionary<char, int> slownik)
        {
            var lista = new List<NodeG>();
            foreach(var litera in slownik)
            {
                //char c = litera.Key;
                lista.Add(new NodeGS(litera.Key, litera.Value));
            }
            return lista;
        }
        public void sortowanieListy(List<NodeG> lista)
        {
            lista = lista.OrderBy(n=>n.data).ThenBy(n=>n.GetType()==typeof(NodeGS)?0:1).ToList();
        }

        public Dictionary<char, string> Kodowanie(List<NodeG> lista)
        {
            //NodeGS lewyNode, prawyNode, topNode;
            //sortowanieListy(lista);
            lista.Sort(new CompareNodeG());
            while (lista.Count != 1) 
            {
                NodeG top = new NodeG(lista[0].data+lista[1].data);
                top.lewe = lista[0];
                top.prawa = lista[1];
                lista.Add(top);
                lista.RemoveAt(1);
                lista.RemoveAt(0);
                //sortowanieListy(lista);
                lista.Sort(new CompareNodeG());
            }
            Dictionary<char,string> wynik = new Dictionary<char,string>();
            wglab(lista[0], "", wynik);
            return wynik;
        }
        



    }
}