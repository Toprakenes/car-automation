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
    public partial class rezervasyonlar : Form
    {
        data data = new data();
        int secilen = 0;
        int id = 0;

        public rezervasyonlar()
        {
            InitializeComponent();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel adminPanel = new adminPanel();
            adminPanel.ShowDialog();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.ShowDialog();
        }

        private void buttonRezervasyon_Click(object sender, EventArgs e)
        {
            data.İletisim(id);
            dataGridView1.DataSource = data.Rezervasyonlar();
        }

        private void rezervasyonlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.Rezervasyonlar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            if (dataGridView1.Rows[secilen].Cells[0].Value.ToString() != "")
            {
                pictureBox2.ImageLocation = "C:/wamp64/www/MotorumSende/WEB/Resim/" + dataGridView1.Rows[secilen].Cells[9].Value.ToString() + ".jpg";
                label_model.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                label_aciklama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                label_fiyat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString() + "₺";
                label_aralik.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                textBox_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                textBox_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                textBox_adres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                textBox_tel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                id = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            }
        }
    }
}
