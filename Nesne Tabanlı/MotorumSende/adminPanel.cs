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
    public partial class adminPanel : Form
    {
        data data = new data();
        int secilen = 0;
        int id = 0;

        public adminPanel()
        {
            InitializeComponent();
        }

        private void buttonHakkimizda_Click(object sender, EventArgs e)
        {
            this.Hide();
            rezervasyonlar rezervasyonlar = new rezervasyonlar();
            rezervasyonlar.ShowDialog();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.ShowDialog();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.Motorlar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            if (dataGridView1.Rows[secilen].Cells[0].Value.ToString() != "")
            {
                comboBox_Aralik.Text = "";
                pictureBox2.ImageLocation = "C:/wamp64/www/MotorumSende/WEB/Resim/" + dataGridView1.Rows[secilen].Cells[5].Value.ToString() + ".jpg";
                textBox_Model.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                textBox_Aciklama.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                textBox_Fiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                comboBox_Aralik.SelectedText = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                textBox_resimID.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                id = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            data.MotorEkle(textBox_Model.Text, textBox_Aciklama.Text, textBox_Fiyat.Text, comboBox_Aralik.Text, textBox_resimID.Text);
            dataGridView1.DataSource = data.Motorlar();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            data.MotorGuncelle(textBox_Model.Text, textBox_Aciklama.Text, textBox_Fiyat.Text, comboBox_Aralik.Text, textBox_resimID.Text, id);
            dataGridView1.DataSource = data.Motorlar();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            data.MotorSil(id);
            dataGridView1.DataSource = data.Motorlar();
        }
    }
}
