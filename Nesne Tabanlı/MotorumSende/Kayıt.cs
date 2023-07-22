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
    public partial class Kayıt : Form
    {
        data data = new data();

        public Kayıt()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.ShowDialog();
        }

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            if (data.KayitOl(textBox_KA.Text,textBox_Sifre.Text,textBox_Mail.Text))
            {
                this.Hide();
                Giris giris = new Giris();
                giris.ShowDialog();
            }
        }
    }
}
