
namespace Ornek
{
    partial class SiparisOlustur
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
            this.flpMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSiparisSec = new System.Windows.Forms.ComboBox();
            this.grpBoyut = new System.Windows.Forms.GroupBox();
            this.rdBuyuk = new System.Windows.Forms.RadioButton();
            this.rdKucuk = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.lstSiparisiGoster = new System.Windows.Forms.ListBox();
            this.nudSiparisAdedi = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpMenuSecim = new System.Windows.Forms.GroupBox();
            this.grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiparisAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMenuSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMalzemeler
            // 
            this.flpMalzemeler.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flpMalzemeler.Location = new System.Drawing.Point(6, 399);
            this.flpMalzemeler.Name = "flpMalzemeler";
            this.flpMalzemeler.Size = new System.Drawing.Size(319, 231);
            this.flpMalzemeler.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "MALZEME SEÇİN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cmbSiparisSec
            // 
            this.cmbSiparisSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSiparisSec.FormattingEnabled = true;
            this.cmbSiparisSec.Location = new System.Drawing.Point(10, 227);
            this.cmbSiparisSec.Name = "cmbSiparisSec";
            this.cmbSiparisSec.Size = new System.Drawing.Size(315, 28);
            this.cmbSiparisSec.TabIndex = 1;
            // 
            // grpBoyut
            // 
            this.grpBoyut.Controls.Add(this.rdBuyuk);
            this.grpBoyut.Controls.Add(this.rdKucuk);
            this.grpBoyut.Controls.Add(this.rdOrta);
            this.grpBoyut.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoyut.Location = new System.Drawing.Point(6, 270);
            this.grpBoyut.Name = "grpBoyut";
            this.grpBoyut.Size = new System.Drawing.Size(319, 79);
            this.grpBoyut.TabIndex = 2;
            this.grpBoyut.TabStop = false;
            this.grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdBuyuk
            // 
            this.rdBuyuk.AutoSize = true;
            this.rdBuyuk.Location = new System.Drawing.Point(222, 32);
            this.rdBuyuk.Name = "rdBuyuk";
            this.rdBuyuk.Size = new System.Drawing.Size(91, 28);
            this.rdBuyuk.TabIndex = 5;
            this.rdBuyuk.Text = "Büyük";
            this.rdBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdKucuk
            // 
            this.rdKucuk.AutoSize = true;
            this.rdKucuk.Location = new System.Drawing.Point(6, 32);
            this.rdKucuk.Name = "rdKucuk";
            this.rdKucuk.Size = new System.Drawing.Size(91, 28);
            this.rdKucuk.TabIndex = 5;
            this.rdKucuk.Text = "Küçük";
            this.rdKucuk.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(123, 32);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(73, 28);
            this.rdOrta.TabIndex = 5;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // lstSiparisiGoster
            // 
            this.lstSiparisiGoster.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisiGoster.FormattingEnabled = true;
            this.lstSiparisiGoster.ItemHeight = 19;
            this.lstSiparisiGoster.Location = new System.Drawing.Point(362, 12);
            this.lstSiparisiGoster.Name = "lstSiparisiGoster";
            this.lstSiparisiGoster.Size = new System.Drawing.Size(738, 574);
            this.lstSiparisiGoster.TabIndex = 5;
            // 
            // nudSiparisAdedi
            // 
            this.nudSiparisAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudSiparisAdedi.Location = new System.Drawing.Point(82, 644);
            this.nudSiparisAdedi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSiparisAdedi.Name = "nudSiparisAdedi";
            this.nudSiparisAdedi.Size = new System.Drawing.Size(243, 26);
            this.nudSiparisAdedi.TabIndex = 4;
            this.nudSiparisAdedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSiparisAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(12, 689);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(319, 56);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "SİPARİŞ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(358, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // btnTamamla
            // 
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(798, 613);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(302, 123);
            this.btnTamamla.TabIndex = 6;
            this.btnTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADET";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.Red;
            this.lblFiyat.Location = new System.Drawing.Point(552, 613);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(61, 24);
            this.lblFiyat.TabIndex = 9;
            this.lblFiyat.Text = "₺0,00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ornek.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpMenuSecim
            // 
            this.grpMenuSecim.Controls.Add(this.nudSiparisAdedi);
            this.grpMenuSecim.Controls.Add(this.label3);
            this.grpMenuSecim.Controls.Add(this.grpBoyut);
            this.grpMenuSecim.Controls.Add(this.cmbSiparisSec);
            this.grpMenuSecim.Controls.Add(this.label2);
            this.grpMenuSecim.Controls.Add(this.label1);
            this.grpMenuSecim.Controls.Add(this.pictureBox1);
            this.grpMenuSecim.Controls.Add(this.flpMalzemeler);
            this.grpMenuSecim.Location = new System.Drawing.Point(6, 7);
            this.grpMenuSecim.Name = "grpMenuSecim";
            this.grpMenuSecim.Size = new System.Drawing.Size(334, 682);
            this.grpMenuSecim.TabIndex = 10;
            this.grpMenuSecim.TabStop = false;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 757);
            this.Controls.Add(this.grpMenuSecim);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSiparisiGoster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            this.grpBoyut.ResumeLayout(false);
            this.grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiparisAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMenuSecim.ResumeLayout(false);
            this.grpMenuSecim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMalzemeler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSiparisSec;
        private System.Windows.Forms.GroupBox grpBoyut;
        private System.Windows.Forms.RadioButton rdBuyuk;
        private System.Windows.Forms.RadioButton rdKucuk;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSiparisiGoster;
        private System.Windows.Forms.NumericUpDown nudSiparisAdedi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.GroupBox grpMenuSecim;
    }
}