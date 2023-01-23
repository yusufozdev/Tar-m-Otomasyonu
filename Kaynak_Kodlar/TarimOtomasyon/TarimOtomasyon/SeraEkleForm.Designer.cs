namespace TarimOtomasyon
{
    partial class SeraEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeraEkleForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDikimTarihi = new System.Windows.Forms.DateTimePicker();
            this.labelBilgi = new System.Windows.Forms.Label();
            this.btnSeraKaydet = new System.Windows.Forms.Button();
            this.txtAsilamaYontemi = new System.Windows.Forms.ComboBox();
            this.txtSulamaYontemi = new System.Windows.Forms.ComboBox();
            this.txtGubrelemeSekli = new System.Windows.Forms.ComboBox();
            this.txtGubrelemeTuru = new System.Windows.Forms.ComboBox();
            this.txtUrunCinsi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeraCesiti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlanBuyuklugu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeraAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDikimTarihi);
            this.groupBox1.Controls.Add(this.labelBilgi);
            this.groupBox1.Controls.Add(this.btnSeraKaydet);
            this.groupBox1.Controls.Add(this.txtAsilamaYontemi);
            this.groupBox1.Controls.Add(this.txtSulamaYontemi);
            this.groupBox1.Controls.Add(this.txtGubrelemeSekli);
            this.groupBox1.Controls.Add(this.txtGubrelemeTuru);
            this.groupBox1.Controls.Add(this.txtUrunCinsi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSeraCesiti);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAlanBuyuklugu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSeraAdi);
            this.groupBox1.Location = new System.Drawing.Point(62, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 520);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtDikimTarihi
            // 
            this.txtDikimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDikimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDikimTarihi.Location = new System.Drawing.Point(408, 360);
            this.txtDikimTarihi.Name = "txtDikimTarihi";
            this.txtDikimTarihi.Size = new System.Drawing.Size(224, 22);
            this.txtDikimTarihi.TabIndex = 2;
            // 
            // labelBilgi
            // 
            this.labelBilgi.AutoSize = true;
            this.labelBilgi.Location = new System.Drawing.Point(241, 488);
            this.labelBilgi.Name = "labelBilgi";
            this.labelBilgi.Size = new System.Drawing.Size(0, 13);
            this.labelBilgi.TabIndex = 4;
            // 
            // btnSeraKaydet
            // 
            this.btnSeraKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.btnSeraKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeraKaydet.FlatAppearance.BorderSize = 0;
            this.btnSeraKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeraKaydet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeraKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeraKaydet.Location = new System.Drawing.Point(707, 448);
            this.btnSeraKaydet.Name = "btnSeraKaydet";
            this.btnSeraKaydet.Size = new System.Drawing.Size(161, 53);
            this.btnSeraKaydet.TabIndex = 3;
            this.btnSeraKaydet.Text = "KAYDET";
            this.btnSeraKaydet.UseVisualStyleBackColor = false;
            this.btnSeraKaydet.Click += new System.EventHandler(this.btnSeraKaydet_Click);
            // 
            // txtAsilamaYontemi
            // 
            this.txtAsilamaYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAsilamaYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAsilamaYontemi.FormattingEnabled = true;
            this.txtAsilamaYontemi.Items.AddRange(new object[] {
            "Dilcikli Aşı",
            "Yarma Aşı",
            "Kakma Aşı",
            "Tüp Aşı"});
            this.txtAsilamaYontemi.Location = new System.Drawing.Point(408, 317);
            this.txtAsilamaYontemi.Name = "txtAsilamaYontemi";
            this.txtAsilamaYontemi.Size = new System.Drawing.Size(224, 24);
            this.txtAsilamaYontemi.TabIndex = 2;
            // 
            // txtSulamaYontemi
            // 
            this.txtSulamaYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSulamaYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSulamaYontemi.FormattingEnabled = true;
            this.txtSulamaYontemi.Items.AddRange(new object[] {
            "Üstten yağmurlama",
            "Toprak yüzeyinden yağmurlama",
            "Damla sulama",
            "Kum kültürü sulama",
            "Oluklu sulama",
            "Mikro sulama"});
            this.txtSulamaYontemi.Location = new System.Drawing.Point(408, 272);
            this.txtSulamaYontemi.Name = "txtSulamaYontemi";
            this.txtSulamaYontemi.Size = new System.Drawing.Size(224, 24);
            this.txtSulamaYontemi.TabIndex = 2;
            // 
            // txtGubrelemeSekli
            // 
            this.txtGubrelemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGubrelemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGubrelemeSekli.FormattingEnabled = true;
            this.txtGubrelemeSekli.Items.AddRange(new object[] {
            "Serpme gübreleme",
            "Bant gübreleme",
            "Küme gübreleme",
            "Yağmurlama sistemi ile gübreleme",
            "Yapraktan gübreleme",
            "Damla sulama ile gübreleme"});
            this.txtGubrelemeSekli.Location = new System.Drawing.Point(408, 227);
            this.txtGubrelemeSekli.Name = "txtGubrelemeSekli";
            this.txtGubrelemeSekli.Size = new System.Drawing.Size(224, 24);
            this.txtGubrelemeSekli.TabIndex = 2;
            // 
            // txtGubrelemeTuru
            // 
            this.txtGubrelemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGubrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGubrelemeTuru.FormattingEnabled = true;
            this.txtGubrelemeTuru.Items.AddRange(new object[] {
            "Organik Gübre",
            "Yeşil Gübre",
            "Ticari Gübre",
            "Azotlu Gübre",
            "Fosforlu Gübre",
            "Potasyum Gübre",
            "Kompoze Gübre"});
            this.txtGubrelemeTuru.Location = new System.Drawing.Point(408, 182);
            this.txtGubrelemeTuru.Name = "txtGubrelemeTuru";
            this.txtGubrelemeTuru.Size = new System.Drawing.Size(224, 24);
            this.txtGubrelemeTuru.TabIndex = 2;
            // 
            // txtUrunCinsi
            // 
            this.txtUrunCinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUrunCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunCinsi.FormattingEnabled = true;
            this.txtUrunCinsi.Items.AddRange(new object[] {
            "Domates",
            "Biber",
            "Kavun",
            "Patlıcan",
            "Salatalık",
            "Marul"});
            this.txtUrunCinsi.Location = new System.Drawing.Point(408, 137);
            this.txtUrunCinsi.Name = "txtUrunCinsi";
            this.txtUrunCinsi.Size = new System.Drawing.Size(224, 24);
            this.txtUrunCinsi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(237, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Aşılama Yöntemi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(239, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sulama Yöntemi:";
            // 
            // txtSeraCesiti
            // 
            this.txtSeraCesiti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSeraCesiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeraCesiti.FormattingEnabled = true;
            this.txtSeraCesiti.Items.AddRange(new object[] {
            "Geleneksel Sera",
            "Tünel Sera",
            "Kaynaklı Sera",
            "Modern Sera",
            "Cam Sera",
            "Kuonset Sera"});
            this.txtSeraCesiti.Location = new System.Drawing.Point(408, 92);
            this.txtSeraCesiti.Name = "txtSeraCesiti";
            this.txtSeraCesiti.Size = new System.Drawing.Size(224, 24);
            this.txtSeraCesiti.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(239, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gübreleme Şekli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(279, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sera Çeşiti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(241, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gübreleme Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(236, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ekilen Ürün Cinsi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(246, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Alan Büyüklüğü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(275, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dikim Tarihi:";
            // 
            // txtAlanBuyuklugu
            // 
            this.txtAlanBuyuklugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlanBuyuklugu.Location = new System.Drawing.Point(408, 407);
            this.txtAlanBuyuklugu.Name = "txtAlanBuyuklugu";
            this.txtAlanBuyuklugu.Size = new System.Drawing.Size(224, 22);
            this.txtAlanBuyuklugu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(295, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sera Adı:";
            // 
            // txtSeraAdi
            // 
            this.txtSeraAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeraAdi.Location = new System.Drawing.Point(408, 47);
            this.txtSeraAdi.Name = "txtSeraAdi";
            this.txtSeraAdi.Size = new System.Drawing.Size(224, 22);
            this.txtSeraAdi.TabIndex = 0;
            // 
            // SeraEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 571);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeraEkleForm";
            this.Text = "Sera Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtAsilamaYontemi;
        private System.Windows.Forms.ComboBox txtSulamaYontemi;
        private System.Windows.Forms.ComboBox txtGubrelemeSekli;
        private System.Windows.Forms.ComboBox txtGubrelemeTuru;
        private System.Windows.Forms.ComboBox txtUrunCinsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtSeraCesiti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlanBuyuklugu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeraAdi;
        private System.Windows.Forms.Button btnSeraKaydet;
        private System.Windows.Forms.Label labelBilgi;
        private System.Windows.Forms.DateTimePicker txtDikimTarihi;
    }
}