namespace MotorumSende
{
    partial class adminPanel
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
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBox_Fiyat = new System.Windows.Forms.TextBox();
            this.textBox_Aciklama = new System.Windows.Forms.TextBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonHakkimizda = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Aralik = new System.Windows.Forms.ComboBox();
            this.textBox_resimID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Lime;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEkle.Location = new System.Drawing.Point(1128, 99);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(162, 60);
            this.buttonEkle.TabIndex = 34;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBox_Fiyat
            // 
            this.textBox_Fiyat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Fiyat.Location = new System.Drawing.Point(896, 511);
            this.textBox_Fiyat.Multiline = true;
            this.textBox_Fiyat.Name = "textBox_Fiyat";
            this.textBox_Fiyat.Size = new System.Drawing.Size(190, 36);
            this.textBox_Fiyat.TabIndex = 28;
            this.textBox_Fiyat.Text = "Fiyat";
            // 
            // textBox_Aciklama
            // 
            this.textBox_Aciklama.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Aciklama.Location = new System.Drawing.Point(896, 375);
            this.textBox_Aciklama.Multiline = true;
            this.textBox_Aciklama.Name = "textBox_Aciklama";
            this.textBox_Aciklama.Size = new System.Drawing.Size(386, 130);
            this.textBox_Aciklama.TabIndex = 27;
            this.textBox_Aciklama.Text = "Açıklama";
            // 
            // textBox_Model
            // 
            this.textBox_Model.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Model.Location = new System.Drawing.Point(896, 297);
            this.textBox_Model.Multiline = true;
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(386, 72);
            this.textBox_Model.TabIndex = 26;
            this.textBox_Model.Text = "Model";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 490);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(1238, 21);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(44, 19);
            this.buttonCikis.TabIndex = 24;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonHakkimizda
            // 
            this.buttonHakkimizda.BackColor = System.Drawing.SystemColors.Info;
            this.buttonHakkimizda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHakkimizda.Location = new System.Drawing.Point(1164, 21);
            this.buttonHakkimizda.Name = "buttonHakkimizda";
            this.buttonHakkimizda.Size = new System.Drawing.Size(67, 19);
            this.buttonHakkimizda.TabIndex = 23;
            this.buttonHakkimizda.Text = "Rezervasyonlar";
            this.buttonHakkimizda.UseVisualStyleBackColor = false;
            this.buttonHakkimizda.Click += new System.EventHandler(this.buttonHakkimizda_Click);
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnasayfa.Location = new System.Drawing.Point(1085, 21);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(55, 19);
            this.buttonAnasayfa.TabIndex = 22;
            this.buttonAnasayfa.Text = "Anasayfa";
            this.buttonAnasayfa.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MotorumSende.Properties.Resources.mainMenu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Aralik
            // 
            this.comboBox_Aralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Aralik.FormattingEnabled = true;
            this.comboBox_Aralik.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.comboBox_Aralik.Location = new System.Drawing.Point(1092, 510);
            this.comboBox_Aralik.Name = "comboBox_Aralik";
            this.comboBox_Aralik.Size = new System.Drawing.Size(190, 37);
            this.comboBox_Aralik.TabIndex = 35;
            this.comboBox_Aralik.Text = "Günlük";
            // 
            // textBox_resimID
            // 
            this.textBox_resimID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_resimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_resimID.Location = new System.Drawing.Point(896, 553);
            this.textBox_resimID.Multiline = true;
            this.textBox_resimID.Name = "textBox_resimID";
            this.textBox_resimID.Size = new System.Drawing.Size(386, 36);
            this.textBox_resimID.TabIndex = 36;
            this.textBox_resimID.Text = "Resim ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(896, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Coral;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(1128, 165);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(162, 60);
            this.buttonGuncelle.TabIndex = 38;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Red;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(1128, 231);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(162, 60);
            this.buttonSil.TabIndex = 39;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 601);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_resimID);
            this.Controls.Add(this.comboBox_Aralik);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBox_Fiyat);
            this.Controls.Add(this.textBox_Aciklama);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonHakkimizda);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorum Sende";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBox_Fiyat;
        private System.Windows.Forms.TextBox textBox_Aciklama;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonHakkimizda;
        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Aralik;
        private System.Windows.Forms.TextBox textBox_resimID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
    }
}