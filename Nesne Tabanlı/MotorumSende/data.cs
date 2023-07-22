using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorumSende
{
    public class data
    {
        MySqlConnection MySQLBaglanti = new MySqlConnection("datasource=localhost;port=3306;database=motorum_sende;username=root;password=");
        public static string kullanici_id = "";

        public bool GirisYap(string kullanici_adi, string sifre)
        {
            bool ok = false;
            var komut = new MySqlCommand($"SELECT id,kullanici_adi,sifre FROM kullanici WHERE kullanici_adi='{kullanici_adi}' AND sifre='{sifre}'", MySQLBaglanti);

            using (MySQLBaglanti)
            {
                using (komut)
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dataReader = komut.ExecuteReader();

                        if (dataReader.Read())
                        {
                            string data_kulanici_adi = dataReader["kullanici_adi"].ToString();
                            string data_kullanici_sifre = dataReader["sifre"].ToString();
                            kullanici_id = dataReader["id"].ToString();

                            if (data_kulanici_adi == kullanici_adi && data_kullanici_sifre == sifre)
                            {
                                ok = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return ok;
        }

        public bool KayitOl(string kullanici_adi, string sifre, string e_mail)
        {
            bool ok = false;
            string insertInto = $"INSERT INTO kullanici(kullanici_adi, sifre, e_mail) VALUES (@p1,@p2,@p3)";

            MySQLBaglanti.Open();
            MySqlCommand command = new MySqlCommand(insertInto, MySQLBaglanti);
            command.Parameters.AddWithValue("@p1", kullanici_adi);
            command.Parameters.AddWithValue("@p2", sifre);
            command.Parameters.AddWithValue("@p3", e_mail);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde kaydınız tamalandı");
                    ok = true;
                }
                else
                {
                    MessageBox.Show("Kaydınız başarısız oldu. Lütfen kutucuklara doğru bilgileri girdiğinizden emin olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySQLBaglanti.Close();

            return ok;
        }

        public DataTable Motorlar()
        {
            DataTable table = new DataTable();

            var select = new MySqlCommand($"SELECT * FROM motor ORDER BY id DESC", MySQLBaglanti);
            select.Connection.Open();
            MySqlDataReader dataReader = select.ExecuteReader();
            table.Load(dataReader);
            select.Connection.Close();

            return table;
        }

        public bool RezervasyonYap(string ad, string soyad, string adres, string tel, int motor_id)
        {
            bool ok = false;
            string insertInto = $"INSERT INTO rezervasyon(ad, soyad, adres, tel, motor_id, hesap_id, iletisim) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";

            MySQLBaglanti.Open();
            MySqlCommand command = new MySqlCommand(insertInto, MySQLBaglanti);
            command.Parameters.AddWithValue("@p1", ad);
            command.Parameters.AddWithValue("@p2", soyad);
            command.Parameters.AddWithValue("@p3", adres);
            command.Parameters.AddWithValue("@p4", tel);
            command.Parameters.AddWithValue("@p5", motor_id);
            command.Parameters.AddWithValue("@p6", kullanici_id);
            command.Parameters.AddWithValue("@p7", 0);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde randevunuz ayarlandı");
                    ok = true;
                }
                else
                {
                    MessageBox.Show("Randevunuz başarısız oldu. Lütfen kutucuklara doğru bilgileri girdiğinizden emin olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySQLBaglanti.Close();

            return ok;
        }

        public bool MotorEkle(string model, string aciklama, string fiyat, string aralik, string resim_id)
        {
            bool ok = false;
            string insertInto = $"INSERT INTO motor(model, aciklama, fiyat, aralik, resim_id) VALUES (@p1,@p2,@p3,@p4,@p5)";

            MySQLBaglanti.Open();
            MySqlCommand command = new MySqlCommand(insertInto, MySQLBaglanti);
            command.Parameters.AddWithValue("@p1", model);
            command.Parameters.AddWithValue("@p2", aciklama);
            command.Parameters.AddWithValue("@p3", fiyat);
            command.Parameters.AddWithValue("@p4", aralik);
            command.Parameters.AddWithValue("@p5", resim_id);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde motor eklendi");
                    ok = true;
                }
                else
                {
                    MessageBox.Show("Motor ekleme işleminiz başarısız oldu. Lütfen kutucuklara doğru bilgileri girdiğinizden emin olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySQLBaglanti.Close();

            return ok;
        }

        public bool MotorGuncelle(string model, string aciklama, string fiyat, string aralik, string resim_id, int id)
        {
            bool ok = false;
            string insertInto = $"UPDATE motor SET model = @p1, aciklama = @p2, fiyat = @p3, aralik = @p4, resim_id = @p5 WHERE id = {id}";

            MySQLBaglanti.Open();
            MySqlCommand command = new MySqlCommand(insertInto, MySQLBaglanti);
            command.Parameters.AddWithValue("@p1", model);
            command.Parameters.AddWithValue("@p2", aciklama);
            command.Parameters.AddWithValue("@p3", fiyat);
            command.Parameters.AddWithValue("@p4", aralik);
            command.Parameters.AddWithValue("@p5", resim_id);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde motorunuz güncellendi");
                    ok = true;
                }
                else
                {
                    MessageBox.Show("Motor güncelleme işleminiz başarısız oldu. Lütfen kutucuklara doğru bilgileri girdiğinizden emin olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySQLBaglanti.Close();

            return ok;
        }

        public bool MotorSil(int id)
        {
            bool ok = false;
            string insertInto = $"DELETE FROM motor WHERE id = {id}";

            MySQLBaglanti.Open();
            MySqlCommand command = new MySqlCommand(insertInto, MySQLBaglanti);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde motorunuz silindi");
                    ok = true;
                }
                else
                {
                    MessageBox.Show("Motor silme işleminiz başarısız oldu. Lütfen kutucuklara doğru bilgileri girdiğinizden emin olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySQLBaglanti.Close();

            return ok;
        }

        public bool İletisim(int id)
        {
            bool ok = false;
            string insertInto = $"UPDATE rezervasyon SET iletisim = 1 WHERE id = {id}";

            MySQLBaglanti.Open();
            MySqlCommand command = new MySqlCommand(insertInto, MySQLBaglanti);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Başarılı bir şekilde iletişime geçtiniz.");
                    ok = true;
                }
                else
                {
                    MessageBox.Show("İletişim işleminiz başarısız oldu. Lütfen kutucuklara doğru bilgileri girdiğinizden emin olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySQLBaglanti.Close();

            return ok;
        }

        public DataTable Rezervasyonlar()
        {
            DataTable table = new DataTable();

            var select = new MySqlCommand($"SELECT rezervasyon.id AS 'id',ad,soyad,adres,tel, motor.model AS 'model', motor.aciklama AS 'aciklama', motor.fiyat AS 'fiyat', motor.aralik AS 'aralik', motor.resim_id AS 'resim' FROM rezervasyon,motor WHERE motor.id = motor_id AND iletisim = 0;", MySQLBaglanti);
            select.Connection.Open();
            MySqlDataReader dataReader = select.ExecuteReader();
            table.Load(dataReader);
            select.Connection.Close();

            return table;
        }

        public bool GirisYapAdmin(string admin_adi, string sifre)
        {
            bool ok = false;
            var komut = new MySqlCommand($"SELECT admin_adi,sifre FROM admin WHERE admin_adi='{admin_adi}' AND sifre='{sifre}'", MySQLBaglanti);

            using (MySQLBaglanti)
            {
                using (komut)
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dataReader = komut.ExecuteReader();

                        if (dataReader.Read())
                        {
                            string data_kulanici_adi = dataReader["admin_adi"].ToString();
                            string data_kullanici_sifre = dataReader["sifre"].ToString();

                            if (data_kulanici_adi == admin_adi && data_kullanici_sifre == sifre)
                            {
                                ok = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return ok;
        }
    }
}
