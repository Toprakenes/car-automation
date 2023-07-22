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
    public partial class Giris : Form
    {
        data data = new data();

        public Giris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (data.GirisYap(textBox_KA.Text, textBox_Sifre.Text))
            {
                this.Hide();
                anasayfa anasayfa = new anasayfa();
                anasayfa.ShowDialog();
            }
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayıt kayıt = new Kayıt();
            kayıt.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin adminLogin = new adminLogin();
            adminLogin.ShowDialog();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
