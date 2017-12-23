namespace HakemFiksturOtomasyon.View.HakemFile
{
    partial class HakemGuncelleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboOrtaHakem = new System.Windows.Forms.ComboBox();
            this.lbOrtaHakem = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.comboBolge = new System.Windows.Forms.ComboBox();
            this.lbBolge = new System.Windows.Forms.Label();
            this.comboKlasman = new System.Windows.Forms.ComboBox();
            this.lbKlasman = new System.Windows.Forms.Label();
            this.comboTuru = new System.Windows.Forms.ComboBox();
            this.lbTuru = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.comboBolge);
            this.panel1.Controls.Add(this.lbBolge);
            this.panel1.Controls.Add(this.comboKlasman);
            this.panel1.Controls.Add(this.lbKlasman);
            this.panel1.Controls.Add(this.comboTuru);
            this.panel1.Controls.Add(this.lbTuru);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.lbSoyad);
            this.panel1.Controls.Add(this.lbAd);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 334);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboOrtaHakem);
            this.panel2.Controls.Add(this.lbOrtaHakem);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(22, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 53);
            this.panel2.TabIndex = 39;
            // 
            // comboOrtaHakem
            // 
            this.comboOrtaHakem.FormattingEnabled = true;
            this.comboOrtaHakem.Items.AddRange(new object[] {
            "Amatör Maç Hakemliği",
            "İl Hakemliği",
            "Uluslararası Hakemlik",
            "Farketmez"});
            this.comboOrtaHakem.Location = new System.Drawing.Point(120, 16);
            this.comboOrtaHakem.Name = "comboOrtaHakem";
            this.comboOrtaHakem.Size = new System.Drawing.Size(188, 28);
            this.comboOrtaHakem.TabIndex = 16;
            // 
            // lbOrtaHakem
            // 
            this.lbOrtaHakem.AutoSize = true;
            this.lbOrtaHakem.Location = new System.Drawing.Point(15, 24);
            this.lbOrtaHakem.Name = "lbOrtaHakem";
            this.lbOrtaHakem.Size = new System.Drawing.Size(99, 20);
            this.lbOrtaHakem.TabIndex = 15;
            this.lbOrtaHakem.Text = "Üst Hakemi :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(166, 271);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 38);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // comboBolge
            // 
            this.comboBolge.FormattingEnabled = true;
            this.comboBolge.Items.AddRange(new object[] {
            "Amatör Maç Hakemliği",
            "İl Hakemliği",
            "Uluslararası Hakemlik",
            "Farketmez"});
            this.comboBolge.Location = new System.Drawing.Point(143, 178);
            this.comboBolge.Name = "comboBolge";
            this.comboBolge.Size = new System.Drawing.Size(188, 28);
            this.comboBolge.TabIndex = 37;
            // 
            // lbBolge
            // 
            this.lbBolge.AutoSize = true;
            this.lbBolge.Location = new System.Drawing.Point(34, 186);
            this.lbBolge.Name = "lbBolge";
            this.lbBolge.Size = new System.Drawing.Size(63, 20);
            this.lbBolge.TabIndex = 36;
            this.lbBolge.Text = "Bölge : ";
            // 
            // comboKlasman
            // 
            this.comboKlasman.FormattingEnabled = true;
            this.comboKlasman.Items.AddRange(new object[] {
            "FIFA Hakemi",
            "Üst Klasman Hakemi",
            "FIFA Yardımcı Hakemi",
            "Üst Klasman Yardımcı Hakemi",
            "Ulusal Hakem",
            "Ulusal Yardımcı Hakem",
            "Bayan FIFA Hakemi",
            "Bayan FIFA Yardımcı Hakemi",
            "Bayan Bölgesel Hakem",
            "Bölgesel Hakem",
            "Bölgesel Yardımcı Hakem"});
            this.comboKlasman.Location = new System.Drawing.Point(143, 141);
            this.comboKlasman.Name = "comboKlasman";
            this.comboKlasman.Size = new System.Drawing.Size(188, 28);
            this.comboKlasman.TabIndex = 35;
            // 
            // lbKlasman
            // 
            this.lbKlasman.AutoSize = true;
            this.lbKlasman.Location = new System.Drawing.Point(29, 144);
            this.lbKlasman.Name = "lbKlasman";
            this.lbKlasman.Size = new System.Drawing.Size(86, 20);
            this.lbKlasman.TabIndex = 34;
            this.lbKlasman.Text = "Klasmani : ";
            // 
            // comboTuru
            // 
            this.comboTuru.FormattingEnabled = true;
            this.comboTuru.Items.AddRange(new object[] {
            "Orta Hakem",
            "Yardımcı Hakem",
            "4. Hakem"});
            this.comboTuru.Location = new System.Drawing.Point(143, 97);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(188, 28);
            this.comboTuru.TabIndex = 33;
            this.comboTuru.SelectedIndexChanged += new System.EventHandler(this.comboTuru_SelectedIndexChanged);
            // 
            // lbTuru
            // 
            this.lbTuru.AutoSize = true;
            this.lbTuru.Location = new System.Drawing.Point(50, 100);
            this.lbTuru.Name = "lbTuru";
            this.lbTuru.Size = new System.Drawing.Size(58, 20);
            this.lbTuru.TabIndex = 32;
            this.lbTuru.Text = "Türü : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(143, 58);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(188, 25);
            this.txtSoyad.TabIndex = 31;
            // 
            // lbSoyad
            // 
            this.lbSoyad.AutoSize = true;
            this.lbSoyad.Location = new System.Drawing.Point(50, 58);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(65, 20);
            this.lbSoyad.TabIndex = 30;
            this.lbSoyad.Text = "Soyadi :";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(67, 26);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(48, 20);
            this.lbAd.TabIndex = 28;
            this.lbAd.Text = "Adi : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(143, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(188, 25);
            this.txtAd.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hakem Güncelleme Ekranı";
            // 
            // HakemGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "HakemGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HakemGuncelleForm";
            this.Load += new System.EventHandler(this.HakemGuncelleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboOrtaHakem;
        private System.Windows.Forms.Label lbOrtaHakem;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox comboBolge;
        private System.Windows.Forms.Label lbBolge;
        private System.Windows.Forms.ComboBox comboKlasman;
        private System.Windows.Forms.Label lbKlasman;
        private System.Windows.Forms.ComboBox comboTuru;
        private System.Windows.Forms.Label lbTuru;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;

    }
}