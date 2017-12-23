namespace HakemFiksturOtomasyon.View.StadFile
{
    partial class StadGuncelleForm
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.lbDiger = new System.Windows.Forms.Label();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lbSehir = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.lbBilgi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTamam);
            this.panel1.Controls.Add(this.txtDiger);
            this.panel1.Controls.Add(this.lbDiger);
            this.panel1.Controls.Add(this.comboSehir);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.lbSehir);
            this.panel1.Controls.Add(this.lbAd);
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 236);
            this.panel1.TabIndex = 17;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(148, 177);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(94, 31);
            this.btnTamam.TabIndex = 18;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // txtDiger
            // 
            this.txtDiger.Location = new System.Drawing.Point(116, 135);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(166, 25);
            this.txtDiger.TabIndex = 16;
            // 
            // lbDiger
            // 
            this.lbDiger.AutoSize = true;
            this.lbDiger.Location = new System.Drawing.Point(21, 135);
            this.lbDiger.Name = "lbDiger";
            this.lbDiger.Size = new System.Drawing.Size(62, 20);
            this.lbDiger.TabIndex = 15;
            this.lbDiger.Text = "Diğer : ";
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Location = new System.Drawing.Point(116, 76);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(166, 28);
            this.comboSehir.TabIndex = 13;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(116, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(166, 25);
            this.txtAd.TabIndex = 12;
            // 
            // lbSehir
            // 
            this.lbSehir.AutoSize = true;
            this.lbSehir.Location = new System.Drawing.Point(22, 79);
            this.lbSehir.Name = "lbSehir";
            this.lbSehir.Size = new System.Drawing.Size(61, 20);
            this.lbSehir.TabIndex = 10;
            this.lbSehir.Text = "Şehir : ";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(24, 26);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(44, 20);
            this.lbAd.TabIndex = 9;
            this.lbAd.Text = "Ad : ";
            // 
            // lbBilgi
            // 
            this.lbBilgi.AutoSize = true;
            this.lbBilgi.Location = new System.Drawing.Point(76, 38);
            this.lbBilgi.Name = "lbBilgi";
            this.lbBilgi.Size = new System.Drawing.Size(208, 20);
            this.lbBilgi.TabIndex = 17;
            this.lbBilgi.Text = "Stadyum Güncelleme Ekranı";
            // 
            // StadGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 307);
            this.Controls.Add(this.lbBilgi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StadGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StadGuncelleForm";
            this.Load += new System.EventHandler(this.StadGuncelleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.Label lbDiger;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lbSehir;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbBilgi;
        private System.Windows.Forms.Button btnTamam;
    }
}