namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var a = new NodeG(1);
            var b = new NodeG(2);
            var c = new NodeG(7);
            var d = new NodeG(3);
            var e = new NodeG(4);
            var f = new NodeG(6);
            var g = new NodeG(5);
            var graf1 = new Graf();

            //a.sasiedzi.Add(b);
            //a.sasiedzi.Add(c);

            //b.sasiedzi.Add(a);
            //b.sasiedzi.Add(d);
            //b.sasiedzi.Add(e);

            //c.sasiedzi.Add(a);
            //c.sasiedzi.Add(d);
            //c.sasiedzi.Add(f);

            //d.sasiedzi.Add(b);
            //d.sasiedzi.Add(c);
            //d.sasiedzi.Add(f);

            //e.sasiedzi.Add(b);
            //e.sasiedzi.Add(f);

            //f.sasiedzi.Add(c);
            //f.sasiedzi.Add(d);
            //f.sasiedzi.Add(e);
            //f.sasiedzi.Add(g);

            //g.sasiedzi.Add(f);

            //graf1.nodes.Add(a);
            //graf1.nodes.Add(b);
            //graf1.nodes.Add(c);
            //graf1.nodes.Add(d);
            //graf1.nodes.Add(e);
            //graf1.nodes.Add(f);
            //graf1.nodes.Add(g);
            
            // z uzyciem funkcji
            a.Polacz(b);
            a.Polacz(c);

            b.Polacz(d);
            b.Polacz(e);

            c.Polacz(d);
            c.Polacz(f);

            d.Polacz(f);

            e.Polacz(f);

            f.Polacz(g);
            
            var graf2 = graf1.Wszerz(a);

            label1.Text = "bfs: ";
            label1.Text += string.Join(" ", graf2);
            
            var graf3 = graf1.Wglab2(a);
            label2.Text = "wglab: ";
            label2.Text += string.Join(" ",graf3);
            
            /*
            label2.Text += graf3[0].data;
            */

        }
    }
}
