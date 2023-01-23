namespace TarimOtomasyon
{
    partial class YoneticiForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange4 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange5 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange1 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange2 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange3 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSeralar = new System.Windows.Forms.Label();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new TarimOtomasyon.DatabaseDataSet();
            this.kullanicilarTableAdapter = new TarimOtomasyon.DatabaseDataSetTableAdapters.kullanicilarTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sera_cesiti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulamaYontemi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asilama_yontemi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dikim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alan_buyuklugu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sera_sahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSera = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent2 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge13 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.label11 = new System.Windows.Forms.Label();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.linearGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSeraSahibi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSeraGuncelle = new FontAwesome.Sharp.IconButton();
            this.btnSeraSil = new FontAwesome.Sharp.IconButton();
            this.txtDikimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAsilamaYontemi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSulamaYontemi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGubrelemeSekli = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGubrelemeTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunCinsi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeraCesiti = new System.Windows.Forms.ComboBox();
            this.txtSeraAdi = new System.Windows.Forms.TextBox();
            this.txtAlanBuyuklugu = new System.Windows.Forms.TextBox();
            this.lblSeraBilgi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.btnKullaniciSil = new FontAwesome.Sharp.IconButton();
            this.lblKullaniciDuzenle = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtYeni2 = new System.Windows.Forms.TextBox();
            this.txtYeni = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtYetki = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTemelBilgiler = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelSera.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panelKullanici.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblKullanicilar);
            this.groupBox1.Controls.Add(this.ıconPictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Kullanıcı Sayısı";
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.AutoSize = true;
            this.lblKullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblKullanicilar.Location = new System.Drawing.Point(112, 41);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(74, 39);
            this.lblKullanicilar.TabIndex = 1;
            this.lblKullanicilar.Text = "999";
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 64;
            this.ıconPictureBox1.Location = new System.Drawing.Point(16, 28);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(66, 64);
            this.ıconPictureBox1.TabIndex = 0;
            this.ıconPictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lblSeralar);
            this.groupBox2.Controls.Add(this.ıconPictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(265, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistemde Mevcut Sera Sayısı";
            // 
            // lblSeralar
            // 
            this.lblSeralar.AutoSize = true;
            this.lblSeralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblSeralar.Location = new System.Drawing.Point(120, 41);
            this.lblSeralar.Name = "lblSeralar";
            this.lblSeralar.Size = new System.Drawing.Size(74, 39);
            this.lblSeralar.TabIndex = 2;
            this.lblSeralar.Text = "999";
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ıconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Seedling;
            this.ıconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox2.IconSize = 64;
            this.ıconPictureBox2.Location = new System.Drawing.Point(19, 28);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(66, 64);
            this.ıconPictureBox2.TabIndex = 0;
            this.ıconPictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.kullanici_ad,
            this.kullanici_soyad,
            this.kullanici_mail,
            this.kullanici_yetki});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(988, 397);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // kullanici_ad
            // 
            this.kullanici_ad.DataPropertyName = "kullanici_ad";
            this.kullanici_ad.HeaderText = "Ad";
            this.kullanici_ad.Name = "kullanici_ad";
            this.kullanici_ad.ReadOnly = true;
            this.kullanici_ad.Width = 150;
            // 
            // kullanici_soyad
            // 
            this.kullanici_soyad.DataPropertyName = "kullanici_soyad";
            this.kullanici_soyad.HeaderText = "Soyad";
            this.kullanici_soyad.Name = "kullanici_soyad";
            this.kullanici_soyad.ReadOnly = true;
            this.kullanici_soyad.Width = 150;
            // 
            // kullanici_mail
            // 
            this.kullanici_mail.DataPropertyName = "kullanici_mail";
            this.kullanici_mail.HeaderText = "E-Posta";
            this.kullanici_mail.Name = "kullanici_mail";
            this.kullanici_mail.ReadOnly = true;
            this.kullanici_mail.Width = 150;
            // 
            // kullanici_yetki
            // 
            this.kullanici_yetki.DataPropertyName = "kullanici_yetki";
            this.kullanici_yetki.HeaderText = "Yetki";
            this.kullanici_yetki.Name = "kullanici_yetki";
            this.kullanici_yetki.ReadOnly = true;
            this.kullanici_yetki.Width = 50;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 423);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcılar";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seralar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.sera_cesiti,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.sulamaYontemi,
            this.asilama_yontemi,
            this.dikim_tarihi,
            this.alan_buyuklugu,
            this.sera_sahibi});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(984, 397);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sera_adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sera Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sera_cesiti
            // 
            this.sera_cesiti.DataPropertyName = "sera_cesiti";
            this.sera_cesiti.HeaderText = "Sera Çeşiti";
            this.sera_cesiti.Name = "sera_cesiti";
            this.sera_cesiti.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "urun_cinsi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ürün Cinsi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gubreleme_turu";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gübreleme Türü";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gubreleme_sekli";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gübreleme Şekli";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // sulamaYontemi
            // 
            this.sulamaYontemi.DataPropertyName = "sulama_yontemi";
            this.sulamaYontemi.HeaderText = "Sulama Yöntemi";
            this.sulamaYontemi.Name = "sulamaYontemi";
            this.sulamaYontemi.ReadOnly = true;
            this.sulamaYontemi.Width = 125;
            // 
            // asilama_yontemi
            // 
            this.asilama_yontemi.DataPropertyName = "asilama_yontemi";
            this.asilama_yontemi.HeaderText = "Aşılama Yöntemi";
            this.asilama_yontemi.Name = "asilama_yontemi";
            this.asilama_yontemi.ReadOnly = true;
            // 
            // dikim_tarihi
            // 
            this.dikim_tarihi.DataPropertyName = "dikim_tarihi";
            this.dikim_tarihi.HeaderText = "Dikim Tarihi";
            this.dikim_tarihi.Name = "dikim_tarihi";
            this.dikim_tarihi.ReadOnly = true;
            // 
            // alan_buyuklugu
            // 
            this.alan_buyuklugu.DataPropertyName = "alan_buyuklugu";
            this.alan_buyuklugu.HeaderText = "Alan Büyüklüğü";
            this.alan_buyuklugu.Name = "alan_buyuklugu";
            this.alan_buyuklugu.ReadOnly = true;
            this.alan_buyuklugu.Width = 50;
            // 
            // sera_sahibi
            // 
            this.sera_sahibi.DataPropertyName = "sera_sahibi";
            this.sera_sahibi.HeaderText = "Sera Sahibi";
            this.sera_sahibi.Name = "sera_sahibi";
            this.sera_sahibi.ReadOnly = true;
            // 
            // panelSera
            // 
            this.panelSera.AutoSize = true;
            this.panelSera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSera.Controls.Add(this.groupBox3);
            this.panelSera.Controls.Add(this.groupBox4);
            this.panelSera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSera.Location = new System.Drawing.Point(0, 0);
            this.panelSera.Name = "panelSera";
            this.panelSera.Size = new System.Drawing.Size(1025, 571);
            this.panelSera.TabIndex = 4;
            this.panelSera.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gaugeControl3);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.gaugeControl2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.gaugeControl1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(585, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 547);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sera Cihaz Bilgileri";
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl3.Location = new System.Drawing.Point(108, 296);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(216, 195);
            this.gaugeControl3.TabIndex = 31;
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 204, 183);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent2});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent2});
            // 
            // labelComponent2
            // 
            this.labelComponent2.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.labelComponent2.Name = "circularGauge1_Label1";
            this.labelComponent2.Size = new System.Drawing.SizeF(140F, 60F);
            this.labelComponent2.Text = "%54";
            this.labelComponent2.ZOrder = -1001;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.arcScaleComponent2;
            this.arcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 80F;
            this.arcScaleRangeBarComponent1.Value = 54F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent2.EndAngle = 90F;
            this.arcScaleComponent2.MajorTickCount = 0;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 100F;
            this.arcScaleComponent2.MinorTickCount = 0;
            this.arcScaleComponent2.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent2.Name = "scale1";
            this.arcScaleComponent2.StartAngle = -270F;
            this.arcScaleComponent2.Value = 20F;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Mevcut Sera Nem Oranı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(276, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "950 milibar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Mevcut Sera Basıncı";
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge13});
            this.gaugeControl2.Location = new System.Drawing.Point(218, 60);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(183, 163);
            this.gaugeControl2.TabIndex = 26;
            // 
            // circularGauge13
            // 
            this.circularGauge13.AutoSize = DevExpress.Utils.DefaultBoolean.False;
            this.circularGauge13.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge13.Bounds = new System.Drawing.Rectangle(6, 6, 171, 151);
            this.circularGauge13.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge13.Name = "circularGauge13";
            this.circularGauge13.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge13.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style28;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(200F, 200F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#4D4D4D");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickmark.AllowTickOverlap = true;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style28_1;
            this.arcScaleComponent1.MajorTickmark.TextOffset = 18F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 1300F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = 4F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style28_1;
            this.arcScaleComponent1.MinorTickmark.ShowTick = false;
            this.arcScaleComponent1.MinValue = 700F;
            this.arcScaleComponent1.Name = "scale1";
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D54367");
            arcScaleRange1.EndThickness = 22F;
            arcScaleRange1.EndValue = 820F;
            arcScaleRange1.Name = "Range4";
            arcScaleRange1.ShapeOffset = -4F;
            arcScaleRange1.StartThickness = 22F;
            arcScaleRange1.StartValue = 700F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F5E16B");
            arcScaleRange2.EndThickness = 22F;
            arcScaleRange2.EndValue = 1000F;
            arcScaleRange2.Name = "Range3";
            arcScaleRange2.ShapeOffset = -4F;
            arcScaleRange2.StartThickness = 22F;
            arcScaleRange2.StartValue = 820F;
            arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#59BB71");
            arcScaleRange3.EndThickness = 22F;
            arcScaleRange3.EndValue = 1060F;
            arcScaleRange3.Name = "Range0";
            arcScaleRange3.ShapeOffset = -4F;
            arcScaleRange3.StartThickness = 22F;
            arcScaleRange3.StartValue = 1000F;
            arcScaleRange4.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F5E16B");
            arcScaleRange4.EndThickness = 22F;
            arcScaleRange4.EndValue = 1180F;
            arcScaleRange4.Name = "Range1";
            arcScaleRange4.ShapeOffset = -4F;
            arcScaleRange4.StartThickness = 22F;
            arcScaleRange4.StartValue = 1060F;
            arcScaleRange5.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D54367");
            arcScaleRange5.EndThickness = 22F;
            arcScaleRange5.EndValue = 1300F;
            arcScaleRange5.Name = "Range2";
            arcScaleRange5.ShapeOffset = -4F;
            arcScaleRange5.StartThickness = 22F;
            arcScaleRange5.StartValue = 1180F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3,
            arcScaleRange4,
            arcScaleRange5});
            this.arcScaleComponent1.StartAngle = -240F;
            this.arcScaleComponent1.Value = 700F;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.labelComponent1.Name = "circularGauge13_Label1";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F);
            this.labelComponent1.Text = "bar / psi";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 8F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style28;
            this.arcScaleNeedleComponent1.StartOffset = -6F;
            this.arcScaleNeedleComponent1.Value = 950F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mevcut Sera Sıcaklığı";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.linearGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(34, 56);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(164, 166);
            this.gaugeControl1.TabIndex = 23;
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent1});
            this.linearGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 152, 154);
            this.linearGauge1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent1});
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.linearGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent1});
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            this.linearScaleBackgroundLayerComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleBackgroundLayerComponent1.Name = "bg1";
            this.linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style19;
            this.linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleComponent1
            // 
            this.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A4D6F7");
            this.linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent1.MajorTickCount = 6;
            this.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent1.MajorTickmark.ShapeOffset = -23F;
            this.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_1;
            this.linearScaleComponent1.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent1.MaxValue = 100F;
            this.linearScaleComponent1.MinorTickCount = 4;
            this.linearScaleComponent1.MinorTickmark.ShapeOffset = -23F;
            this.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_2;
            this.linearScaleComponent1.Name = "scale1";
            linearScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#059172");
            linearScaleRange1.EndThickness = 14F;
            linearScaleRange1.EndValue = 33F;
            linearScaleRange1.Name = "Range0";
            linearScaleRange1.ShapeOffset = -23F;
            linearScaleRange1.StartThickness = 14F;
            linearScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#CAB461");
            linearScaleRange2.EndThickness = 14F;
            linearScaleRange2.EndValue = 66F;
            linearScaleRange2.Name = "Range1";
            linearScaleRange2.ShapeOffset = -23F;
            linearScaleRange2.StartThickness = 14F;
            linearScaleRange2.StartValue = 33F;
            linearScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A5648E");
            linearScaleRange3.EndThickness = 14F;
            linearScaleRange3.EndValue = 100F;
            linearScaleRange3.Name = "Range2";
            linearScaleRange3.ShapeOffset = -23F;
            linearScaleRange3.StartThickness = 14F;
            linearScaleRange3.StartValue = 66F;
            this.linearScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange1,
            linearScaleRange2,
            linearScaleRange3});
            this.linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent1.Value = 100F;
            // 
            // linearScaleLevelComponent1
            // 
            this.linearScaleLevelComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleLevelComponent1.Name = "level1";
            this.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style19;
            this.linearScaleLevelComponent1.Value = 25F;
            this.linearScaleLevelComponent1.ZOrder = -50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(94, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "25 °C";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtSeraSahibi);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnSeraGuncelle);
            this.groupBox4.Controls.Add(this.btnSeraSil);
            this.groupBox4.Controls.Add(this.txtDikimTarihi);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtAsilamaYontemi);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtSulamaYontemi);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtGubrelemeSekli);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtGubrelemeTuru);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtUrunCinsi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtSeraCesiti);
            this.groupBox4.Controls.Add(this.txtSeraAdi);
            this.groupBox4.Controls.Add(this.txtAlanBuyuklugu);
            this.groupBox4.Controls.Add(this.lblSeraBilgi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(24, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 547);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sera Temel Bilgileri";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(58, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Sera Sahibi:";
            // 
            // txtSeraSahibi
            // 
            this.txtSeraSahibi.BackColor = System.Drawing.SystemColors.Window;
            this.txtSeraSahibi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeraSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeraSahibi.Location = new System.Drawing.Point(180, 22);
            this.txtSeraSahibi.Name = "txtSeraSahibi";
            this.txtSeraSahibi.Size = new System.Drawing.Size(275, 26);
            this.txtSeraSahibi.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sera Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(59, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dikim Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Alan Büyüklüğü:";
            // 
            // btnSeraGuncelle
            // 
            this.btnSeraGuncelle.BackColor = System.Drawing.Color.Turquoise;
            this.btnSeraGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeraGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSeraGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeraGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeraGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSeraGuncelle.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnSeraGuncelle.IconColor = System.Drawing.Color.White;
            this.btnSeraGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeraGuncelle.IconSize = 40;
            this.btnSeraGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeraGuncelle.Location = new System.Drawing.Point(193, 482);
            this.btnSeraGuncelle.Name = "btnSeraGuncelle";
            this.btnSeraGuncelle.Size = new System.Drawing.Size(179, 53);
            this.btnSeraGuncelle.TabIndex = 15;
            this.btnSeraGuncelle.Text = "Serayı Güncelle";
            this.btnSeraGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeraGuncelle.UseVisualStyleBackColor = false;
            this.btnSeraGuncelle.Click += new System.EventHandler(this.btnSeraGuncelle_Click);
            // 
            // btnSeraSil
            // 
            this.btnSeraSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSeraSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeraSil.FlatAppearance.BorderSize = 0;
            this.btnSeraSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeraSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeraSil.ForeColor = System.Drawing.Color.White;
            this.btnSeraSil.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSeraSil.IconColor = System.Drawing.Color.White;
            this.btnSeraSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeraSil.IconSize = 40;
            this.btnSeraSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeraSil.Location = new System.Drawing.Point(388, 482);
            this.btnSeraSil.Name = "btnSeraSil";
            this.btnSeraSil.Size = new System.Drawing.Size(129, 53);
            this.btnSeraSil.TabIndex = 13;
            this.btnSeraSil.Text = "Serayı Sil";
            this.btnSeraSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeraSil.UseVisualStyleBackColor = false;
            this.btnSeraSil.Click += new System.EventHandler(this.btnSeraSil_Click);
            // 
            // txtDikimTarihi
            // 
            this.txtDikimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDikimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDikimTarihi.Location = new System.Drawing.Point(180, 392);
            this.txtDikimTarihi.Name = "txtDikimTarihi";
            this.txtDikimTarihi.Size = new System.Drawing.Size(275, 26);
            this.txtDikimTarihi.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ekilen Ürün Cinsi:";
            // 
            // txtAsilamaYontemi
            // 
            this.txtAsilamaYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAsilamaYontemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAsilamaYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAsilamaYontemi.FormattingEnabled = true;
            this.txtAsilamaYontemi.Items.AddRange(new object[] {
            "Dilcikli Aşı",
            "Yarma Aşı",
            "Kakma Aşı",
            "Tüp Aşı"});
            this.txtAsilamaYontemi.Location = new System.Drawing.Point(180, 345);
            this.txtAsilamaYontemi.Name = "txtAsilamaYontemi";
            this.txtAsilamaYontemi.Size = new System.Drawing.Size(275, 28);
            this.txtAsilamaYontemi.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gübreleme Türü:";
            // 
            // txtSulamaYontemi
            // 
            this.txtSulamaYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSulamaYontemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSulamaYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSulamaYontemi.FormattingEnabled = true;
            this.txtSulamaYontemi.Items.AddRange(new object[] {
            "Üstten yağmurlama",
            "Toprak yüzeyinden yağmurlama",
            "Damla sulama",
            "Kum kültürü sulama",
            "Oluklu sulama",
            "Mikro sulama"});
            this.txtSulamaYontemi.Location = new System.Drawing.Point(180, 298);
            this.txtSulamaYontemi.Name = "txtSulamaYontemi";
            this.txtSulamaYontemi.Size = new System.Drawing.Size(275, 28);
            this.txtSulamaYontemi.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sera Çeşiti:";
            // 
            // txtGubrelemeSekli
            // 
            this.txtGubrelemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGubrelemeSekli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGubrelemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGubrelemeSekli.FormattingEnabled = true;
            this.txtGubrelemeSekli.Items.AddRange(new object[] {
            "Serpme gübreleme",
            "Bant gübreleme",
            "Küme gübreleme",
            "Yağmurlama sistemi ile gübreleme",
            "Yapraktan gübreleme",
            "Damla sulama ile gübreleme"});
            this.txtGubrelemeSekli.Location = new System.Drawing.Point(180, 251);
            this.txtGubrelemeSekli.Name = "txtGubrelemeSekli";
            this.txtGubrelemeSekli.Size = new System.Drawing.Size(275, 28);
            this.txtGubrelemeSekli.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gübreleme Şekli:";
            // 
            // txtGubrelemeTuru
            // 
            this.txtGubrelemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGubrelemeTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGubrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGubrelemeTuru.FormattingEnabled = true;
            this.txtGubrelemeTuru.Items.AddRange(new object[] {
            "Organik Gübre",
            "Yeşil Gübre",
            "Ticari Gübre",
            "Azotlu Gübre",
            "Fosforlu Gübre",
            "Potasyum Gübre",
            "Kompoze Gübre"});
            this.txtGubrelemeTuru.Location = new System.Drawing.Point(180, 204);
            this.txtGubrelemeTuru.Name = "txtGubrelemeTuru";
            this.txtGubrelemeTuru.Size = new System.Drawing.Size(275, 28);
            this.txtGubrelemeTuru.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sulama Yöntemi:";
            // 
            // txtUrunCinsi
            // 
            this.txtUrunCinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUrunCinsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUrunCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrunCinsi.FormattingEnabled = true;
            this.txtUrunCinsi.Items.AddRange(new object[] {
            "Domates",
            "Biber",
            "Kavun",
            "Patlıcan",
            "Salatalık",
            "Marul"});
            this.txtUrunCinsi.Location = new System.Drawing.Point(180, 157);
            this.txtUrunCinsi.Name = "txtUrunCinsi";
            this.txtUrunCinsi.Size = new System.Drawing.Size(275, 28);
            this.txtUrunCinsi.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Aşılama Yöntemi:";
            // 
            // txtSeraCesiti
            // 
            this.txtSeraCesiti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSeraCesiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSeraCesiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSeraCesiti.FormattingEnabled = true;
            this.txtSeraCesiti.Items.AddRange(new object[] {
            "Geleneksel Sera",
            "Tünel Sera",
            "Kaynaklı Sera",
            "Modern Sera",
            "Cam Sera",
            "Kuonset Sera"});
            this.txtSeraCesiti.Location = new System.Drawing.Point(180, 110);
            this.txtSeraCesiti.Name = "txtSeraCesiti";
            this.txtSeraCesiti.Size = new System.Drawing.Size(275, 28);
            this.txtSeraCesiti.TabIndex = 16;
            // 
            // txtSeraAdi
            // 
            this.txtSeraAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeraAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeraAdi.Location = new System.Drawing.Point(180, 65);
            this.txtSeraAdi.Name = "txtSeraAdi";
            this.txtSeraAdi.Size = new System.Drawing.Size(275, 26);
            this.txtSeraAdi.TabIndex = 11;
            // 
            // txtAlanBuyuklugu
            // 
            this.txtAlanBuyuklugu.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlanBuyuklugu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlanBuyuklugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlanBuyuklugu.Location = new System.Drawing.Point(180, 437);
            this.txtAlanBuyuklugu.Name = "txtAlanBuyuklugu";
            this.txtAlanBuyuklugu.ReadOnly = true;
            this.txtAlanBuyuklugu.Size = new System.Drawing.Size(275, 26);
            this.txtAlanBuyuklugu.TabIndex = 11;
            // 
            // lblSeraBilgi
            // 
            this.lblSeraBilgi.AutoSize = true;
            this.lblSeraBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSeraBilgi.Location = new System.Drawing.Point(30, 501);
            this.lblSeraBilgi.Name = "lblSeraBilgi";
            this.lblSeraBilgi.Size = new System.Drawing.Size(0, 17);
            this.lblSeraBilgi.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelKullanici
            // 
            this.panelKullanici.Controls.Add(this.label21);
            this.panelKullanici.Controls.Add(this.btnKullaniciSil);
            this.panelKullanici.Controls.Add(this.lblKullaniciDuzenle);
            this.panelKullanici.Controls.Add(this.groupBox5);
            this.panelKullanici.Controls.Add(this.groupBox6);
            this.panelKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKullanici.Location = new System.Drawing.Point(0, 0);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(1025, 571);
            this.panelKullanici.TabIndex = 27;
            this.panelKullanici.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(788, 449);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 20);
            this.label21.TabIndex = 9;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnKullaniciSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKullaniciSil.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnKullaniciSil.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnKullaniciSil.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnKullaniciSil.IconSize = 46;
            this.btnKullaniciSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciSil.Location = new System.Drawing.Point(801, 481);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(165, 50);
            this.btnKullaniciSil.TabIndex = 8;
            this.btnKullaniciSil.Text = "Kullanıcıyı Sil";
            this.btnKullaniciSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // lblKullaniciDuzenle
            // 
            this.lblKullaniciDuzenle.AutoSize = true;
            this.lblKullaniciDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblKullaniciDuzenle.Location = new System.Drawing.Point(58, 21);
            this.lblKullaniciDuzenle.Name = "lblKullaniciDuzenle";
            this.lblKullaniciDuzenle.Size = new System.Drawing.Size(358, 22);
            this.lblKullaniciDuzenle.TabIndex = 7;
            this.lblKullaniciDuzenle.Text = "test@test.com kullanıcısını düzenliyorsunuz.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.txtYeni2);
            this.groupBox5.Controls.Add(this.txtYeni);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox5.Location = new System.Drawing.Point(58, 358);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 173);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parola Ayarları";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Image = global::TarimOtomasyon.Properties.Resources.refresh__1_;
            this.button2.Location = new System.Drawing.Point(418, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Parolayı Güncelle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtYeni2
            // 
            this.txtYeni2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYeni2.Location = new System.Drawing.Point(242, 71);
            this.txtYeni2.Name = "txtYeni2";
            this.txtYeni2.PasswordChar = '•';
            this.txtYeni2.Size = new System.Drawing.Size(203, 26);
            this.txtYeni2.TabIndex = 12;
            // 
            // txtYeni
            // 
            this.txtYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYeni.Location = new System.Drawing.Point(242, 29);
            this.txtYeni.Name = "txtYeni";
            this.txtYeni.PasswordChar = '•';
            this.txtYeni.Size = new System.Drawing.Size(203, 26);
            this.txtYeni.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(111, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 24);
            this.label15.TabIndex = 8;
            this.label15.Text = "Yeni Parola:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(40, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "Yeni Parola (Tekrar):";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtYetki);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.lblTemelBilgiler);
            this.groupBox6.Controls.Add(this.txtEposta);
            this.groupBox6.Controls.Add(this.txtSoyad);
            this.groupBox6.Controls.Add(this.txtAd);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox6.Location = new System.Drawing.Point(58, 64);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(908, 288);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Temel Bilgiler";
            // 
            // txtYetki
            // 
            this.txtYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYetki.FormattingEnabled = true;
            this.txtYetki.Items.AddRange(new object[] {
            "Kullanıcı",
            "Yönetici"});
            this.txtYetki.Location = new System.Drawing.Point(245, 164);
            this.txtYetki.Name = "txtYetki";
            this.txtYetki.Size = new System.Drawing.Size(203, 26);
            this.txtYetki.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.Location = new System.Drawing.Point(167, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 24);
            this.label17.TabIndex = 8;
            this.label17.Text = "Yetki:";
            // 
            // lblTemelBilgiler
            // 
            this.lblTemelBilgiler.AutoSize = true;
            this.lblTemelBilgiler.Location = new System.Drawing.Point(525, 46);
            this.lblTemelBilgiler.Name = "lblTemelBilgiler";
            this.lblTemelBilgiler.Size = new System.Drawing.Size(0, 18);
            this.lblTemelBilgiler.TabIndex = 7;
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEposta.Location = new System.Drawing.Point(245, 118);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(203, 26);
            this.txtEposta.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoyad.Location = new System.Drawing.Point(245, 76);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(203, 26);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAd.Location = new System.Drawing.Point(245, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(203, 26);
            this.txtAd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Image = global::TarimOtomasyon.Properties.Resources.refresh__1_;
            this.button1.Location = new System.Drawing.Point(418, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Güncelle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label18.Location = new System.Drawing.Point(154, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "Soyad:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label19.Location = new System.Drawing.Point(83, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "E-Posta Adresi:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label20.Location = new System.Drawing.Point(183, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ad:";
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 571);
            this.Controls.Add(this.panelKullanici);
            this.Controls.Add(this.panelSera);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoneticiForm";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelSera.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelKullanici.ResumeLayout(false);
            this.panelKullanici.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.Label lblSeralar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private DatabaseDataSetTableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_yetki;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sera_cesiti;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulamaYontemi;
        private System.Windows.Forms.DataGridViewTextBoxColumn asilama_yontemi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dikim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn alan_buyuklugu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sera_sahibi;
        private System.Windows.Forms.Panel panelSera;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge13;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnSeraGuncelle;
        private FontAwesome.Sharp.IconButton btnSeraSil;
        private System.Windows.Forms.DateTimePicker txtDikimTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtAsilamaYontemi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtSulamaYontemi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtGubrelemeSekli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtGubrelemeTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtUrunCinsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtSeraCesiti;
        private System.Windows.Forms.TextBox txtSeraAdi;
        private System.Windows.Forms.TextBox txtAlanBuyuklugu;
        private System.Windows.Forms.Label lblSeraBilgi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelKullanici;
        private System.Windows.Forms.Label lblKullaniciDuzenle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtYeni2;
        private System.Windows.Forms.TextBox txtYeni;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTemelBilgiler;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox txtYetki;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnKullaniciSil;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSeraSahibi;
    }
}