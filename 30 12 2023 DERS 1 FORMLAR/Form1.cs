namespace _30_12_2023_DERS_1_FORMLAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ali";

        }

        private void buttonmesajsil_Click(object sender, EventArgs e)
        {
            textBox1.Text = "k";
        }

        private void buttonISIMekle_Click(object sender, EventArgs e)
        {
            comboBoxIsýmler.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }

     /*   private void buttonLabelDegýstýr_Click(object sender, EventArgs e)
        {
            labelYazýlanISIM = textBox1.Text; // bunu düzeltemedik 
        }
     */
        
    }
}