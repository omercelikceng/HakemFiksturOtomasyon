namespace HakemFiksturOtomasyon.View.TakimFile
{
    partial class TakimGuncelleForm
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
            this.comboLig = new System.Windows.Forms.ComboBox();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lbLig = new System.Windows.Forms.Label();
            this.lbDiger = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.lbBilgi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTamam);
            this.panel1.Controls.Add(this.comboLig);
            this.panel1.Controls.Add(this.txtDiger);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.lbLig);
            this.panel1.Controls.Add(this.lbDiger);
            this.panel1.Controls.Add(this.lbAd);
            this.panel1.Location = new System.Drawing.Point(22, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 245);
            this.panel1.TabIndex = 11;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(122, 195);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(98, 32);
            this.btnTamam.TabIndex = 19;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // comboLig
            // 
            this.comboLig.FormattingEnabled = true;
            this.comboLig.Location = new System.Drawing.Point(122, 85);
            this.comboLig.Name = "comboLig";
            this.comboLig.Size = new System.Drawing.Size(173, 28);
            this.comboLig.TabIndex = 18;
            // 
            // txtDiger
            // 
            this.txtDiger.Location = new System.Drawing.Point(122, 145);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(173, 25);
            this.txtDiger.TabIndex = 16;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(122, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(173, 25);
            this.txtAd.TabIndex = 15;
            // 
            // lbLig
            // 
            this.lbLig.AutoSize = true;
            this.lbLig.Location = new System.Drawing.Point(36, 88);
            this.lbLig.Name = "lbLig";
            this.lbLig.Size = new System.Drawing.Size(40, 20);
            this.lbLig.TabIndex = 13;
            this.lbLig.Text = "Lig :";
            // 
            // lbDiger
            // 
            this.lbDiger.AutoSize = true;
            this.lbDiger.Location = new System.Drawing.Point(27, 148);
            this.lbDiger.Name = "lbDiger";
            this.lbDiger.Size = new System.Drawing.Size(57, 20);
            this.lbDiger.TabIndex = 12;
            this.lbDiger.Text = "Diğer :";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(36, 35);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(44, 20);
            this.lbAd.TabIndex = 11;
            this.lbAd.Text = "Ad : ";
            // 
            // lbBilgi
            // 
            this.lbBilgi.AutoSize = true;
            this.lbBilgi.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.lbBilgi.Location = new System.Drawing.Point(83, 27);
            this.lbBilgi.Name = "lbBilgi";
            this.lbBilgi.Size = new System.Drawing.Size(220, 23);
            this.lbBilgi.TabIndex = 10;
            this.lbBilgi.Text = "Takım Güncelleme Ekranı";
            // 
            // TakimGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBilgi);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TakimGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakimGuncelleForm";
            this.Load += new System.EventHandler(this.TakimGuncelleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.ComboBox comboLig;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lbLig;
        private System.Windows.Forms.Label lbDiger;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbBilgi;
    }
}