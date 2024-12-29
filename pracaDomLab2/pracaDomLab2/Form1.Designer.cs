namespace pracaDomLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bubbleSort = new Button();
            mergeSort = new Button();
            insertSort = new Button();
            quickSort = new Button();
            countingSort = new Button();
            GenerowanieLiczb = new Button();
            showArray = new Label();
            numericUpDown1 = new NumericUpDown();
            WynikLabel = new Label();
            Timelabel = new Label();
            SelectionSortBtn = new Button();
            textBox1 = new TextBox();
            TxtBToArrayBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // bubbleSort
            // 
            bubbleSort.Location = new Point(200, 652);
            bubbleSort.Margin = new Padding(4, 5, 4, 5);
            bubbleSort.Name = "bubbleSort";
            bubbleSort.Size = new Size(107, 38);
            bubbleSort.TabIndex = 0;
            bubbleSort.Text = "bubble sort";
            bubbleSort.UseVisualStyleBackColor = true;
            bubbleSort.Click += bubbleSort_Click;
            // 
            // mergeSort
            // 
            mergeSort.Location = new Point(316, 652);
            mergeSort.Margin = new Padding(4, 5, 4, 5);
            mergeSort.Name = "mergeSort";
            mergeSort.Size = new Size(107, 38);
            mergeSort.TabIndex = 1;
            mergeSort.Text = "merge sort";
            mergeSort.UseVisualStyleBackColor = true;
            mergeSort.Click += mergeSort_Click;
            // 
            // insertSort
            // 
            insertSort.Location = new Point(431, 652);
            insertSort.Margin = new Padding(4, 5, 4, 5);
            insertSort.Name = "insertSort";
            insertSort.Size = new Size(130, 38);
            insertSort.TabIndex = 2;
            insertSort.Text = "insertion sort";
            insertSort.UseVisualStyleBackColor = true;
            insertSort.Click += insertSort_Click;
            // 
            // quickSort
            // 
            quickSort.Location = new Point(570, 652);
            quickSort.Margin = new Padding(4, 5, 4, 5);
            quickSort.Name = "quickSort";
            quickSort.Size = new Size(107, 38);
            quickSort.TabIndex = 3;
            quickSort.Text = "quick sort";
            quickSort.UseVisualStyleBackColor = true;
            quickSort.Click += quickSort_Click;
            // 
            // countingSort
            // 
            countingSort.Location = new Point(686, 652);
            countingSort.Margin = new Padding(4, 5, 4, 5);
            countingSort.Name = "countingSort";
            countingSort.Size = new Size(134, 38);
            countingSort.TabIndex = 4;
            countingSort.Text = "counting sort";
            countingSort.UseVisualStyleBackColor = true;
            countingSort.Click += countingSort_Click;
            // 
            // GenerowanieLiczb
            // 
            GenerowanieLiczb.Location = new Point(209, 208);
            GenerowanieLiczb.Margin = new Padding(4, 5, 4, 5);
            GenerowanieLiczb.Name = "GenerowanieLiczb";
            GenerowanieLiczb.Size = new Size(214, 38);
            GenerowanieLiczb.TabIndex = 5;
            GenerowanieLiczb.Text = "generuj liczby";
            GenerowanieLiczb.UseVisualStyleBackColor = true;
            GenerowanieLiczb.Click += GenerowanieLiczb_Click;
            // 
            // showArray
            // 
            showArray.AutoSize = true;
            showArray.Location = new Point(200, 178);
            showArray.Margin = new Padding(4, 0, 4, 0);
            showArray.Name = "showArray";
            showArray.Size = new Size(223, 25);
            showArray.TabIndex = 6;
            showArray.Text = "tu będą wyświetlone liczby";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(431, 212);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 31);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // WynikLabel
            // 
            WynikLabel.AutoSize = true;
            WynikLabel.ForeColor = SystemColors.Menu;
            WynikLabel.Location = new Point(106, 447);
            WynikLabel.Margin = new Padding(4, 0, 4, 0);
            WynikLabel.Name = "WynikLabel";
            WynikLabel.Size = new Size(59, 25);
            WynikLabel.TabIndex = 8;
            WynikLabel.Text = "label1";
            // 
            // Timelabel
            // 
            Timelabel.AutoSize = true;
            Timelabel.Location = new Point(106, 535);
            Timelabel.Margin = new Padding(4, 0, 4, 0);
            Timelabel.Name = "Timelabel";
            Timelabel.Size = new Size(163, 25);
            Timelabel.TabIndex = 9;
            Timelabel.Text = "Czas wykonania to:";
            // 
            // SelectionSortBtn
            // 
            SelectionSortBtn.Location = new Point(827, 652);
            SelectionSortBtn.Name = "SelectionSortBtn";
            SelectionSortBtn.Size = new Size(143, 38);
            SelectionSortBtn.TabIndex = 10;
            SelectionSortBtn.Text = "selection sort";
            SelectionSortBtn.UseVisualStyleBackColor = true;
            SelectionSortBtn.Click += SelectionSortBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 346);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 31);
            textBox1.TabIndex = 11;
            // 
            // TxtBToArrayBtn
            // 
            TxtBToArrayBtn.Location = new Point(608, 346);
            TxtBToArrayBtn.Name = "TxtBToArrayBtn";
            TxtBToArrayBtn.Size = new Size(161, 34);
            TxtBToArrayBtn.TabIndex = 12;
            TxtBToArrayBtn.Text = "zamień na tablice";
            TxtBToArrayBtn.UseVisualStyleBackColor = true;
            TxtBToArrayBtn.Click += TxtBToArrayBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(TxtBToArrayBtn);
            Controls.Add(textBox1);
            Controls.Add(SelectionSortBtn);
            Controls.Add(Timelabel);
            Controls.Add(WynikLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(showArray);
            Controls.Add(GenerowanieLiczb);
            Controls.Add(countingSort);
            Controls.Add(quickSort);
            Controls.Add(insertSort);
            Controls.Add(mergeSort);
            Controls.Add(bubbleSort);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bubbleSort;
        private Button mergeSort;
        private Button insertSort;
        private Button quickSort;
        private Button countingSort;
        private Button GenerowanieLiczb;
        private Label showArray;
        private NumericUpDown numericUpDown1;
        private Label WynikLabel;
        private Label Timelabel;
        private Button SelectionSortBtn;
        private TextBox textBox1;
        private Button TxtBToArrayBtn;
    }
}
