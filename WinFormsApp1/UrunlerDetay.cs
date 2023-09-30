using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UrunlerDetay : Form
    {
        public UrunlerDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ND8R4BB\\SQLEXPRESS;Initial Catalog=Magaza;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();

        private void kategorigetir()
        {

            connection.Open();
            SqlCommand command = new SqlCommand("select * from kategoriler  ", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                kategoribox.Items.Add(read["kategori_id"].ToString());
            }
            connection.Close();
        }
        private void bırleştır()
        {
            string query = "SELECT urunler.urun_id, kategoriler.kategori_adi, urunler.urun_adi, urunler.fiyat, urunler.stok_miktari " +
                           "FROM urunler " +
                          "INNER JOIN kategoriler ON urunler.kategori_id = kategoriler.kategori_id";

            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
        private void kotegoribox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }// "Select satisBaslik.satis_id,urunler.urun_id,musteriler.ID,urunler.fiyat,satisBaslik.tarih" + "from urunler" + "inner join SatisDetay on urunler.urun_id =satisDetay.urun_id"+"inner join musteriler on  musteriler.ID = satisBaslik.ID"+"inner join satisBasik on satisBaslik.satis_id = satisDetay.satis_id"

        private void UrunlerDetay_Load(object sender, EventArgs e)
        {
            kategorigetir();
            bırleştır();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                string query = "insert into urunler(urun_id, urun_adi, fiyat, stok_miktari kategori_adi) " +
                               "VALUES(@urun_id, @kategori_id, @urun_adi, @fiyat, @stok_miktari)";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();


                command.Parameters.AddWithValue("@urun_id", urunText.Text);
                command.Parameters.AddWithValue("@kategori_id", kategoribox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@urun_adi", urunAdText.Text);
                command.Parameters.AddWithValue("@fiyat", fiyatText.Text);
                command.Parameters.AddWithValue("@stok_miktari", stokText.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt eklendi");

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = -1; // Reset the selected index of the ComboBox.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urunText.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            kategoribox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            urunAdText.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            fiyatText.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            stokText.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void updateurun_Click(object sender, EventArgs e)
        {
            if (urunText.Text != "")
            {

                connection.Open();

                string query = "UPDATE urunler SET urun_id = @urunText,kategori_id = @kategoribox,urun_adi = @urunAdText,fiyat = @fiyatText,stok_miktari = @stokText WHERE urun_id = @urunText";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@urunText", int.Parse(urunText.Text));
                command.Parameters.AddWithValue("@kategoribox", kategoribox.Items[0]);
                command.Parameters.AddWithValue("@urunAdText", urunAdText.Text);
                command.Parameters.AddWithValue("@fiyatText", decimal.Parse(fiyatText.Text));
                command.Parameters.AddWithValue("@stokText", int.Parse(stokText.Text));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("kayıt güncellendi");
                bırleştır();

            }
            else
            {
                MessageBox.Show("Ürün ID yok");
            }
            foreach (Control item in this.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void deleteurun_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            int urun = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

            try
            {
                string query = "DELETE FROM urunler WHERE urun_id = @urunText";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@urunText", urun);
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                connection.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kayıt silindi.");
                    bırleştır();
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

        private void urunAra_TextChanged(object sender, EventArgs e)
        {
            dataTable.Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urunler where urun_id like '%" + urunAra.Text + "%'", connection);
            adtr.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            connection.Close();
        }
    }
}


