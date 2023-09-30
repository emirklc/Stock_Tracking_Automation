using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NewHome : Form
    {
        public NewHome()
        {
            InitializeComponent();
            
        }


        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        } 


        private void KATEGORİLER_Click(object sender, EventArgs e)
        {
            KategoriDetay kategoriButon = new KategoriDetay();
            kategoriButon.Show();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void URUNLER_Click(object sender, EventArgs e)
        {
            
        }

        private void MUSTERİLER_Click(object sender, EventArgs e)
        {
            
        }

        private void SİPARİSLER_Click(object sender, EventArgs e)
        {
            
        }
    }
}
