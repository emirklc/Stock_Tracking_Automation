using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ND8R4BB\\SQLEXPRESS;Initial Catalog=Magaza;Integrated Security=True");
        DataTable table = new DataTable();
        private void musteriListele()
        {
            table.Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Musteriler  ", connection);
            adtr.Fill(table);
            dataGridView3.DataSource = table;
            connection.Close();
        }
        private void Musteri_Load(object sender, EventArgs e)
        {
            musteriListele();
        }


        private void mussteriekle_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Musteriler(ad, soyad, telefon, eposta) VALUES(@ad, @soyad, @telefon, @eposta)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@ad", SqlDbType.NVarChar).Value = ad.Text;
                    command.Parameters.Add("@soyad", SqlDbType.NVarChar).Value = soyad.Text;
                    command.Parameters.Add("@telefon", SqlDbType.BigInt).Value = Int64.Parse(telefon.Text);
                    command.Parameters.Add("@eposta", SqlDbType.NVarChar).Value = eposta.Text;

                    command.ExecuteNonQuery();
                    connection.Close();
                }

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



        private void update_Click(object sender, EventArgs e)
        {


            connection.Open();

            string query = "UPDATE Musteriler SET ad = @ad,soyad = @soyad,telefon = @telefon,eposta = @eposta Where telefon = @telefon ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ad", ad.Text);
            command.Parameters.AddWithValue("@soyad", soyad.Text);
            command.Parameters.AddWithValue("@telefon", telefon.Text);
            command.Parameters.AddWithValue("@eposta", eposta.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("kayıt güncellendi");
            musteriListele();



            foreach (Control item in this.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null || dataGridView3.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            string musteriID = dataGridView3.CurrentRow.Cells["ID"].Value.ToString();

            try
            {
                string query = "DELETE FROM Musteriler WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", musteriID);
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                connection.Close();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kayıt silindi.");
                    musteriListele();
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



        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ad.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            soyad.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            telefon.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            eposta.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }

        /*  private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
          {

          }*/
    }
}
