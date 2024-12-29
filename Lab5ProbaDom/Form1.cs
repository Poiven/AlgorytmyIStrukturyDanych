using lab5;

namespace Lab5ProbaDom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            /*
            var a = new NodeG(1);
            var b = new NodeG(2);
            var c = new NodeG(7);
            var d = new NodeG(3);
            var e = new NodeG(4);
            var f = new NodeG(6);
            var g = new NodeG(5);
            var graf1 = new Graf();
            */

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
            /*
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
            */
            /*
            label2.Text += graf3[0].data;
            */

            var a = new NodeG1(0);
            var b = new NodeG1(1);
            var c = new NodeG1(2);
            var d = new NodeG1(3);
            var e = new NodeG1(4);
            var f = new NodeG1(5);
            var g = new NodeG1(6);
            var h = new NodeG1(7);


            var ed46 = new Edge(e, g, 1);

            var ed45 = new Edge(e, f, 2);

            var ed06 = new Edge(a, g, 3);
            var ed27 = new Edge(c, h, 3);

            var ed24 = new Edge(c, e, 4);

            var ed01 = new Edge(a, b, 5);
            var ed26 = new Edge(c, g, 5);


            var ed15 = new Edge(b, f, 6);
            var ed56 = new Edge(f, g, 6);

            var ed17 = new Edge(b, h, 7);

            var ed14 = new Edge(b, e, 8);
            var ed36 = new Edge(d, g, 8);


            var ed12 = new Edge(b, c, 9);
            var ed03 = new Edge(a, d, 9);
            var ed23 = new Edge(c, d, 9);
            var ed67 = new Edge(g, h, 9);




            var grafDoTestow = new Graf1(ed46);

            //grafDoTestow.Add(ed46);
            grafDoTestow.Add(ed45);
            grafDoTestow.Add(ed06);
            grafDoTestow.Add(ed27);
            grafDoTestow.Add(ed24);
            grafDoTestow.Add(ed01);
            grafDoTestow.Add(ed26);
            grafDoTestow.Add(ed15);
            grafDoTestow.Add(ed56);
            grafDoTestow.Add(ed17);
            grafDoTestow.Add(ed14);
            grafDoTestow.Add(ed36);
            grafDoTestow.Add(ed12);
            grafDoTestow.Add(ed03);
            grafDoTestow.Add(ed23);
            grafDoTestow.Add(ed67);


            List<Edge> wynikRozpinajacego = grafDoTestow.Rozpinajace();



            int nowaZmienna = 0;




        }
    }
}
