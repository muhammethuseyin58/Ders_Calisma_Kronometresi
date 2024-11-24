namespace Ders_çalışma_kayıt_programı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Basla = new System.Windows.Forms.Button();
            this.MolaDevam = new System.Windows.Forms.Button();
            this.Bitir = new System.Windows.Forms.Button();
            this.Saat = new System.Windows.Forms.Label();
            this.Dakika = new System.Windows.Forms.Label();
            this.Saniye = new System.Windows.Forms.Label();
            this.SaatDakika = new System.Windows.Forms.Label();
            this.DakikaSaniye = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Timer(this.components);
            this.DersAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gecmis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Basla
            // 
            this.Basla.Enabled = false;
            this.Basla.Location = new System.Drawing.Point(35, 215);
            this.Basla.Name = "Basla";
            this.Basla.Size = new System.Drawing.Size(75, 23);
            this.Basla.TabIndex = 0;
            this.Basla.Text = "Başla";
            this.Basla.UseVisualStyleBackColor = true;
            this.Basla.Click += new System.EventHandler(this.Basla_Click);
            // 
            // MolaDevam
            // 
            this.MolaDevam.Enabled = false;
            this.MolaDevam.Location = new System.Drawing.Point(145, 215);
            this.MolaDevam.Name = "MolaDevam";
            this.MolaDevam.Size = new System.Drawing.Size(75, 23);
            this.MolaDevam.TabIndex = 1;
            this.MolaDevam.Text = "Mola";
            this.MolaDevam.UseVisualStyleBackColor = true;
            this.MolaDevam.Click += new System.EventHandler(this.MolaDevam_Click);
            // 
            // Bitir
            // 
            this.Bitir.Enabled = false;
            this.Bitir.Location = new System.Drawing.Point(263, 215);
            this.Bitir.Name = "Bitir";
            this.Bitir.Size = new System.Drawing.Size(75, 23);
            this.Bitir.TabIndex = 2;
            this.Bitir.Text = "Bitir";
            this.Bitir.UseVisualStyleBackColor = true;
            this.Bitir.Click += new System.EventHandler(this.Bitir_Click);
            // 
            // Saat
            // 
            this.Saat.AutoSize = true;
            this.Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Saat.Location = new System.Drawing.Point(122, 113);
            this.Saat.Name = "Saat";
            this.Saat.Size = new System.Drawing.Size(20, 24);
            this.Saat.TabIndex = 3;
            this.Saat.Text = "0";
            // 
            // Dakika
            // 
            this.Dakika.AutoSize = true;
            this.Dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dakika.Location = new System.Drawing.Point(184, 113);
            this.Dakika.Name = "Dakika";
            this.Dakika.Size = new System.Drawing.Size(20, 24);
            this.Dakika.TabIndex = 3;
            this.Dakika.Text = "0";
            // 
            // Saniye
            // 
            this.Saniye.AutoSize = true;
            this.Saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Saniye.Location = new System.Drawing.Point(246, 113);
            this.Saniye.Name = "Saniye";
            this.Saniye.Size = new System.Drawing.Size(20, 24);
            this.Saniye.TabIndex = 3;
            this.Saniye.Text = "0";
            // 
            // SaatDakika
            // 
            this.SaatDakika.AutoSize = true;
            this.SaatDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatDakika.Location = new System.Drawing.Point(156, 113);
            this.SaatDakika.Name = "SaatDakika";
            this.SaatDakika.Size = new System.Drawing.Size(14, 20);
            this.SaatDakika.TabIndex = 4;
            this.SaatDakika.Text = ":";
            // 
            // DakikaSaniye
            // 
            this.DakikaSaniye.AutoSize = true;
            this.DakikaSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DakikaSaniye.Location = new System.Drawing.Point(218, 113);
            this.DakikaSaniye.Name = "DakikaSaniye";
            this.DakikaSaniye.Size = new System.Drawing.Size(14, 20);
            this.DakikaSaniye.TabIndex = 4;
            this.DakikaSaniye.Text = ":";
            // 
            // sure
            // 
            this.sure.Interval = 1000;
            this.sure.Tick += new System.EventHandler(this.sure_Tick);
            // 
            // DersAd
            // 
            this.DersAd.Location = new System.Drawing.Point(116, 37);
            this.DersAd.MaxLength = 20;
            this.DersAd.Name = "DersAd";
            this.DersAd.Size = new System.Drawing.Size(154, 20);
            this.DersAd.TabIndex = 5;
            this.DersAd.TextChanged += new System.EventHandler(this.DersAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ders Adı";
            // 
            // Gecmis
            // 
            this.Gecmis.Location = new System.Drawing.Point(299, 12);
            this.Gecmis.Name = "Gecmis";
            this.Gecmis.Size = new System.Drawing.Size(75, 35);
            this.Gecmis.TabIndex = 7;
            this.Gecmis.Text = "Ders Geçmişi";
            this.Gecmis.UseVisualStyleBackColor = true;
            this.Gecmis.Click += new System.EventHandler(this.Gecmis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 329);
            this.Controls.Add(this.Gecmis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DersAd);
            this.Controls.Add(this.DakikaSaniye);
            this.Controls.Add(this.SaatDakika);
            this.Controls.Add(this.Saniye);
            this.Controls.Add(this.Dakika);
            this.Controls.Add(this.Saat);
            this.Controls.Add(this.Bitir);
            this.Controls.Add(this.MolaDevam);
            this.Controls.Add(this.Basla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kronometre";
            this.Leave += new System.EventHandler(this.Bitir_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Basla;
        private System.Windows.Forms.Button MolaDevam;
        private System.Windows.Forms.Button Bitir;
        private System.Windows.Forms.Label Saat;
        private System.Windows.Forms.Label Dakika;
        private System.Windows.Forms.Label Saniye;
        private System.Windows.Forms.Label SaatDakika;
        private System.Windows.Forms.Label DakikaSaniye;
        private System.Windows.Forms.Timer sure;
        private System.Windows.Forms.TextBox DersAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gecmis;
    }
}

