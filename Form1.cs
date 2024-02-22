using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            LblGiris.Text = BtnB.Text;
            if (LblCevap.Text == LblGiris.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            LblGiris.Text = BtnC.Text;
            if (LblCevap.Text == LblGiris.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            LblGiris.Text = BtnD.Text;
            if (LblCevap.Text == LblGiris.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            LblGiris.Text = BtnA.Text;
            if(LblCevap.Text == LblGiris.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            LblSoruNo.Text = soruno.ToString();
            if(soruno == 1)
            {
                richTextBox1.Text = "Dandanakan Savaşı hangi yılda yapılmıştır?";
                BtnA.Text = "1040";
                BtnB.Text = "1057";
                BtnC.Text = "1081";
                BtnD.Text = "1037";
                LblCevap.Text = "1040";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Kanuni Sultan Süleyman'ın eşi kimdir?";
                BtnA.Text = "Kösem Sultan";
                BtnB.Text = "Safiye Sultan";
                BtnC.Text = "Hürrem Sultan";
                BtnD.Text = "Nurbanu Sultan";
                LblCevap.Text = "Hürrem Sultan";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Şıklardan hangisi bir hücrede bulunan organellerden biridir?";
                BtnA.Text = "DNA";
                BtnB.Text = "tRNA";
                BtnC.Text = "RNA";
                BtnD.Text = "Ribozom";
                LblCevap.Text = "Ribozom";
            }
            if (soruno == 4)
            {
                button5.Text = "Sonuçlar";
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}
