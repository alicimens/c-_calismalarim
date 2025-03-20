namespace bilgiyarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorudegiskeni = 0;
        int dogru = 0;
        int yanlis = 0;
        int sure = 20;
        private void button5_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            sure = 20;

            button5.Text = "ÝLERÝ";
            sorudegiskeni++;
            label2.Text = sorudegiskeni.ToString();

            button1.Enabled = true; // ileri dedikten sonra tekrar butonlar aktif olsunlar diye
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (sorudegiskeni == 1)
            {
                richTextBox1.Text = "mka ne zaman doðdu ?";

                button1.Text = "1881";
                button2.Text = "1882";
                button3.Text = "1861";
                button4.Text = "1891";

                label3.Text = "1881";

            }
            if (sorudegiskeni == 2)
            {
                richTextBox1.Text = "cumhuriyet ne zaman ilan edildi ?";

                button1.Text = "1464";
                button2.Text = "1818";
                button3.Text = "1919";
                button4.Text = "1923";

                label3.Text = "1923";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false; // butonlara bir kez basalým diye
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


            label4.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false; // butonlara bir kez basalým diye
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label4.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button1.Enabled = false; // butonlara bir kez basalým diye
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


            label4.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Enabled = false; // butonlara bir kez basalým diye
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


            label4.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            label9.Text = sure.ToString();

            if (sure == 0)
            {
                timer1.Enabled = false;
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }
    }
}