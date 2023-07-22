namespace MotorumSende
{
    partial class adminLogin
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
            this.buttonKullanici = new System.Windows.Forms.Button();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_KA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKullanici
            // 
            this.buttonKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullanici.Location = new System.Drawing.Point(558, 369);
            this.buttonKullanici.Name = "buttonKullanici";
            this.buttonKullanici.Size = new System.Drawing.Size(179, 20);
            this.buttonKullanici.TabIndex = 9;
            this.buttonKullanici.Text = "Kullanıcı";
            this.buttonKullanici.UseVisualStyleBackColor = true;
            this.buttonKullanici.Click += new System.EventHandler(this.buttonKullanici_Click);
            // 
            // buttonGiris
            // 
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(516, 299);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(259, 40);
            this.buttonGiris.TabIndex = 8;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(516, 240);
            this.textBox_Sifre.Multiline = true;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(259, 36);
            this.textBox_Sifre.TabIndex = 7;
            this.textBox_Sifre.Text = "Şifre";
            // 
            // textBox_KA
            // 
            this.textBox_KA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_KA.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KA.Location = new System.Drawing.Point(516, 177);
            this.textBox_KA.Multiline = true;
            this.textBox_KA.Name = "textBox_KA";
            this.textBox_KA.Size = new System.Drawing.Size(259, 36);
            this.textBox_KA.TabIndex = 6;
            this.textBox_KA.Text = "Admin Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MotorumSende.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 601);
            this.Controls.Add(this.buttonKullanici);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorum Sende";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKullanici;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_KA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}