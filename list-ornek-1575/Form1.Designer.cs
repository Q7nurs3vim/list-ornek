namespace list_ornek_1575
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbKisiler = new System.Windows.Forms.ListBox();
            this.txtKisiler = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSira = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSilRemove = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSayı = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEkle.Location = new System.Drawing.Point(12, 82);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 26);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbKisiler
            // 
            this.lbKisiler.FormattingEnabled = true;
            this.lbKisiler.Location = new System.Drawing.Point(165, 12);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(120, 303);
            this.lbKisiler.TabIndex = 1;
            this.lbKisiler.SelectedIndexChanged += new System.EventHandler(this.lbKisiler_SelectedIndexChanged);
            // 
            // txtKisiler
            // 
            this.txtKisiler.Location = new System.Drawing.Point(27, 25);
            this.txtKisiler.Name = "txtKisiler";
            this.txtKisiler.Size = new System.Drawing.Size(100, 20);
            this.txtKisiler.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAra.Location = new System.Drawing.Point(12, 129);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(115, 27);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSira
            // 
            this.btnSira.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSira.Location = new System.Drawing.Point(12, 177);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(115, 33);
            this.btnSira.TabIndex = 4;
            this.btnSira.Text = "SIRASI";
            this.btnSira.UseVisualStyleBackColor = false;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSil.Location = new System.Drawing.Point(12, 233);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 28);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL (RemoveAt)";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSilRemove
            // 
            this.btnSilRemove.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSilRemove.Location = new System.Drawing.Point(312, 234);
            this.btnSilRemove.Name = "btnSilRemove";
            this.btnSilRemove.Size = new System.Drawing.Size(143, 28);
            this.btnSilRemove.TabIndex = 6;
            this.btnSilRemove.Text = "SİL(Remove)";
            this.btnSilRemove.UseVisualStyleBackColor = false;
            this.btnSilRemove.Click += new System.EventHandler(this.btnSilRemove_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKaydet.Location = new System.Drawing.Point(312, 178);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(143, 33);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSayı
            // 
            this.btnSayı.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSayı.Location = new System.Drawing.Point(312, 130);
            this.btnSayı.Name = "btnSayı";
            this.btnSayı.Size = new System.Drawing.Size(143, 30);
            this.btnSayı.TabIndex = 8;
            this.btnSayı.Text = "5 HALFLİ KİŞİ SAYISI";
            this.btnSayı.UseVisualStyleBackColor = false;
            this.btnSayı.Click += new System.EventHandler(this.btnSayı_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.SteelBlue;
            this.btnM.Location = new System.Drawing.Point(312, 73);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(143, 36);
            this.btnM.TabIndex = 9;
            this.btnM.Text = "MHALFİ İLE BAŞLAYAN \r\nKİŞİ SAYISI";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(12, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Listi Sil";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(312, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "SIRASI";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(312, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "SON HALFİ A İLE BİTEN";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(467, 330);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnSayı);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSilRemove);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKisiler);
            this.Controls.Add(this.lbKisiler);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbKisiler;
        private System.Windows.Forms.TextBox txtKisiler;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSira;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSilRemove;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSayı;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

