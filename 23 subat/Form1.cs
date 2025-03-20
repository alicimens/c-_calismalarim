namespace _23_subat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        int faktoriyel = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 6; i++)
            {
                faktoriyel = faktoriyel * i;
                listBox1.Items.Add(faktoriyel);
                label1.Text = faktoriyel.ToString();
            }

        }
    }
}