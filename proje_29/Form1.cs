namespace proje_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); // k�t�phane
            int random = rastgele.Next(0, 100);
            label1.Text = random.ToString();
            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int say� = Convert.ToInt32(label1.Text);
            int b�l�m = say� / 2;
            int kalan = say� - (b�l�m * 2);
            if (kalan == 1)
            {
                puan = puan + 10;

            }
            if (kalan == 0)
            {
                puan = puan - 10;

            }
            label4.Text = puan.ToString();
            button2.Enabled = false; // buton aktiflik
            button3.Enabled = false;
           
            if (puan == 100)
            {
                MessageBox.Show("kazand�n�z");
                Application.Exit(); // uygulamadan ��kma
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int say� = Convert.ToInt32(label1.Text);
            int b�l�m = say� / 2;
            int kalan = say� - (b�l�m * 2);
            if (kalan == 0)
            {
                puan = puan + 10;

            }
            if (kalan == 1)
            {
                puan = puan - 10;

            }
            label4.Text = puan.ToString();
            button2.Enabled = false;
            button3.Enabled = false;


            if (puan == 100)
            {
                MessageBox.Show("kazand�n�z");
                Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
