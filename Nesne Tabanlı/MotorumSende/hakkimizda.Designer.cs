namespace MotorumSende
{
    partial class hakkimizda
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
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonHakkimizda = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MotorumSende.Properties.Resources.hakkimizda;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(1230, 20);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(44, 19);
            this.buttonCikis.TabIndex = 13;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonHakkimizda
            // 
            this.buttonHakkimizda.BackColor = System.Drawing.SystemColors.Info;
            this.buttonHakkimizda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHakkimizda.Location = new System.Drawing.Point(1157, 20);
            this.buttonHakkimizda.Name = "buttonHakkimizda";
            this.buttonHakkimizda.Size = new System.Drawing.Size(67, 19);
            this.buttonHakkimizda.TabIndex = 12;
            this.buttonHakkimizda.Text = "Hakkımızda";
            this.buttonHakkimizda.UseVisualStyleBackColor = false;
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnasayfa.Location = new System.Drawing.Point(1077, 20);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(55, 19);
            this.buttonAnasayfa.TabIndex = 11;
            this.buttonAnasayfa.Text = "Anasayfa";
            this.buttonAnasayfa.UseVisualStyleBackColor = false;
            this.buttonAnasayfa.Click += new System.EventHandler(this.buttonAnasayfa_Click);
            // 
            // hakkimizda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 511);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonHakkimizda);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "hakkimizda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorum Sende";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonHakkimizda;
        private System.Windows.Forms.Button buttonAnasayfa;
    }
}