//using static lab3.List;

namespace lab3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public static int[] tablica = GenerateRandomArray(6);

        public static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10000);
            }

            return array;

        }

        List lista = new List();
        public string wynikListy = "";
        Node? usunieta;


        //wyswietlanie na dole
        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach (int i in tablica)
            {
                lista.AddLast(i);
            }*/
            label1.ForeColor = Color.Black;
            //label1.Text = "";
            //wynikListy = "\0";
            wynikListy = lista.LListToString();
            label1.Text = wynikListy;
            //label1.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNumberBtn_Click(object sender, EventArgs e)
        {
            lista.AddLast((int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usunieta = lista.RemoveLastDiff();
            label5.Text = lista.LListToString();
            label5.Refresh();
            //label5.Text = lista.count.ToString();
            //wynikListy = lista.LListToString();
            //label1.Text = wynikListy;
        }

        private void AddNumberBtnFirst_Click(object sender, EventArgs e)
        {
            lista.AddFirst((int)numericUpDown1.Value);
        }

        private void DelNumberFirst_Click(object sender, EventArgs e)
        {
            usunieta = lista.RemoveFirstDiff();
            label5.Text = lista.LListToString();
            label5.Refresh();
        }
    }

}