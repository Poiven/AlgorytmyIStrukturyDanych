namespace lab3
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
            label1 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            AddNumberBtn = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            AddNumberBtnFirst = new Button();
            label6 = new Label();
            DelNumberFirst = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(243, 603);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(243, 500);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(171, 38);
            button1.TabIndex = 1;
            button1.Text = "Wyswietl liste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(243, 223);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 31);
            numericUpDown1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 193);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 25);
            label2.TabIndex = 3;
            label2.Text = "Wpisz liczbę którą dodać do listy";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 578);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "wynik: ";
            // 
            // AddNumberBtn
            // 
            AddNumberBtn.Location = new Point(423, 223);
            AddNumberBtn.Margin = new Padding(4, 5, 4, 5);
            AddNumberBtn.Name = "AddNumberBtn";
            AddNumberBtn.Size = new Size(185, 38);
            AddNumberBtn.TabIndex = 5;
            AddNumberBtn.Text = "dodaj na koniec";
            AddNumberBtn.UseVisualStyleBackColor = true;
            AddNumberBtn.Click += AddNumberBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(763, 223);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 6;
            button2.Text = "usun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(763, 193);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 25);
            label4.TabIndex = 7;
            label4.Text = "usun ostatni element z listy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(763, 414);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // AddNumberBtnFirst
            // 
            AddNumberBtnFirst.Location = new Point(423, 269);
            AddNumberBtnFirst.Name = "AddNumberBtnFirst";
            AddNumberBtnFirst.Size = new Size(185, 34);
            AddNumberBtnFirst.TabIndex = 9;
            AddNumberBtnFirst.Text = "dodaj na początek";
            AddNumberBtnFirst.UseVisualStyleBackColor = true;
            AddNumberBtnFirst.Click += AddNumberBtnFirst_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(763, 266);
            label6.Name = "label6";
            label6.Size = new Size(240, 25);
            label6.TabIndex = 10;
            label6.Text = "usun pierwszy element z listy";
            // 
            // DelNumberFirst
            // 
            DelNumberFirst.Location = new Point(763, 294);
            DelNumberFirst.Name = "DelNumberFirst";
            DelNumberFirst.Size = new Size(112, 34);
            DelNumberFirst.TabIndex = 11;
            DelNumberFirst.Text = "usun pierwszy";
            DelNumberFirst.UseVisualStyleBackColor = true;
            DelNumberFirst.Click += DelNumberFirst_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(DelNumberFirst);
            Controls.Add(label6);
            Controls.Add(AddNumberBtnFirst);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(AddNumberBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private Button AddNumberBtn;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button AddNumberBtnFirst;
        private Label label6;
        private Button DelNumberFirst;
    }
}