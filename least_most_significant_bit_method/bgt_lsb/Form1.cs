using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_lsb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Prestige prestige = new Prestige();

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCoverImage.Image = new Bitmap(openFileDialog1.OpenFile());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = new Bitmap(openFileDialog2.OpenFile());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStegoImage.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Stego Resim Alanı Boş...");
            }
        }

        private void buttonGizle_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap coverImage = new Bitmap(pictureBoxCoverImage.Image);
                pictureBoxStegoImage.Image = Prestige.Encode(textBoxSecretText.Text, coverImage, Convert.ToInt32(numericUpDownEncodingBitValue.Value));
                MessageBox.Show("Gizleme işlemi tamamlandı.\nLütfen resmi kaydediniz.","İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxHiddenText.Text = "";
                Bitmap stegoImage = new Bitmap(pictureBox3.Image);
                textBoxHiddenText.Text = Prestige.Decode(stegoImage, Convert.ToInt32(numericUpDownDecodingBitValue.Value));
                MessageBox.Show("Çözümleme işlemi tamamlandı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
