namespace alarm_kuralım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

            if (label2.Text == comboBox2.Text)
            {
                timer1.Enabled=false;
                MessageBox.Show("kalk piç");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);

            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i);

            }
        }
    }
}