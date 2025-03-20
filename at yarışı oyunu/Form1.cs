namespace at_yarışı_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatinsolauzaklik, ikinciatinsolauzaklik, ucuncuatinsolauzaklik;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatinsolauzaklik = pictureBox1.Left;
            ikinciatinsolauzaklik = pictureBox2.Left;
            ucuncuatinsolauzaklik = pictureBox3.Left;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;
            
            pictureBox1.Left += rastgele.Next(5,35);
            pictureBox2.Left += rastgele.Next(5,35);
            pictureBox3.Left += rastgele.Next(5,35);

        }
    }
}