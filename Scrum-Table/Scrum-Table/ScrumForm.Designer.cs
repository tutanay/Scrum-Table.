namespace Scrum_Table
{
    partial class ScrumForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHikaye = new System.Windows.Forms.Panel();
            this.pnlBasla = new System.Windows.Forms.Panel();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.pnlYapim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHikaye = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtYapim = new System.Windows.Forms.TextBox();
            this.txtBasla = new System.Windows.Forms.TextBox();
            this.pnlTamam = new System.Windows.Forms.Panel();
            this.txtTamam = new System.Windows.Forms.TextBox();
            this.btnHikaye = new System.Windows.Forms.Button();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlHikaye
            // 
            this.pnlHikaye.Location = new System.Drawing.Point(231, 133);
            this.pnlHikaye.Name = "pnlHikaye";
            this.pnlHikaye.Size = new System.Drawing.Size(202, 376);
            this.pnlHikaye.TabIndex = 0;
            // 
            // pnlBasla
            // 
            this.pnlBasla.Location = new System.Drawing.Point(456, 133);
            this.pnlBasla.Name = "pnlBasla";
            this.pnlBasla.Size = new System.Drawing.Size(207, 376);
            this.pnlBasla.TabIndex = 1;
            // 
            // pnlTest
            // 
            this.pnlTest.Location = new System.Drawing.Point(920, 133);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(219, 376);
            this.pnlTest.TabIndex = 2;
            // 
            // pnlYapim
            // 
            this.pnlYapim.Location = new System.Drawing.Point(678, 133);
            this.pnlYapim.Name = "pnlYapim";
            this.pnlYapim.Size = new System.Drawing.Size(227, 376);
            this.pnlYapim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // txtHikaye
            // 
            this.txtHikaye.BackColor = System.Drawing.Color.PowderBlue;
            this.txtHikaye.Location = new System.Drawing.Point(231, 34);
            this.txtHikaye.Multiline = true;
            this.txtHikaye.Name = "txtHikaye";
            this.txtHikaye.Size = new System.Drawing.Size(202, 75);
            this.txtHikaye.TabIndex = 5;
            this.txtHikaye.Text = "                       \r\n                 \r\n                   HİKAYE";
            // 
            // txtTest
            // 
            this.txtTest.BackColor = System.Drawing.Color.PowderBlue;
            this.txtTest.Location = new System.Drawing.Point(920, 37);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(219, 75);
            this.txtTest.TabIndex = 6;
            this.txtTest.Text = "\r\n\r\n                        TEST EDİLİYOR";
            // 
            // txtYapim
            // 
            this.txtYapim.BackColor = System.Drawing.Color.PowderBlue;
            this.txtYapim.Location = new System.Drawing.Point(669, 37);
            this.txtYapim.Multiline = true;
            this.txtYapim.Name = "txtYapim";
            this.txtYapim.Size = new System.Drawing.Size(227, 75);
            this.txtYapim.TabIndex = 7;
            this.txtYapim.Text = "\r\n\r\n                YAPIM AŞAMASINDA";
            // 
            // txtBasla
            // 
            this.txtBasla.BackColor = System.Drawing.Color.PowderBlue;
            this.txtBasla.Location = new System.Drawing.Point(456, 37);
            this.txtBasla.Multiline = true;
            this.txtBasla.Name = "txtBasla";
            this.txtBasla.Size = new System.Drawing.Size(207, 75);
            this.txtBasla.TabIndex = 8;
            this.txtBasla.Text = "\r\n\r\n                BAŞLANILMAMIŞ";
            // 
            // pnlTamam
            // 
            this.pnlTamam.Location = new System.Drawing.Point(1163, 133);
            this.pnlTamam.Name = "pnlTamam";
            this.pnlTamam.Size = new System.Drawing.Size(223, 376);
            this.pnlTamam.TabIndex = 3;
            // 
            // txtTamam
            // 
            this.txtTamam.BackColor = System.Drawing.Color.PowderBlue;
            this.txtTamam.Location = new System.Drawing.Point(1163, 37);
            this.txtTamam.Multiline = true;
            this.txtTamam.Name = "txtTamam";
            this.txtTamam.Size = new System.Drawing.Size(223, 75);
            this.txtTamam.TabIndex = 9;
            this.txtTamam.Text = "\r\n\r\n                           TAMAMLANDI";
            // 
            // btnHikaye
            // 
            this.btnHikaye.BackColor = System.Drawing.Color.Indigo;
            this.btnHikaye.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHikaye.Location = new System.Drawing.Point(12, 133);
            this.btnHikaye.Name = "btnHikaye";
            this.btnHikaye.Size = new System.Drawing.Size(169, 75);
            this.btnHikaye.TabIndex = 10;
            this.btnHikaye.Text = "HİKAYE EKLE";
            this.btnHikaye.UseVisualStyleBackColor = false;
            this.btnHikaye.Click += new System.EventHandler(this.btnHikaye_Click_1);
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.BackColor = System.Drawing.Color.Indigo;
            this.btnTaskEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTaskEkle.Location = new System.Drawing.Point(12, 445);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(169, 64);
            this.btnTaskEkle.TabIndex = 11;
            this.btnTaskEkle.Text = "TASK EKLE";
            this.btnTaskEkle.UseVisualStyleBackColor = false;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Indigo;
            this.btnGoster.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoster.Location = new System.Drawing.Point(439, 591);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(700, 72);
            this.btnGoster.TabIndex = 12;
            this.btnGoster.Text = "SCRUM TABLOSUNU GOSTER\r\n";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // ScrumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 661);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.btnHikaye);
            this.Controls.Add(this.txtTamam);
            this.Controls.Add(this.pnlTamam);
            this.Controls.Add(this.txtBasla);
            this.Controls.Add(this.txtYapim);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtHikaye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlYapim);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.pnlBasla);
            this.Controls.Add(this.pnlHikaye);
            this.IsMdiContainer = true;
            this.Name = "ScrumForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScrumForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHikaye;
        private System.Windows.Forms.Panel pnlBasla;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.Panel pnlYapim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHikaye;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtYapim;
        private System.Windows.Forms.TextBox txtBasla;
        private System.Windows.Forms.Panel pnlTamam;
        private System.Windows.Forms.TextBox txtTamam;
        private System.Windows.Forms.Button btnHikaye;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.Button btnGoster;
    }
}

