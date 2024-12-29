using System.Diagnostics;

namespace pracaDomLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static int rozmiarTablicy = 0;
        static int[] tablica = new int[rozmiarTablicy];
        static int[] posotrowanaTablica = new int[rozmiarTablicy];

        private void bubbleSort_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            posotrowanaTablica = BubbleSort(tablica);
            watch.Stop();
            WynikLabel.Text = DoStringaDziesiec(posotrowanaTablica);
            ChangeLabelOpacity();
            TimeSpan ts = watch.Elapsed;
            Timelabel.Text = ts.TotalMilliseconds.ToString() + " ms";
        }

        private void mergeSort_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            posotrowanaTablica = MergeSort(tablica, 0, tablica.Length - 1);
            watch.Stop();
            WynikLabel.Text = DoStringaDziesiec(posotrowanaTablica);
            //WynikLabel.Text = string.Join(", ", posotrowanaTablica);
            ChangeLabelOpacity();
            TimeSpan ts = watch.Elapsed;
            Timelabel.Text = ts.TotalMilliseconds.ToString() + " ms";
        }

        private void insertSort_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            posotrowanaTablica = InsertSort(tablica);
            watch.Stop();
            WynikLabel.Text = DoStringaDziesiec(posotrowanaTablica);
            //WynikLabel.Text = string.Join(", ", posotrowanaTablica);
            ChangeLabelOpacity();
            TimeSpan ts = watch.Elapsed;
            Timelabel.Text = ts.TotalMilliseconds.ToString() + " ms";
        }

        private void quickSort_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            posotrowanaTablica = QuickSort(tablica);
            watch.Stop();
            WynikLabel.Text = DoStringaDziesiec(posotrowanaTablica);
            //WynikLabel.Text = string.Join(", ", posotrowanaTablica);
            ChangeLabelOpacity();
            TimeSpan ts = watch.Elapsed;
            Timelabel.Text = ts.TotalMilliseconds.ToString() + " ms";
        }

        private void countingSort_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            posotrowanaTablica = CountingSort(tablica);
            watch.Stop();
            //WynikLabel.Text = string.Join(", ", posotrowanaTablica);
            WynikLabel.Text = DoStringaDziesiec(posotrowanaTablica);
            ChangeLabelOpacity();
            TimeSpan ts = watch.Elapsed;
            Timelabel.Text = ts.TotalMilliseconds.ToString() + " ms";
        }
        private void SelectionSortBtn_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            posotrowanaTablica = SelectionSort(tablica);
            watch.Stop();
            //WynikLabel.Text = string.Join(", ", posotrowanaTablica);
            WynikLabel.Text = DoStringaDziesiec(posotrowanaTablica);
            ChangeLabelOpacity();
            TimeSpan ts = watch.Elapsed;
            Timelabel.Text = ts.TotalMilliseconds.ToString() + " ms";
        }


        public static int[] ConvertToIntArray(string input)
        {
            return input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        public int[] InsertSort(int[] array)
        {
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                int j = i;
                int temp = array[j];
                while (j > 0 && array[j - 1] > array[j])
                {
                    temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
            return array;

        }
        public String DoStringaDziesiec(int[] array)
        {
            String wynik = "";
            if (array.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    wynik += array[i];
                    wynik += ", ";
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    wynik += array[i];
                    wynik += ", ";
                }
            }
            wynik += "...";
            return wynik;
        }

        public int[] BubbleSort(int[] NumArray)
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
        public int[] InsertionSortDiff(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int current = data[i];
                int j = i - 1;

                while (j >= 0 && data[j] > current)
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                }

                data[j + 1] = current;
            }
            return data;
        }
        
        public int[] MergeSort(int[] T, int p, int r)
        {
            if (p < r)
            {
                int q = (p + (r - 1)) / 2 + 1;
                MergeSort(T, p, q - 1);
                MergeSort(T, q, r);
                Scalanie(T, p, q, r);
            }
            return T;
        }
        public void Scalanie(int[] T, int p, int q, int r)
        {
            int leftAL = q - p;
            int rightAL = r - q + 1;

            int i, j, k;

            int[] left = new int[leftAL];
            int[] right = new int[rightAL];

            for (i = 0; i < leftAL; i++)
            {
                left[i] = T[p + i];
            }

            for (j = 0; j < rightAL; j++)
            {
                right[j] = T[q + j];
            }

            i = 0;
            j = 0;
            k = p;

            while (i < leftAL && j < rightAL)
            {
                if (left[i] <= right[j])
                {
                    T[k++] = left[i++];
                }
                else
                {
                    T[k++] = right[j++];
                }
            }

            if (i == leftAL)
            {
                for (int ii = j; ii < rightAL; ii++)
                {
                    T[k++] = right[ii];
                }
            }
            if (j == rightAL)
            {
                for (int ii = i; ii < leftAL; ii++)
                {
                    T[k++] = left[ii];
                }
            }
        }











        // quick sort
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void QuickSortAlg(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int IndexPivotu = Partition(arr, low, high);
                QuickSortAlg(arr, low, IndexPivotu - 1);
                QuickSortAlg(arr, IndexPivotu + 1, high);
            }
        }
        public int[] QuickSort(int[] array)
        {
            QuickSortAlg(array, 0, array.Length - 1);
            return array;
        }

        //
        // generowanie losowej tablicy
        public static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10000); // Generuje losow¹ liczbê ca³kowit¹
            }

            return array;
        }

        //selection sort
        public static int[] SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Zamiana elementów
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }


        //counting sort
        public static int GetMaxVal(int[] array, int size)
        {
            var maxVal = array[0];
            for (int i = 1; i < size; i++)
                if (array[i] > maxVal)
                    maxVal = array[i];
            return maxVal;
        }
        public int[] CountingSort(int[] array)
        {
            var size = array.Length;
            var maxElement = GetMaxVal(array, size);
            var occurrences = new int[maxElement + 1];
            for (int i = 0; i < maxElement + 1; i++)
            {
                occurrences[i] = 0;
            }
            for (int i = 0; i < size; i++)
            {
                occurrences[array[i]]++;
            }
            for (int i = 0, j = 0; i <= maxElement; i++)
            {
                while (occurrences[i] > 0)
                {
                    array[j] = i;
                    j++;
                    occurrences[i]--;
                }
            }
            return array;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerowanieLiczb_Click(object sender, EventArgs e)
        {


            rozmiarTablicy = (int)numericUpDown1.Value;
            tablica = new int[rozmiarTablicy];
            tablica = GenerateRandomArray(rozmiarTablicy);
            showArray.Text = string.Join(", ", tablica);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void ChangeLabelOpacity()
        {
            WynikLabel.ForeColor = Color.Black;
        }

        private void TxtBToArrayBtn_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            
            rozmiarTablicy = ConvertToIntArray(tekst).Length;
            tablica = new int[rozmiarTablicy];
            tablica = ConvertToIntArray(tekst);

        }
    }
}
