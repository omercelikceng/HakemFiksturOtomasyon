namespace HakemFiksturOtomasyon.View.AnaFormFile
{
    partial class AnaForm
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
            this.btnStad = new System.Windows.Forms.Button();
            this.btnTakim = new System.Windows.Forms.Button();
            this.btnHakem = new System.Windows.Forms.Button();
            this.btnFikstur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStad
            // 
            this.btnStad.Location = new System.Drawing.Point(12, 91);
            this.btnStad.Name = "btnStad";
            this.btnStad.Size = new System.Drawing.Size(138, 46);
            this.btnStad.TabIndex = 3;
            this.btnStad.Text = "Stadyum";
            this.btnStad.UseVisualStyleBackColor = true;
            this.btnStad.Click += new System.EventHandler(this.btnStad_Click);
            // 
            // btnTakim
            // 
            this.btnTakim.Location = new System.Drawing.Point(219, 91);
            this.btnTakim.Name = "btnTakim";
            this.btnTakim.Size = new System.Drawing.Size(138, 46);
            this.btnTakim.TabIndex = 2;
            this.btnTakim.Text = "Takim";
            this.btnTakim.UseVisualStyleBackColor = true;
            this.btnTakim.Click += new System.EventHandler(this.btnTakim_Click);
            // 
            // btnHakem
            // 
            this.btnHakem.Location = new System.Drawing.Point(122, 29);
            this.btnHakem.Name = "btnHakem";
            this.btnHakem.Size = new System.Drawing.Size(138, 46);
            this.btnHakem.TabIndex = 4;
            this.btnHakem.Text = "Hakem";
            this.btnHakem.UseVisualStyleBackColor = true;
            this.btnHakem.Click += new System.EventHandler(this.btnHakem_Click);
            // 
            // btnFikstur
            // 
            this.btnFikstur.Location = new System.Drawing.Point(122, 150);
            this.btnFikstur.Name = "btnFikstur";
            this.btnFikstur.Size = new System.Drawing.Size(138, 46);
            this.btnFikstur.TabIndex = 5;
            this.btnFikstur.Text = "Fikstür";
            this.btnFikstur.UseVisualStyleBackColor = true;
            this.btnFikstur.Click += new System.EventHandler(this.btnFikstur_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 221);
            this.Controls.Add(this.btnFikstur);
            this.Controls.Add(this.btnHakem);
            this.Controls.Add(this.btnStad);
            this.Controls.Add(this.btnTakim);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStad;
        private System.Windows.Forms.Button btnTakim;
        private System.Windows.Forms.Button btnHakem;
        private System.Windows.Forms.Button btnFikstur;
    }
}