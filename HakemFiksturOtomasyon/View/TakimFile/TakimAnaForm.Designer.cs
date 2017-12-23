namespace HakemFiksturOtomasyon.View.TakimFile
{
    partial class TakimAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakimAnaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grBoxBilgi = new System.Windows.Forms.GroupBox();
            this.pnlSpEkle = new System.Windows.Forms.Panel();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.comboLig = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lbDiger = new System.Windows.Forms.Label();
            this.lbLig = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.btnHakem = new System.Windows.Forms.Button();
            this.btnStad = new System.Windows.Forms.Button();
            this.tabDuzenle = new System.Windows.Forms.TabPage();
            this.btnHakem2 = new System.Windows.Forms.Button();
            this.btnStad2 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.dtGridTakim = new System.Windows.Forms.DataGridView();
            this.lbArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.grBoxBilgi.SuspendLayout();
            this.pnlSpEkle.SuspendLayout();
            this.tabDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTakim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabDuzenle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEkle
            // 
            this.tabEkle.Controls.Add(this.label3);
            this.tabEkle.Controls.Add(this.label2);
            this.tabEkle.Controls.Add(this.label1);
            this.tabEkle.Controls.Add(this.grBoxBilgi);
            this.tabEkle.Controls.Add(this.btnHakem);
            this.tabEkle.Controls.Add(this.btnStad);
            this.tabEkle.Location = new System.Drawing.Point(4, 29);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(501, 428);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekleme";
            this.tabEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(181, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 71);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 60);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(392, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 74);
            this.label1.TabIndex = 9;
            // 
            // grBoxBilgi
            // 
            this.grBoxBilgi.Controls.Add(this.pnlSpEkle);
            this.grBoxBilgi.Location = new System.Drawing.Point(30, 77);
            this.grBoxBilgi.Name = "grBoxBilgi";
            this.grBoxBilgi.Size = new System.Drawing.Size(432, 300);
            this.grBoxBilgi.TabIndex = 8;
            this.grBoxBilgi.TabStop = false;
            this.grBoxBilgi.Text = "Takım Ekleme Ekranı";
            // 
            // pnlSpEkle
            // 
            this.pnlSpEkle.Controls.Add(this.txtDiger);
            this.pnlSpEkle.Controls.Add(this.btnEkle);
            this.pnlSpEkle.Controls.Add(this.comboLig);
            this.pnlSpEkle.Controls.Add(this.txtAd);
            this.pnlSpEkle.Controls.Add(this.lbDiger);
            this.pnlSpEkle.Controls.Add(this.lbLig);
            this.pnlSpEkle.Controls.Add(this.lbAd);
            this.pnlSpEkle.Location = new System.Drawing.Point(27, 24);
            this.pnlSpEkle.Name = "pnlSpEkle";
            this.pnlSpEkle.Size = new System.Drawing.Size(388, 247);
            this.pnlSpEkle.TabIndex = 5;
            // 
            // txtDiger
            // 
            this.txtDiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDiger.Location = new System.Drawing.Point(111, 152);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(206, 27);
            this.txtDiger.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(263, 205);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 35);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // comboLig
            // 
            this.comboLig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboLig.FormattingEnabled = true;
            this.comboLig.Location = new System.Drawing.Point(111, 95);
            this.comboLig.Name = "comboLig";
            this.comboLig.Size = new System.Drawing.Size(206, 28);
            this.comboLig.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(111, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(206, 27);
            this.txtAd.TabIndex = 0;
            // 
            // lbDiger
            // 
            this.lbDiger.AutoSize = true;
            this.lbDiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDiger.Location = new System.Drawing.Point(28, 155);
            this.lbDiger.Name = "lbDiger";
            this.lbDiger.Size = new System.Drawing.Size(67, 20);
            this.lbDiger.TabIndex = 3;
            this.lbDiger.Text = "Diğer :";
            // 
            // lbLig
            // 
            this.lbLig.AutoSize = true;
            this.lbLig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLig.Location = new System.Drawing.Point(42, 98);
            this.lbLig.Name = "lbLig";
            this.lbLig.Size = new System.Drawing.Size(53, 20);
            this.lbLig.TabIndex = 2;
            this.lbLig.Text = "Lig : ";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAd.Location = new System.Drawing.Point(46, 38);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(49, 20);
            this.lbAd.TabIndex = 0;
            this.lbAd.Text = "Ad : ";
            // 
            // btnHakem
            // 
            this.btnHakem.AutoSize = true;
            this.btnHakem.Location = new System.Drawing.Point(8, 384);
            this.btnHakem.Name = "btnHakem";
            this.btnHakem.Size = new System.Drawing.Size(120, 36);
            this.btnHakem.TabIndex = 7;
            this.btnHakem.Text = "Hakem Formu";
            this.btnHakem.UseVisualStyleBackColor = true;
            this.btnHakem.Click += new System.EventHandler(this.btnHakem_Click);
            // 
            // btnStad
            // 
            this.btnStad.Location = new System.Drawing.Point(375, 383);
            this.btnStad.Name = "btnStad";
            this.btnStad.Size = new System.Drawing.Size(122, 36);
            this.btnStad.TabIndex = 6;
            this.btnStad.Text = "Stad Formu";
            this.btnStad.UseVisualStyleBackColor = true;
            this.btnStad.Click += new System.EventHandler(this.btnStad_Click);
            // 
            // tabDuzenle
            // 
            this.tabDuzenle.Controls.Add(this.btnHakem2);
            this.tabDuzenle.Controls.Add(this.btnStad2);
            this.tabDuzenle.Controls.Add(this.btnSil);
            this.tabDuzenle.Controls.Add(this.btnDuzenle);
            this.tabDuzenle.Controls.Add(this.dtGridTakim);
            this.tabDuzenle.Controls.Add(this.lbArama);
            this.tabDuzenle.Controls.Add(this.txtArama);
            this.tabDuzenle.Location = new System.Drawing.Point(4, 29);
            this.tabDuzenle.Name = "tabDuzenle";
            this.tabDuzenle.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuzenle.Size = new System.Drawing.Size(501, 428);
            this.tabDuzenle.TabIndex = 1;
            this.tabDuzenle.Text = "Düzenleme";
            this.tabDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnHakem2
            // 
            this.btnHakem2.AutoSize = true;
            this.btnHakem2.Location = new System.Drawing.Point(8, 384);
            this.btnHakem2.Name = "btnHakem2";
            this.btnHakem2.Size = new System.Drawing.Size(120, 36);
            this.btnHakem2.TabIndex = 12;
            this.btnHakem2.Text = "Hakem Formu";
            this.btnHakem2.UseVisualStyleBackColor = true;
            this.btnHakem2.Click += new System.EventHandler(this.btnHakem2_Click);
            // 
            // btnStad2
            // 
            this.btnStad2.AutoSize = true;
            this.btnStad2.Location = new System.Drawing.Point(383, 383);
            this.btnStad2.Name = "btnStad2";
            this.btnStad2.Size = new System.Drawing.Size(114, 36);
            this.btnStad2.TabIndex = 11;
            this.btnStad2.Text = "Stad Formu";
            this.btnStad2.UseVisualStyleBackColor = true;
            this.btnStad2.Click += new System.EventHandler(this.btnStad2_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(262, 343);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 34);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(151, 343);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(105, 34);
            this.btnDuzenle.TabIndex = 9;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // dtGridTakim
            // 
            this.dtGridTakim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridTakim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridTakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTakim.Location = new System.Drawing.Point(21, 59);
            this.dtGridTakim.Name = "dtGridTakim";
            this.dtGridTakim.ReadOnly = true;
            this.dtGridTakim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridTakim.Size = new System.Drawing.Size(461, 278);
            this.dtGridTakim.TabIndex = 8;
            // 
            // lbArama
            // 
            this.lbArama.AutoSize = true;
            this.lbArama.Location = new System.Drawing.Point(53, 26);
            this.lbArama.Name = "lbArama";
            this.lbArama.Size = new System.Drawing.Size(70, 20);
            this.lbArama.TabIndex = 7;
            this.lbArama.Text = "Arama : ";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(129, 23);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(283, 25);
            this.txtArama.TabIndex = 6;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // TakimAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TakimAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakimAnaForm";
            this.Load += new System.EventHandler(this.TakimAnaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.grBoxBilgi.ResumeLayout(false);
            this.pnlSpEkle.ResumeLayout(false);
            this.pnlSpEkle.PerformLayout();
            this.tabDuzenle.ResumeLayout(false);
            this.tabDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTakim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.Button btnStad;
        private System.Windows.Forms.TabPage tabDuzenle;
        private System.Windows.Forms.Button btnStad2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.DataGridView dtGridTakim;
        private System.Windows.Forms.Label lbArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnHakem;
        private System.Windows.Forms.Button btnHakem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grBoxBilgi;
        private System.Windows.Forms.Panel pnlSpEkle;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboLig;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lbDiger;
        private System.Windows.Forms.Label lbLig;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}