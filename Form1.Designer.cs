namespace BilgiYarismasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblCevap = new System.Windows.Forms.Label();
            this.LblGiris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 175);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnA.Location = new System.Drawing.Point(12, 193);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(211, 48);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnB.Location = new System.Drawing.Point(229, 193);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(225, 48);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = false;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnC.Location = new System.Drawing.Point(12, 247);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(211, 48);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnD.Location = new System.Drawing.Point(229, 247);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(225, 48);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = false;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Location = new System.Drawing.Point(484, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sonraki";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(480, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.Location = new System.Drawing.Point(598, 15);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(24, 24);
            this.LblSoruNo.TabIndex = 9;
            this.LblSoruNo.Text = "0";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Location = new System.Drawing.Point(598, 53);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(24, 24);
            this.LblDogru.TabIndex = 10;
            this.LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(597, 93);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(24, 24);
            this.LblYanlis.TabIndex = 11;
            this.LblYanlis.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(558, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Location = new System.Drawing.Point(269, 321);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(71, 24);
            this.LblCevap.TabIndex = 14;
            this.LblCevap.Text = "Cevap";
            this.LblCevap.Visible = false;
            // 
            // LblGiris
            // 
            this.LblGiris.AutoSize = true;
            this.LblGiris.Location = new System.Drawing.Point(346, 321);
            this.LblGiris.Name = "LblGiris";
            this.LblGiris.Size = new System.Drawing.Size(60, 24);
            this.LblGiris.TabIndex = 15;
            this.LblGiris.Text = "Giriş";
            this.LblGiris.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 299);
            this.Controls.Add(this.LblGiris);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "BilgiYarismasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Label LblGiris;
    }
}

