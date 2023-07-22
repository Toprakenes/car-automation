namespace MotorumSende
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_KA = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_KA
            // 
            this.textBox_KA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_KA.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KA.Location = new System.Drawing.Point(516, 177);
            this.textBox_KA.Multiline = true;
            this.textBox_KA.Name = "textBox_KA";
            this.textBox_KA.Size = new System.Drawing.Size(259, 36);
            this.textBox_KA.TabIndex = 1;
            this.textBox_KA.Text = "Kullanıcı Adı";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(516, 240);
            this.textBox_Sifre.Multiline = true;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(259, 36);
            this.textBox_Sifre.TabIndex = 2;
            this.textBox_Sifre.Text = "Şifre";
            // 
            // buttonGiris
            // 
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(516, 299);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(259, 40);
            this.buttonGiris.TabIndex = 3;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonKayit
            // 
            this.buttonKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayit.Location = new System.Drawing.Point(654, 369);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(83, 20);
            this.buttonKayit.TabIndex = 4;
            this.buttonKayit.Text = "Hesap Oluştur";
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MotorumSende.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdmin.Location = new System.Drawing.Point(584, 462);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(114, 44);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "Admin Girişi";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 601);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorum Sende";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_KA;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

