namespace HakemFiksturOtomasyon.View.StadFile
{
    partial class StadAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StadAnaForm));
            this.duzenleTab = new System.Windows.Forms.TabPage();
            this.btnHakem2 = new System.Windows.Forms.Button();
            this.btnTakim2 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.dtGridStad = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lbArama = new System.Windows.Forms.Label();
            this.ekleTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eklePanel = new System.Windows.Forms.Panel();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.lbDiger = new System.Windows.Forms.Label();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lbSehir = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.btnHakem = new System.Windows.Forms.Button();
            this.btnTakim = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.duzenleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStad)).BeginInit();
            this.ekleTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.eklePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // duzenleTab
            // 
            this.duzenleTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.duzenleTab.Controls.Add(this.btnHakem2);
            this.duzenleTab.Controls.Add(this.btnTakim2);
            this.duzenleTab.Controls.Add(this.btnSil);
            this.duzenleTab.Controls.Add(this.btnDuzenle);
            this.duzenleTab.Controls.Add(this.dtGridStad);
            this.duzenleTab.Controls.Add(this.txtArama);
            this.duzenleTab.Controls.Add(this.lbArama);
            this.duzenleTab.Location = new System.Drawing.Point(4, 29);
            this.duzenleTab.Name = "duzenleTab";
            this.duzenleTab.Padding = new System.Windows.Forms.Padding(3);
            this.duzenleTab.Size = new System.Drawing.Size(540, 389);
            this.duzenleTab.TabIndex = 1;
            this.duzenleTab.Text = "Düzenleme";
            // 
            // btnHakem2
            // 
            this.btnHakem2.AutoSize = true;
            this.btnHakem2.Location = new System.Drawing.Point(6, 352);
            this.btnHakem2.Name = "btnHakem2";
            this.btnHakem2.Size = new System.Drawing.Size(117, 34);
            this.btnHakem2.TabIndex = 6;
            this.btnHakem2.Text = "Hakem Formu";
            this.btnHakem2.UseVisualStyleBackColor = true;
            this.btnHakem2.Click += new System.EventHandler(this.btnHakem2_Click);
            // 
            // btnTakim2
            // 
            this.btnTakim2.AutoSize = true;
            this.btnTakim2.Location = new System.Drawing.Point(419, 352);
            this.btnTakim2.Name = "btnTakim2";
            this.btnTakim2.Size = new System.Drawing.Size(115, 34);
            this.btnTakim2.TabIndex = 5;
            this.btnTakim2.Text = "Takim Formu";
            this.btnTakim2.UseVisualStyleBackColor = true;
            this.btnTakim2.Click += new System.EventHandler(this.btnTakim2_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(279, 317);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(164, 317);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(97, 34);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // dtGridStad
            // 
            this.dtGridStad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridStad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridStad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridStad.Location = new System.Drawing.Point(8, 59);
            this.dtGridStad.Name = "dtGridStad";
            this.dtGridStad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridStad.Size = new System.Drawing.Size(524, 252);
            this.dtGridStad.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(164, 15);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(283, 25);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lbArama
            // 
            this.lbArama.AutoSize = true;
            this.lbArama.Location = new System.Drawing.Point(79, 18);
            this.lbArama.Name = "lbArama";
            this.lbArama.Size = new System.Drawing.Size(70, 20);
            this.lbArama.TabIndex = 0;
            this.lbArama.Text = "Arama : ";
            // 
            // ekleTab
            // 
            this.ekleTab.BackColor = System.Drawing.Color.White;
            this.ekleTab.Controls.Add(this.label3);
            this.ekleTab.Controls.Add(this.label2);
            this.ekleTab.Controls.Add(this.label1);
            this.ekleTab.Controls.Add(this.groupBox1);
            this.ekleTab.Controls.Add(this.btnHakem);
            this.ekleTab.Controls.Add(this.btnTakim);
            this.ekleTab.Location = new System.Drawing.Point(4, 29);
            this.ekleTab.Name = "ekleTab";
            this.ekleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ekleTab.Size = new System.Drawing.Size(540, 389);
            this.ekleTab.TabIndex = 0;
            this.ekleTab.Text = "Ekleme";
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 74);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(478, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 82);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(262, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 69);
            this.label1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eklePanel);
            this.groupBox1.Location = new System.Drawing.Point(55, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stad Ekleme Ekranı";
            // 
            // eklePanel
            // 
            this.eklePanel.Controls.Add(this.txtDiger);
            this.eklePanel.Controls.Add(this.lbDiger);
            this.eklePanel.Controls.Add(this.btnEkleme);
            this.eklePanel.Controls.Add(this.comboSehir);
            this.eklePanel.Controls.Add(this.txtAd);
            this.eklePanel.Controls.Add(this.lbSehir);
            this.eklePanel.Controls.Add(this.lbAd);
            this.eklePanel.Location = new System.Drawing.Point(22, 24);
            this.eklePanel.Name = "eklePanel";
            this.eklePanel.Size = new System.Drawing.Size(379, 230);
            this.eklePanel.TabIndex = 4;
            // 
            // txtDiger
            // 
            this.txtDiger.Location = new System.Drawing.Point(110, 138);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(207, 25);
            this.txtDiger.TabIndex = 2;
            // 
            // lbDiger
            // 
            this.lbDiger.AutoSize = true;
            this.lbDiger.Location = new System.Drawing.Point(30, 138);
            this.lbDiger.Name = "lbDiger";
            this.lbDiger.Size = new System.Drawing.Size(62, 20);
            this.lbDiger.TabIndex = 7;
            this.lbDiger.Text = "Diğer : ";
            // 
            // btnEkleme
            // 
            this.btnEkleme.Location = new System.Drawing.Point(262, 179);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(104, 34);
            this.btnEkleme.TabIndex = 3;
            this.btnEkleme.Text = "Ekle";
            this.btnEkleme.UseVisualStyleBackColor = true;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Location = new System.Drawing.Point(110, 80);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(207, 28);
            this.comboSehir.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(113, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(204, 25);
            this.txtAd.TabIndex = 0;
            // 
            // lbSehir
            // 
            this.lbSehir.AutoSize = true;
            this.lbSehir.Location = new System.Drawing.Point(34, 83);
            this.lbSehir.Name = "lbSehir";
            this.lbSehir.Size = new System.Drawing.Size(61, 20);
            this.lbSehir.TabIndex = 1;
            this.lbSehir.Text = "Şehir : ";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(36, 30);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(44, 20);
            this.lbAd.TabIndex = 0;
            this.lbAd.Text = "Ad : ";
            // 
            // btnHakem
            // 
            this.btnHakem.AutoSize = true;
            this.btnHakem.Location = new System.Drawing.Point(6, 352);
            this.btnHakem.Name = "btnHakem";
            this.btnHakem.Size = new System.Drawing.Size(117, 34);
            this.btnHakem.TabIndex = 4;
            this.btnHakem.Text = "Hakem Formu";
            this.btnHakem.UseVisualStyleBackColor = true;
            this.btnHakem.Click += new System.EventHandler(this.btnHakem_Click);
            // 
            // btnTakim
            // 
            this.btnTakim.AutoSize = true;
            this.btnTakim.Location = new System.Drawing.Point(419, 352);
            this.btnTakim.Name = "btnTakim";
            this.btnTakim.Size = new System.Drawing.Size(115, 34);
            this.btnTakim.TabIndex = 2;
            this.btnTakim.Text = "Takim Formu";
            this.btnTakim.UseVisualStyleBackColor = true;
            this.btnTakim.Click += new System.EventHandler(this.btnTakim_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ekleTab);
            this.tabControl.Controls.Add(this.duzenleTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(548, 422);
            this.tabControl.TabIndex = 1;
            // 
            // StadAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 422);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StadAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StadAnaForm";
            this.Load += new System.EventHandler(this.StadAnaForm_Load);
            this.duzenleTab.ResumeLayout(false);
            this.duzenleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStad)).EndInit();
            this.ekleTab.ResumeLayout(false);
            this.ekleTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.eklePanel.ResumeLayout(false);
            this.eklePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage duzenleTab;
        private System.Windows.Forms.Button btnTakim2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.DataGridView dtGridStad;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lbArama;
        private System.Windows.Forms.TabPage ekleTab;
        private System.Windows.Forms.Button btnTakim;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnHakem2;
        private System.Windows.Forms.Button btnHakem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel eklePanel;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.Label lbDiger;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lbSehir;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;


    }
}