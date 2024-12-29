namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bst drzewo = new Bst();
        //drzewo.add();


        private void button1_Click(object sender, EventArgs e)
        {
            drzewo.Add((int)numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            drzewo.CPDPre(drzewo.root, label1);
            drzewo.CPDIn(drzewo.root, label2);
            drzewo.CPDPost(drzewo.root, label3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            drzewo.Remove((int)numericUpDown2.Value);
        }
    }
}