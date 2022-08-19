
namespace Ornek
{
    partial class EkstraMalzemeEkle
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
            this.grpEkstraMalzeme = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzeme
            // 
            this.grpEkstraMalzeme.Controls.Add(this.btnKaydet);
            this.grpEkstraMalzeme.Controls.Add(this.nudFiyat);
            this.grpEkstraMalzeme.Controls.Add(this.label2);
            this.grpEkstraMalzeme.Controls.Add(this.txtEkstraMalzeme);
            this.grpEkstraMalzeme.Controls.Add(this.label1);
            this.grpEkstraMalzeme.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkstraMalzeme.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzeme.Name = "grpEkstraMalzeme";
            this.grpEkstraMalzeme.Size = new System.Drawing.Size(453, 265);
            this.grpEkstraMalzeme.TabIndex = 0;
            this.grpEkstraMalzeme.TabStop = false;
            this.grpEkstraMalzeme.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(203, 138);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(228, 103);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nudFiyat
            // 
            this.nudFiyat.DecimalPlaces = 2;
            this.nudFiyat.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudFiyat.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudFiyat.Location = new System.Drawing.Point(203, 89);
            this.nudFiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(228, 31);
            this.nudFiyat.TabIndex = 1;
            this.nudFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyatı";
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(203, 34);
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(228, 31);
            this.txtEkstraMalzeme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ekstra Malzeme Adı";
            // 
            // EkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 289);
            this.Controls.Add(this.grpEkstraMalzeme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EkstraMalzemeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EkstraMalzemeEkle";
            this.grpEkstraMalzeme.ResumeLayout(false);
            this.grpEkstraMalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzeme;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEkstraMalzeme;
        private System.Windows.Forms.Label label1;
    }
}