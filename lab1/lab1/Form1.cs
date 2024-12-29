using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            int[] tablica = { 2, 1, 5, 154, 16, 3 };
            LabelArray.Text = ZmianaNaStringa(tablica);
            int[] NowaTablica = SortArray(tablica);
            lblHelloWorld.Text = ZmianaNaStringa(NowaTablica);
        }

        public int[] SortArray(int[] NumArray)
        {
            var n = NumArray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (NumArray[j] > NumArray[j + 1])
                    {
                        var tempVar = NumArray[j];
                        NumArray[j] = NumArray[j + 1];
                        NumArray[j + 1] = tempVar;
                    }
            return NumArray;
        }
        public String ZmianaNaStringa(int[] tablica)
        {
            String wynik = "";
            for (int i = 0;i < tablica.Length; i++)
            {
                wynik += tablica[i];
                wynik += " ";
            }
            return wynik;
        } 
    }
}
