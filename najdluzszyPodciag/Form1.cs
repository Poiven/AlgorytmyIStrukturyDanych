namespace najdluzszyPodciag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            



        }
        string tekst = " abaabbaaa";
        string kolumna = " babab";

        private void button1_Click(object sender, EventArgs e)
        {


            int[,] tab = new int[tekst.Length, kolumna.Length];
            for (int i = 1; i < tekst.Length; i++)
            {
                for (int j = 1; j < kolumna.Length; j++)
                {
                    if (tekst[i] == kolumna[j])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                        tab[i, j] = tab[i - 1, j] >= tab[i, j - 1] ? tab[i - 1, j] : tab[i, j - 1];
                }
            }

            for(int i = tekst.Length-1; i > 0; i++)
            {
                for (int j = kolumna.Length - 1; j > 0; j++)
                {
                    /*if (tekst[i] != kolumna[j])
                    {
                        continue;
                    }*/
                }
            }

        }
    }
}