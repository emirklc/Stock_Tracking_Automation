using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace WinFormsApp1
{
    public partial class KategoriDetay : Form
    {

        public KategoriDetay()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ND8R4BB\\SQLEXPRESS;Initial Catalog=Magaza;Integrated Security=True");
        DataTable table = new DataTable();
        private void KategoriDetay_Load(object sender, EventArgs e)
        {
            Listele();

        }
        private void Listele()
        {
            table.Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kategoriler  ", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO kategoriler (kategori_id, kategori_adi) VALUES ('" + int.Parse(kategoriId.Text) + "','" + kategoriAdi.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("işlem başarılı");
            Listele();
        }


        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Update_Click(object sender, EventArgs e)
        {
            if (kategoriId.Text != "")
            {

                connection.Open();

                string query = "UPDATE kategoriler SET kategori_adi = @kategoriAdi WHERE kategori_id = @kategoriId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kategoriId", int.Parse(kategoriId.Text));
                command.Parameters.AddWithValue("@kategoriAdi", kategoriAdi.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("kayıt güncellendi");
                Listele();

            }
            else
            {
                MessageBox.Show("Kategori ID yok");
            }
            foreach (Control item in this.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            int kategoriId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            try
            {
                string query = "DELETE FROM kategoriler WHERE kategori_id = @kategoriId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kategoriId", kategoriId);
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                connection.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kayıt silindi.");
                    Listele(); // Burada Listele() metodu ile DataGridView'i güncelleyin.
                }
                else
                {
                    MessageBox.Show("Kayıt silinirken bir hata oluştu veya seçili kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                connection.Close();
            }
        }


        private void arama_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kategoriler where kategori_id like '%" + arama.Text + "%'", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kategoriId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }


    }
}
