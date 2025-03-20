namespace _30_12_2023_DERS_1_FORMLAR
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
            button1 = new Button();
            textBox1 = new TextBox();
            buttonmesajsil = new Button();
            comboBoxIsımler = new ComboBox();
            buttonISIMekle = new Button();
            labelYazılanISIM = new Label();
            buttonLabelDegıstır = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(168, 24);
            button1.Name = "button1";
            button1.Size = new Size(106, 47);
            button1.TabIndex = 0;
            button1.Text = "mesaj yaz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 31);
            textBox1.TabIndex = 1;
            // 
            // buttonmesajsil
            // 
            buttonmesajsil.Location = new Point(306, 24);
            buttonmesajsil.Name = "buttonmesajsil";
            buttonmesajsil.Size = new Size(138, 47);
            buttonmesajsil.TabIndex = 2;
            buttonmesajsil.Text = "sil";
            buttonmesajsil.UseVisualStyleBackColor = true;
            buttonmesajsil.Click += buttonmesajsil_Click;
            // 
            // comboBoxIsımler
            // 
            comboBoxIsımler.FormattingEnabled = true;
            comboBoxIsımler.Items.AddRange(new object[] { "ali veli 49 50", "ayşe kaya", "enes bayram " });
            comboBoxIsımler.Location = new Point(415, 89);
            comboBoxIsımler.Name = "comboBoxIsımler";
            comboBoxIsımler.Size = new Size(294, 33);
            comboBoxIsımler.TabIndex = 3;
            // 
            // buttonISIMekle
            // 
            buttonISIMekle.Location = new Point(484, 32);
            buttonISIMekle.Name = "buttonISIMekle";
            buttonISIMekle.Size = new Size(194, 30);
            buttonISIMekle.TabIndex = 4;
            buttonISIMekle.Text = "ismi komboya ekle";
            buttonISIMekle.UseVisualStyleBackColor = true;
            buttonISIMekle.Click += buttonISIMekle_Click;
            // 
            // labelYazılanISIM
            // 
            labelYazılanISIM.AutoSize = true;
            labelYazılanISIM.BackColor = Color.FromArgb(192, 64, 0);
            labelYazılanISIM.Location = new Point(503, 166);
            labelYazılanISIM.Name = "labelYazılanISIM";
            labelYazılanISIM.Size = new Size(59, 25);
            labelYazılanISIM.TabIndex = 5;
            labelYazılanISIM.Text = "label1";
            // 
            // buttonLabelDegıstır
            // 
            buttonLabelDegıstır.Location = new Point(159, 146);
            buttonLabelDegıstır.Name = "buttonLabelDegıstır";
            buttonLabelDegıstır.Size = new Size(214, 34);
            buttonLabelDegıstır.TabIndex = 6;
            buttonLabelDegıstır.Text = "label değiştir";
            buttonLabelDegıstır.UseVisualStyleBackColor = true;
            buttonLabelDegıstır.Click += buttonLabelDegıstır_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "matematik ", "fizik ", "kimya ", "biyoloji" });
            listBox1.Location = new Point(337, 236);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 129);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonLabelDegıstır);
            Controls.Add(labelYazılanISIM);
            Controls.Add(buttonISIMekle);
            Controls.Add(comboBoxIsımler);
            Controls.Add(buttonmesajsil);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button buttonmesajsil;
        private ComboBox comboBoxIsımler;
        private Button buttonISIMekle;
        private Label labelYazılanISIM;
        private Button buttonLabelDegıstır;
        private ListBox listBox1;
    }
}