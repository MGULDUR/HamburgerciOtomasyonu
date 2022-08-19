
namespace Ornek
{
    partial class SiparisBilgileri
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
            this.lstTumSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCiro = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.grpSatilanUrun = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrunAdedi = new System.Windows.Forms.Label();
            this.gepEkstraMalzeme = new System.Windows.Forms.GroupBox();
            this.lblEkstraMalzemeGeliri = new System.Windows.Forms.Label();
            this.grpToplamSiparis = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.grpCiro.SuspendLayout();
            this.grpSatilanUrun.SuspendLayout();
            this.gepEkstraMalzeme.SuspendLayout();
            this.grpToplamSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTumSiparisler
            // 
            this.lstTumSiparisler.FormattingEnabled = true;
            this.lstTumSiparisler.HorizontalScrollbar = true;
            this.lstTumSiparisler.ItemHeight = 21;
            this.lstTumSiparisler.Location = new System.Drawing.Point(11, 66);
            this.lstTumSiparisler.Name = "lstTumSiparisler";
            this.lstTumSiparisler.Size = new System.Drawing.Size(301, 382);
            this.lstTumSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // grpCiro
            // 
            this.grpCiro.Controls.Add(this.lblCiro);
            this.grpCiro.Location = new System.Drawing.Point(353, 66);
            this.grpCiro.Name = "grpCiro";
            this.grpCiro.Size = new System.Drawing.Size(243, 74);
            this.grpCiro.TabIndex = 2;
            this.grpCiro.TabStop = false;
            this.grpCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.ForeColor = System.Drawing.Color.Red;
            this.lblCiro.Location = new System.Drawing.Point(43, 38);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(59, 22);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "₺0,00";
            // 
            // grpSatilanUrun
            // 
            this.grpSatilanUrun.Controls.Add(this.lblSatilanUrunAdedi);
            this.grpSatilanUrun.Location = new System.Drawing.Point(353, 372);
            this.grpSatilanUrun.Name = "grpSatilanUrun";
            this.grpSatilanUrun.Size = new System.Drawing.Size(243, 74);
            this.grpSatilanUrun.TabIndex = 3;
            this.grpSatilanUrun.TabStop = false;
            this.grpSatilanUrun.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            this.lblSatilanUrunAdedi.AutoSize = true;
            this.lblSatilanUrunAdedi.ForeColor = System.Drawing.Color.Red;
            this.lblSatilanUrunAdedi.Location = new System.Drawing.Point(43, 38);
            this.lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            this.lblSatilanUrunAdedi.Size = new System.Drawing.Size(48, 22);
            this.lblSatilanUrunAdedi.TabIndex = 0;
            this.lblSatilanUrunAdedi.Text = "0,00";
            // 
            // gepEkstraMalzeme
            // 
            this.gepEkstraMalzeme.Controls.Add(this.lblEkstraMalzemeGeliri);
            this.gepEkstraMalzeme.Location = new System.Drawing.Point(353, 270);
            this.gepEkstraMalzeme.Name = "gepEkstraMalzeme";
            this.gepEkstraMalzeme.Size = new System.Drawing.Size(243, 74);
            this.gepEkstraMalzeme.TabIndex = 3;
            this.gepEkstraMalzeme.TabStop = false;
            this.gepEkstraMalzeme.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            this.lblEkstraMalzemeGeliri.AutoSize = true;
            this.lblEkstraMalzemeGeliri.ForeColor = System.Drawing.Color.Red;
            this.lblEkstraMalzemeGeliri.Location = new System.Drawing.Point(43, 38);
            this.lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            this.lblEkstraMalzemeGeliri.Size = new System.Drawing.Size(59, 22);
            this.lblEkstraMalzemeGeliri.TabIndex = 0;
            this.lblEkstraMalzemeGeliri.Text = "₺0,00";
            // 
            // grpToplamSiparis
            // 
            this.grpToplamSiparis.Controls.Add(this.lblToplamSiparisSayisi);
            this.grpToplamSiparis.Location = new System.Drawing.Point(353, 168);
            this.grpToplamSiparis.Name = "grpToplamSiparis";
            this.grpToplamSiparis.Size = new System.Drawing.Size(243, 74);
            this.grpToplamSiparis.TabIndex = 3;
            this.grpToplamSiparis.TabStop = false;
            this.grpToplamSiparis.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.AutoSize = true;
            this.lblToplamSiparisSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(43, 38);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(48, 22);
            this.lblToplamSiparisSayisi.TabIndex = 0;
            this.lblToplamSiparisSayisi.Text = "0,00";
            // 
            // SiparisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 465);
            this.Controls.Add(this.grpToplamSiparis);
            this.Controls.Add(this.gepEkstraMalzeme);
            this.Controls.Add(this.grpSatilanUrun);
            this.Controls.Add(this.grpCiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTumSiparisler);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SiparisBilgileri";
            this.Load += new System.EventHandler(this.SiparisBilgileri_Load);
            this.grpCiro.ResumeLayout(false);
            this.grpCiro.PerformLayout();
            this.grpSatilanUrun.ResumeLayout(false);
            this.grpSatilanUrun.PerformLayout();
            this.gepEkstraMalzeme.ResumeLayout(false);
            this.gepEkstraMalzeme.PerformLayout();
            this.grpToplamSiparis.ResumeLayout(false);
            this.grpToplamSiparis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTumSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCiro;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox grpSatilanUrun;
        private System.Windows.Forms.Label lblSatilanUrunAdedi;
        private System.Windows.Forms.GroupBox gepEkstraMalzeme;
        private System.Windows.Forms.Label lblEkstraMalzemeGeliri;
        private System.Windows.Forms.GroupBox grpToplamSiparis;
        private System.Windows.Forms.Label lblToplamSiparisSayisi;
    }
}