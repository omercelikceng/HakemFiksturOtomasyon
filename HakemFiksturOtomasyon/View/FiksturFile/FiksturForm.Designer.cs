namespace HakemFiksturOtomasyon.View.FiksturFile
{
    partial class FiksturForm
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
            this.lbLig = new System.Windows.Forms.Label();
            this.btnFikstur = new System.Windows.Forms.Button();
            this.comboLig = new System.Windows.Forms.ComboBox();
            this.lbTarih = new System.Windows.Forms.Label();
            this.pickerTarih = new System.Windows.Forms.DateTimePicker();
            this.dtGridFikstur = new System.Windows.Forms.DataGridView();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFikstur)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLig
            // 
            this.lbLig.AutoSize = true;
            this.lbLig.Location = new System.Drawing.Point(149, 28);
            this.lbLig.Name = "lbLig";
            this.lbLig.Size = new System.Drawing.Size(45, 20);
            this.lbLig.TabIndex = 0;
            this.lbLig.Text = "Lig : ";
            // 
            // btnFikstur
            // 
            this.btnFikstur.Location = new System.Drawing.Point(640, 69);
            this.btnFikstur.Name = "btnFikstur";
            this.btnFikstur.Size = new System.Drawing.Size(146, 33);
            this.btnFikstur.TabIndex = 1;
            this.btnFikstur.Text = "Oluştur ve Kaydet";
            this.btnFikstur.UseVisualStyleBackColor = true;
            this.btnFikstur.Click += new System.EventHandler(this.btnFikstur_Click);
            // 
            // comboLig
            // 
            this.comboLig.FormattingEnabled = true;
            this.comboLig.Location = new System.Drawing.Point(215, 24);
            this.comboLig.Name = "comboLig";
            this.comboLig.Size = new System.Drawing.Size(168, 28);
            this.comboLig.TabIndex = 2;
            // 
            // lbTarih
            // 
            this.lbTarih.AutoSize = true;
            this.lbTarih.Location = new System.Drawing.Point(389, 28);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(132, 20);
            this.lbTarih.TabIndex = 3;
            this.lbTarih.Text = "Başlangıç Tarihi : ";
            // 
            // pickerTarih
            // 
            this.pickerTarih.CustomFormat = "";
            this.pickerTarih.Location = new System.Drawing.Point(527, 24);
            this.pickerTarih.MinDate = new System.DateTime(2016, 5, 23, 0, 0, 0, 0);
            this.pickerTarih.Name = "pickerTarih";
            this.pickerTarih.Size = new System.Drawing.Size(168, 25);
            this.pickerTarih.TabIndex = 4;
            // 
            // dtGridFikstur
            // 
            this.dtGridFikstur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFikstur.Location = new System.Drawing.Point(24, 123);
            this.dtGridFikstur.Name = "dtGridFikstur";
            this.dtGridFikstur.Size = new System.Drawing.Size(898, 328);
            this.dtGridFikstur.TabIndex = 5;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(232, 69);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(132, 33);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Fikstür Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(433, 69);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 33);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Fikstür Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FiksturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 501);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.dtGridFikstur);
            this.Controls.Add(this.pickerTarih);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.comboLig);
            this.Controls.Add(this.btnFikstur);
            this.Controls.Add(this.lbLig);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FiksturForm";
            this.Text = "FiksturForm";
            this.Load += new System.EventHandler(this.FiksturForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFikstur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLig;
        private System.Windows.Forms.Button btnFikstur;
        private System.Windows.Forms.ComboBox comboLig;
        private System.Windows.Forms.Label lbTarih;
        private System.Windows.Forms.DateTimePicker pickerTarih;
        private System.Windows.Forms.DataGridView dtGridFikstur;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnSil;
    }
}