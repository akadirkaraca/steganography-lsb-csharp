namespace bgt_lsb
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEncoding = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonHide = new System.Windows.Forms.Button();
            this.numericUpDownEncodingBitValue = new System.Windows.Forms.NumericUpDown();
            this.textBoxEncodingIterationKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxSecretText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSaveStego = new System.Windows.Forms.Button();
            this.buttonSelectCover = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxStegoImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxCoverImage = new System.Windows.Forms.PictureBox();
            this.tabPageDecoding = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.numericUpDownDecodingBitValue = new System.Windows.Forms.NumericUpDown();
            this.textBoxDecodingIterationKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBoxHiddenText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageEncoding.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncodingBitValue)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStegoImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).BeginInit();
            this.tabPageDecoding.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecodingBitValue)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEncoding);
            this.tabControlMain.Controls.Add(this.tabPageDecoding);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(794, 628);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageEncoding
            // 
            this.tabPageEncoding.Controls.Add(this.panel5);
            this.tabPageEncoding.Controls.Add(this.panel4);
            this.tabPageEncoding.Controls.Add(this.panel1);
            this.tabPageEncoding.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncoding.Name = "tabPageEncoding";
            this.tabPageEncoding.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncoding.Size = new System.Drawing.Size(786, 602);
            this.tabPageEncoding.TabIndex = 0;
            this.tabPageEncoding.Text = "Encoding";
            this.tabPageEncoding.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(780, 182);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonHide);
            this.panel7.Controls.Add(this.numericUpDownEncodingBitValue);
            this.panel7.Controls.Add(this.textBoxEncodingIterationKey);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(566, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 182);
            this.panel7.TabIndex = 1;
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(74, 128);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(100, 49);
            this.buttonHide.TabIndex = 4;
            this.buttonHide.Text = "Gizle";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonGizle_Click);
            // 
            // numericUpDownEncodingBitValue
            // 
            this.numericUpDownEncodingBitValue.Location = new System.Drawing.Point(74, 29);
            this.numericUpDownEncodingBitValue.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownEncodingBitValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEncodingBitValue.Name = "numericUpDownEncodingBitValue";
            this.numericUpDownEncodingBitValue.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownEncodingBitValue.TabIndex = 3;
            this.numericUpDownEncodingBitValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxEncodingIterationKey
            // 
            this.textBoxEncodingIterationKey.Location = new System.Drawing.Point(76, 79);
            this.textBoxEncodingIterationKey.Name = "textBoxEncodingIterationKey";
            this.textBoxEncodingIterationKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxEncodingIterationKey.TabIndex = 2;
            this.textBoxEncodingIterationKey.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Anahtar:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bit Sayısı:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxSecretText);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(549, 182);
            this.panel6.TabIndex = 0;
            // 
            // textBoxSecretText
            // 
            this.textBoxSecretText.Font = new System.Drawing.Font("Playfair Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSecretText.Location = new System.Drawing.Point(8, 29);
            this.textBoxSecretText.Multiline = true;
            this.textBoxSecretText.Name = "textBoxSecretText";
            this.textBoxSecretText.Size = new System.Drawing.Size(521, 148);
            this.textBoxSecretText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gizlenecek Metin";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.buttonSaveStego);
            this.panel4.Controls.Add(this.buttonSelectCover);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 45);
            this.panel4.TabIndex = 1;
            // 
            // buttonSaveStego
            // 
            this.buttonSaveStego.Location = new System.Drawing.Point(556, 7);
            this.buttonSaveStego.Name = "buttonSaveStego";
            this.buttonSaveStego.Size = new System.Drawing.Size(112, 35);
            this.buttonSaveStego.TabIndex = 1;
            this.buttonSaveStego.Text = "Stego Kaydet...";
            this.buttonSaveStego.UseVisualStyleBackColor = true;
            this.buttonSaveStego.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSelectCover
            // 
            this.buttonSelectCover.Location = new System.Drawing.Point(127, 7);
            this.buttonSelectCover.Name = "buttonSelectCover";
            this.buttonSelectCover.Size = new System.Drawing.Size(112, 35);
            this.buttonSelectCover.TabIndex = 0;
            this.buttonSelectCover.Text = "Cover Seç...";
            this.buttonSelectCover.UseVisualStyleBackColor = true;
            this.buttonSelectCover.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxStegoImage);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 300);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxStegoImage
            // 
            this.pictureBoxStegoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStegoImage.Location = new System.Drawing.Point(400, 0);
            this.pictureBoxStegoImage.Name = "pictureBoxStegoImage";
            this.pictureBoxStegoImage.Size = new System.Drawing.Size(380, 300);
            this.pictureBoxStegoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStegoImage.TabIndex = 0;
            this.pictureBoxStegoImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(780, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 300);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxCoverImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 300);
            this.panel2.TabIndex = 0;
            // 
            // pictureBoxCoverImage
            // 
            this.pictureBoxCoverImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCoverImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            this.pictureBoxCoverImage.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCoverImage.TabIndex = 0;
            this.pictureBoxCoverImage.TabStop = false;
            // 
            // tabPageDecoding
            // 
            this.tabPageDecoding.Controls.Add(this.panel8);
            this.tabPageDecoding.Controls.Add(this.panel9);
            this.tabPageDecoding.Controls.Add(this.panel13);
            this.tabPageDecoding.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecoding.Name = "tabPageDecoding";
            this.tabPageDecoding.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecoding.Size = new System.Drawing.Size(786, 602);
            this.tabPageDecoding.TabIndex = 1;
            this.tabPageDecoding.Text = "Decoding";
            this.tabPageDecoding.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 303);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(780, 49);
            this.panel8.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Stego Seç...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(780, 300);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(380, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 300);
            this.panel10.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(400, 300);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(400, 300);
            this.panel11.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(3, 417);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(780, 182);
            this.panel13.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonShow);
            this.panel14.Controls.Add(this.numericUpDownDecodingBitValue);
            this.panel14.Controls.Add(this.textBoxDecodingIterationKey);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(566, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(214, 182);
            this.panel14.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(74, 128);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(100, 49);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Göster";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDownDecodingBitValue
            // 
            this.numericUpDownDecodingBitValue.Location = new System.Drawing.Point(74, 29);
            this.numericUpDownDecodingBitValue.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownDecodingBitValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDecodingBitValue.Name = "numericUpDownDecodingBitValue";
            this.numericUpDownDecodingBitValue.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownDecodingBitValue.TabIndex = 3;
            this.numericUpDownDecodingBitValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxDecodingIterationKey
            // 
            this.textBoxDecodingIterationKey.Location = new System.Drawing.Point(76, 79);
            this.textBoxDecodingIterationKey.Name = "textBoxDecodingIterationKey";
            this.textBoxDecodingIterationKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxDecodingIterationKey.TabIndex = 2;
            this.textBoxDecodingIterationKey.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Anahtar:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bit Sayısı:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.textBoxHiddenText);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(549, 182);
            this.panel12.TabIndex = 0;
            // 
            // textBoxHiddenText
            // 
            this.textBoxHiddenText.Font = new System.Drawing.Font("Playfair Display", 12.75F);
            this.textBoxHiddenText.Location = new System.Drawing.Point(8, 29);
            this.textBoxHiddenText.Multiline = true;
            this.textBoxHiddenText.Name = "textBoxHiddenText";
            this.textBoxHiddenText.Size = new System.Drawing.Size(521, 148);
            this.textBoxHiddenText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gizlenmiş Metin";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Resim Dosyaları (*.bmp, *.png, *.jpg, *.jpeg, *.jpe, *.jfif) |*.png; *.bmp; *.jpg" +
    "; *.jpeg; *.jpe; *.jfif";
            this.openFileDialog1.Title = "Bir Resim Seçiniz...";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Bitmap Resim Dosyası (*.bmp)|*.bmp|Taşınabilir Ağ Grafik Dosyası (*.png)|*.png";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "stegoImage";
            this.saveFileDialog1.Filter = "Bitmap Resim Dosyası (*.bmp)|*.bmp|Taşınabilir Ağ Grafik Dosyası (*.png)|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 628);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LSB";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEncoding.ResumeLayout(false);
            this.tabPageEncoding.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncodingBitValue)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStegoImage)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).EndInit();
            this.tabPageDecoding.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecodingBitValue)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEncoding;
        private System.Windows.Forms.TabPage tabPageDecoding;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSecretText;
        private System.Windows.Forms.NumericUpDown numericUpDownEncodingBitValue;
        private System.Windows.Forms.TextBox textBoxEncodingIterationKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonSelectCover;
        private System.Windows.Forms.PictureBox pictureBoxStegoImage;
        private System.Windows.Forms.PictureBox pictureBoxCoverImage;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.NumericUpDown numericUpDownDecodingBitValue;
        private System.Windows.Forms.TextBox textBoxDecodingIterationKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBoxHiddenText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button buttonSaveStego;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

