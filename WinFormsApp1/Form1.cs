namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriDetay kategoriButon = new KategoriDetay();
            kategoriButon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunlerDetay urunlerButon = new UrunlerDetay();
            urunlerButon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri musteriButton = new Musteri();
            musteriButton.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            satis satisButton = new satis();
            satisButton.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewHome yeniButton = new NewHome();
            yeniButton.Show();
        }
    }
}