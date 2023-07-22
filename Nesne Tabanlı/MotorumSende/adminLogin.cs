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
    public partial class adminLogin : Form
    {
        data data = new data();
        public adminLogin()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (data.GirisYapAdmin(textBox_KA.Text,textBox_Sifre.Text))
            {
                this.Hide();
                adminPanel adminPanel = new adminPanel();
                adminPanel.ShowDialog();
            }
        }

        private void buttonKullanici_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.ShowDialog();
        }
    }
}
