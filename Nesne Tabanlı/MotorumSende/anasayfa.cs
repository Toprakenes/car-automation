using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorumSende
{
    public partial class anasayfa : Form
    {
        data data = new data();
        int secilen = 0;
        int id = 0;

        public anasayfa()
        {
            InitializeComponent();
        }

        private void buttonHakkimizda_Click(object sender, EventArgs e)
        {
            this.Hide();
            hakkimizda hakkimizda = new hakkimizda();
            hakkimizda.ShowDialog();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.ShowDialog();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.Motorlar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            if (dataGridView1.Rows[secilen].Cells[0].Value.ToString() != "")
            {
                pictureBox2.ImageLocation = "C:/wamp64/www/MotorumSende/WEB/Resim/" + dataGridView1.Rows[secilen].Cells[5].Value.ToString() + ".jpg";
                label_model.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                label_aciklama.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                label_fiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString() + "₺";
                label_aralik.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                id = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void buttonRezervasyon_Click(object sender, EventArgs e)
        {
            data.RezervasyonYap(textBox_ad.Text, textBox_soyad.Text, textBox_adres.Text, textBox_tel.Text, id);
        }
    }
}
