namespace Scrum_Table
{
    partial class GorevForm
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
            this.txtGbaslik = new System.Windows.Forms.TextBox();
            this.txtGaciklama = new System.Windows.Forms.TextBox();
            this.cbsec = new System.Windows.Forms.ComboBox();
            this.lblHikayeSec = new System.Windows.Forms.Label();
            this.lblTaskBaslik = new System.Windows.Forms.Label();
            this.lblAciklama2 = new System.Windows.Forms.Label();
            this.btnTakEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGbaslik
            // 
            this.txtGbaslik.Location = new System.Drawing.Point(57, 151);
            this.txtGbaslik.Name = "txtGbaslik";
            this.txtGbaslik.Size = new System.Drawing.Size(110, 20);
            this.txtGbaslik.TabIndex = 0;
            // 
            // txtGaciklama
            // 
            this.txtGaciklama.Location = new System.Drawing.Point(37, 261);
            this.txtGaciklama.Multiline = true;
            this.txtGaciklama.Name = "txtGaciklama";
            this.txtGaciklama.Size = new System.Drawing.Size(199, 156);
            this.txtGaciklama.TabIndex = 2;
            // 
            // cbsec
            // 
            this.cbsec.FormattingEnabled = true;
            this.cbsec.Location = new System.Drawing.Point(303, 59);
            this.cbsec.Name = "cbsec";
            this.cbsec.Size = new System.Drawing.Size(100, 21);
            this.cbsec.TabIndex = 3;
            // 
            // lblHikayeSec
            // 
            this.lblHikayeSec.AutoSize = true;
            this.lblHikayeSec.BackColor = System.Drawing.Color.MistyRose;
            this.lblHikayeSec.Location = new System.Drawing.Point(321, 29);
            this.lblHikayeSec.Name = "lblHikayeSec";
            this.lblHikayeSec.Size = new System.Drawing.Size(62, 13);
            this.lblHikayeSec.TabIndex = 4;
            this.lblHikayeSec.Text = "Hikaye Seç";
            // 
            // lblTaskBaslik
            // 
            this.lblTaskBaslik.AutoSize = true;
            this.lblTaskBaslik.BackColor = System.Drawing.Color.MistyRose;
            this.lblTaskBaslik.Location = new System.Drawing.Point(79, 108);
            this.lblTaskBaslik.Name = "lblTaskBaslik";
            this.lblTaskBaslik.Size = new System.Drawing.Size(69, 13);
            this.lblTaskBaslik.TabIndex = 5;
            this.lblTaskBaslik.Text = "Görev Başlığı";
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.AutoSize = true;
            this.lblAciklama2.BackColor = System.Drawing.Color.MistyRose;
            this.lblAciklama2.Location = new System.Drawing.Point(89, 221);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama2.TabIndex = 6;
            this.lblAciklama2.Text = "Açıklama";
            // 
            // btnTakEkle
            // 
            this.btnTakEkle.BackColor = System.Drawing.Color.Indigo;
            this.btnTakEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTakEkle.Location = new System.Drawing.Point(338, 151);
            this.btnTakEkle.Name = "btnTakEkle";
            this.btnTakEkle.Size = new System.Drawing.Size(257, 134);
            this.btnTakEkle.TabIndex = 7;
            this.btnTakEkle.Text = "GÖREV EKLE";
            this.btnTakEkle.UseVisualStyleBackColor = false;
            this.btnTakEkle.Click += new System.EventHandler(this.btnTakEkle_Click);
            // 
            // GorevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTakEkle);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.lblTaskBaslik);
            this.Controls.Add(this.lblHikayeSec);
            this.Controls.Add(this.cbsec);
            this.Controls.Add(this.txtGaciklama);
            this.Controls.Add(this.txtGbaslik);
            this.Name = "GorevForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.GorevForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGbaslik;
        private System.Windows.Forms.TextBox txtGaciklama;
        private System.Windows.Forms.ComboBox cbsec;
        private System.Windows.Forms.Label lblHikayeSec;
        private System.Windows.Forms.Label lblTaskBaslik;
        private System.Windows.Forms.Label lblAciklama2;
        private System.Windows.Forms.Button btnTakEkle;
    }
}