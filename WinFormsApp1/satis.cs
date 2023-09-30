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
    public partial class satis : Form
    {


        public satis()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ND8R4BB\\SQLEXPRESS;Initial Catalog=Magaza;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();

        private void satisGetir()
        {
            string query = " SELECT sb.satis_id, m.ad , m.soyad,m.telefon,m.eposta,u.urun_adi,sd.toplam " +
                  " FROM SatisBaslik sb " +
                  " INNER JOIN SatisDetay sd ON sb.satis_id = sd.satis_id " +
                  " INNER JOIN Musteriler m ON sb.ID = m.ID " +
                  " INNER JOIN Urunler u ON sd.urun_id = u.urun_id ";

            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView4.DataSource = dataTable;
        }
        private void satis_Load(object sender, EventArgs e)
        {
            satisGetir();
        }



        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataTable.Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satisBaslik where satis_id like '%" + satısAra.Text + "%'", connection);
            adtr.Fill(dataTable);
            dataGridView4.DataSource = dataTable;
            connection.Close();

        }
    }
}
