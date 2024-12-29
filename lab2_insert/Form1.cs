namespace lab2_insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 10, 5, 8, 7, 2, 1 };
            label1.Text = DoStringa(InsertSort(array));
            
        }
        public int[] InsertSort(int[] array)
        {
            int length = array.Length;
            for(int i=1; i<length; i++)
            {
                int j = i;
                int temp = array[j];
                while (j > 0 && array[j - 1] > array[j])
                {
                    temp = array[j-1];
                    array[j-1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
            return array;

        }
        public String DoStringa(int[] array)
        {
            String wynik = "";
            for(int i=0; i<array.Length; i++)
            {
                wynik+=array[i];
            }
            return wynik;
        }
        
    }
}