namespace MotorumSende
{
    partial class Kayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_KA = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MotorumSende.Properties.Resources.kayit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(670, 409);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(83, 20);
            this.buttonGiris.TabIndex = 8;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayıtOl.Location = new System.Drawing.Point(470, 354);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(352, 40);
            this.buttonKayıtOl.TabIndex = 7;
            this.buttonKayıtOl.Text = "Kayıt Ol";
            this.buttonKayıtOl.UseVisualStyleBackColor = false;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(479, 296);
            this.textBox_Sifre.Multiline = true;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(343, 36);
            this.textBox_Sifre.TabIndex = 6;
            this.textBox_Sifre.Text = "Şifre";
            // 
            // textBox_KA
            // 
            this.textBox_KA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_KA.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KA.Location = new System.Drawing.Point(479, 171);
            this.textBox_KA.Multiline = true;
            this.textBox_KA.Name = "textBox_KA";
            this.textBox_KA.Size = new System.Drawing.Size(343, 36);
            this.textBox_KA.TabIndex = 5;
            this.textBox_KA.Text = "Kullanıcı Adı";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Mail.Location = new System.Drawing.Point(479, 233);
            this.textBox_Mail.Multiline = true;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(343, 36);
            this.textBox_Mail.TabIndex = 9;
            this.textBox_Mail.Text = "E-Mail Adresiniz";
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 601);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.buttonKayıtOl);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorum Sende";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonKayıtOl;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_KA;
        private System.Windows.Forms.TextBox textBox_Mail;
    }
}