namespace Scrum_Table
{
    partial class HikayeForm
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
            this.txthbaslik = new System.Windows.Forms.TextBox();
            this.txthyazar = new System.Windows.Forms.TextBox();
            this.txthaciklama = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnHikayeEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthbaslik
            // 
            this.txthbaslik.Location = new System.Drawing.Point(170, 93);
            this.txthbaslik.Multiline = true;
            this.txthbaslik.Name = "txthbaslik";
            this.txthbaslik.Size = new System.Drawing.Size(135, 26);
            this.txthbaslik.TabIndex = 0;
            // 
            // txthyazar
            // 
            this.txthyazar.Location = new System.Drawing.Point(170, 194);
            this.txthyazar.Multiline = true;
            this.txthyazar.Name = "txthyazar";
            this.txthyazar.Size = new System.Drawing.Size(135, 28);
            this.txthyazar.TabIndex = 1;
            // 
            // txthaciklama
            // 
            this.txthaciklama.Location = new System.Drawing.Point(445, 127);
            this.txthaciklama.Multiline = true;
            this.txthaciklama.Name = "txthaciklama";
            this.txthaciklama.Size = new System.Drawing.Size(262, 213);
            this.txthaciklama.TabIndex = 2;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.MistyRose;
            this.lblBaslik.Location = new System.Drawing.Point(50, 96);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(73, 13);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Hikaye Başlığı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.BackColor = System.Drawing.Color.MistyRose;
            this.lblYazar.Location = new System.Drawing.Point(50, 197);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(86, 13);
            this.lblYazar.TabIndex = 4;
            this.lblYazar.Text = "Hikayenin Yazarı";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.MistyRose;
            this.lblAciklama.Location = new System.Drawing.Point(544, 82);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 5;
            this.lblAciklama.Text = "Açıklama";
            // 
            // btnHikayeEkle
            // 
            this.btnHikayeEkle.BackColor = System.Drawing.Color.Indigo;
            this.btnHikayeEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHikayeEkle.Location = new System.Drawing.Point(445, 368);
            this.btnHikayeEkle.Name = "btnHikayeEkle";
            this.btnHikayeEkle.Size = new System.Drawing.Size(262, 47);
            this.btnHikayeEkle.TabIndex = 6;
            this.btnHikayeEkle.Text = "Hikaye Ekle";
            this.btnHikayeEkle.UseVisualStyleBackColor = false;
            this.btnHikayeEkle.Click += new System.EventHandler(this.btnHikayeEkle_Click);
            // 
            // HikayeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHikayeEkle);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txthaciklama);
            this.Controls.Add(this.txthyazar);
            this.Controls.Add(this.txthbaslik);
            this.Name = "HikayeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hikaye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthbaslik;
        private System.Windows.Forms.TextBox txthyazar;
        private System.Windows.Forms.TextBox txthaciklama;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnHikayeEkle;
    }
}