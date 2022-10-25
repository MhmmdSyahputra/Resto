namespace contoh2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_outlit = new System.Windows.Forms.Label();
            this.input_outlit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.label_nohp = new System.Windows.Forms.Label();
            this.input_nama = new System.Windows.Forms.TextBox();
            this.input_alamat = new System.Windows.Forms.TextBox();
            this.input_nohp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MakananOption = new System.Windows.Forms.RadioButton();
            this.MinumanOption = new System.Windows.Forms.RadioButton();
            this.panel_member = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.input_diskon = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label_takeaway = new System.Windows.Forms.Label();
            this.input_jumlah = new System.Windows.Forms.NumericUpDown();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.nonmember_option = new System.Windows.Forms.RadioButton();
            this.member_option = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.input_takeaway = new System.Windows.Forms.ComboBox();
            this.label_kcustomer = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.input_note = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tablefoods = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.harga_input_item_select = new System.Windows.Forms.TextBox();
            this.label_harga_item_select = new System.Windows.Forms.Label();
            this.label_item_select = new System.Windows.Forms.Label();
            this.name_input_item_select = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_lvl_makanan = new System.Windows.Forms.NumericUpDown();
            this.topingcheck2 = new System.Windows.Forms.CheckBox();
            this.topingcheck3 = new System.Windows.Forms.CheckBox();
            this.topingcheck1 = new System.Windows.Forms.CheckBox();
            this.box_toping = new System.Windows.Forms.GroupBox();
            this.box_makanan = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_diskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefoods)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_lvl_makanan)).BeginInit();
            this.box_toping.SuspendLayout();
            this.box_makanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_outlit
            // 
            this.label_outlit.AutoSize = true;
            this.label_outlit.Location = new System.Drawing.Point(416, 74);
            this.label_outlit.Name = "label_outlit";
            this.label_outlit.Size = new System.Drawing.Size(84, 15);
            this.label_outlit.TabIndex = 1;
            this.label_outlit.Text = "Outlit Terdekat";
            this.label_outlit.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_outlit
            // 
            this.input_outlit.FormattingEnabled = true;
            this.input_outlit.Items.AddRange(new object[] {
            "Marelan ",
            "Binjai",
            "Karya",
            "Brayan"});
            this.input_outlit.Location = new System.Drawing.Point(506, 71);
            this.input_outlit.Name = "input_outlit";
            this.input_outlit.Size = new System.Drawing.Size(121, 23);
            this.input_outlit.TabIndex = 3;
            this.input_outlit.Text = "--Pilih";
            this.input_outlit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(527, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geprek Nampol";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesan Makanan";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(6, 30);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(39, 15);
            this.label_nama.TabIndex = 7;
            this.label_nama.Text = "Nama";
            this.label_nama.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Location = new System.Drawing.Point(6, 104);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(45, 15);
            this.label_alamat.TabIndex = 8;
            this.label_alamat.Text = "Alamat";
            // 
            // label_nohp
            // 
            this.label_nohp.AutoSize = true;
            this.label_nohp.Location = new System.Drawing.Point(6, 62);
            this.label_nohp.Name = "label_nohp";
            this.label_nohp.Size = new System.Drawing.Size(42, 15);
            this.label_nohp.TabIndex = 9;
            this.label_nohp.Text = "No Hp";
            this.label_nohp.Click += new System.EventHandler(this.label7_Click);
            // 
            // input_nama
            // 
            this.input_nama.Location = new System.Drawing.Point(74, 30);
            this.input_nama.Name = "input_nama";
            this.input_nama.PlaceholderText = "Nama Anda..";
            this.input_nama.Size = new System.Drawing.Size(183, 23);
            this.input_nama.TabIndex = 10;
            this.input_nama.TextChanged += new System.EventHandler(this.input_nama_TextChanged);
            // 
            // input_alamat
            // 
            this.input_alamat.Location = new System.Drawing.Point(74, 88);
            this.input_alamat.Multiline = true;
            this.input_alamat.Name = "input_alamat";
            this.input_alamat.PlaceholderText = "Alamat Lengkap..";
            this.input_alamat.Size = new System.Drawing.Size(170, 47);
            this.input_alamat.TabIndex = 11;
            // 
            // input_nohp
            // 
            this.input_nohp.Location = new System.Drawing.Point(74, 59);
            this.input_nohp.Name = "input_nohp";
            this.input_nohp.PlaceholderText = "NoHp..";
            this.input_nohp.Size = new System.Drawing.Size(183, 23);
            this.input_nohp.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_nama);
            this.groupBox1.Controls.Add(this.label_alamat);
            this.groupBox1.Controls.Add(this.input_alamat);
            this.groupBox1.Controls.Add(this.input_nohp);
            this.groupBox1.Controls.Add(this.label_nohp);
            this.groupBox1.Controls.Add(this.input_nama);
            this.groupBox1.Location = new System.Drawing.Point(52, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 170);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pelanggan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel_member);
            this.groupBox2.Controls.Add(this.label_takeaway);
            this.groupBox2.Controls.Add(this.input_jumlah);
            this.groupBox2.Controls.Add(this.label_jumlah);
            this.groupBox2.Controls.Add(this.nonmember_option);
            this.groupBox2.Controls.Add(this.member_option);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.input_takeaway);
            this.groupBox2.Controls.Add(this.label_kcustomer);
            this.groupBox2.Controls.Add(this.submit);
            this.groupBox2.Controls.Add(this.input_note);
            this.groupBox2.Controls.Add(this.label_note);
            this.groupBox2.Location = new System.Drawing.Point(416, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 367);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MakananOption);
            this.groupBox3.Controls.Add(this.MinumanOption);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(40, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 46);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pilihan";
            // 
            // MakananOption
            // 
            this.MakananOption.AutoSize = true;
            this.MakananOption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakananOption.Location = new System.Drawing.Point(62, 17);
            this.MakananOption.Name = "MakananOption";
            this.MakananOption.Size = new System.Drawing.Size(84, 23);
            this.MakananOption.TabIndex = 18;
            this.MakananOption.Text = "Makanan";
            this.MakananOption.UseVisualStyleBackColor = true;
            this.MakananOption.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MinumanOption
            // 
            this.MinumanOption.AutoSize = true;
            this.MinumanOption.Checked = true;
            this.MinumanOption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinumanOption.Location = new System.Drawing.Point(164, 17);
            this.MinumanOption.Name = "MinumanOption";
            this.MinumanOption.Size = new System.Drawing.Size(86, 23);
            this.MinumanOption.TabIndex = 19;
            this.MinumanOption.TabStop = true;
            this.MinumanOption.Text = "Minuman";
            this.MinumanOption.UseVisualStyleBackColor = true;
            this.MinumanOption.CheckedChanged += new System.EventHandler(this.MinumanOption_CheckedChanged);
            // 
            // panel_member
            // 
            this.panel_member.Controls.Add(this.label7);
            this.panel_member.Controls.Add(this.input_diskon);
            this.panel_member.Controls.Add(this.label6);
            this.panel_member.Enabled = false;
            this.panel_member.Location = new System.Drawing.Point(16, 273);
            this.panel_member.Name = "panel_member";
            this.panel_member.Size = new System.Drawing.Size(335, 42);
            this.panel_member.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(201, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "%";
            // 
            // input_diskon
            // 
            this.input_diskon.Location = new System.Drawing.Point(143, 11);
            this.input_diskon.Name = "input_diskon";
            this.input_diskon.Size = new System.Drawing.Size(52, 23);
            this.input_diskon.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Diskon Member";
            // 
            // label_takeaway
            // 
            this.label_takeaway.AutoSize = true;
            this.label_takeaway.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_takeaway.Location = new System.Drawing.Point(31, 128);
            this.label_takeaway.Name = "label_takeaway";
            this.label_takeaway.Size = new System.Drawing.Size(78, 21);
            this.label_takeaway.TabIndex = 30;
            this.label_takeaway.Text = "TakeAway";
            // 
            // input_jumlah
            // 
            this.input_jumlah.Location = new System.Drawing.Point(172, 74);
            this.input_jumlah.Name = "input_jumlah";
            this.input_jumlah.Size = new System.Drawing.Size(144, 23);
            this.input_jumlah.TabIndex = 29;
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_jumlah.Location = new System.Drawing.Point(40, 76);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(60, 21);
            this.label_jumlah.TabIndex = 28;
            this.label_jumlah.Text = "Jumlah";
            // 
            // nonmember_option
            // 
            this.nonmember_option.AutoSize = true;
            this.nonmember_option.Checked = true;
            this.nonmember_option.Location = new System.Drawing.Point(253, 252);
            this.nonmember_option.Name = "nonmember_option";
            this.nonmember_option.Size = new System.Drawing.Size(98, 19);
            this.nonmember_option.TabIndex = 26;
            this.nonmember_option.TabStop = true;
            this.nonmember_option.Text = "Non_Member";
            this.nonmember_option.UseVisualStyleBackColor = true;
            this.nonmember_option.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // member_option
            // 
            this.member_option.AutoSize = true;
            this.member_option.Location = new System.Drawing.Point(172, 252);
            this.member_option.Name = "member_option";
            this.member_option.Size = new System.Drawing.Size(70, 19);
            this.member_option.TabIndex = 25;
            this.member_option.Text = "Member";
            this.member_option.UseVisualStyleBackColor = true;
            this.member_option.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 21);
            this.label10.TabIndex = 24;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // input_takeaway
            // 
            this.input_takeaway.FormattingEnabled = true;
            this.input_takeaway.Items.AddRange(new object[] {
            "Makan Ditempat",
            "Bawa Pulang"});
            this.input_takeaway.Location = new System.Drawing.Point(172, 126);
            this.input_takeaway.Name = "input_takeaway";
            this.input_takeaway.Size = new System.Drawing.Size(144, 23);
            this.input_takeaway.TabIndex = 18;
            this.input_takeaway.Text = "--Pilih";
            // 
            // label_kcustomer
            // 
            this.label_kcustomer.AutoSize = true;
            this.label_kcustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_kcustomer.Location = new System.Drawing.Point(16, 249);
            this.label_kcustomer.Name = "label_kcustomer";
            this.label_kcustomer.Size = new System.Drawing.Size(144, 21);
            this.label_kcustomer.TabIndex = 23;
            this.label_kcustomer.Text = "Kategori Pelanggan";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(16, 315);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(330, 47);
            this.submit.TabIndex = 22;
            this.submit.Text = "Pesan";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // input_note
            // 
            this.input_note.Location = new System.Drawing.Point(172, 184);
            this.input_note.Multiline = true;
            this.input_note.Name = "input_note";
            this.input_note.PlaceholderText = "Optional";
            this.input_note.Size = new System.Drawing.Size(144, 38);
            this.input_note.TabIndex = 21;
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_note.Location = new System.Drawing.Point(16, 191);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(138, 21);
            this.label_note.TabIndex = 20;
            this.label_note.Text = "Catatan Tambahan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(391, 306);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bukti";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tablefoods
            // 
            this.tablefoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablefoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablefoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablefoods.Location = new System.Drawing.Point(801, 159);
            this.tablefoods.Name = "tablefoods";
            this.tablefoods.RowTemplate.Height = 25;
            this.tablefoods.Size = new System.Drawing.Size(384, 452);
            this.tablefoods.TabIndex = 20;
            this.tablefoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablefoods_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.harga_input_item_select);
            this.panel1.Controls.Add(this.label_harga_item_select);
            this.panel1.Controls.Add(this.label_item_select);
            this.panel1.Controls.Add(this.name_input_item_select);
            this.panel1.Location = new System.Drawing.Point(427, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 121);
            this.panel1.TabIndex = 21;
            // 
            // harga_input_item_select
            // 
            this.harga_input_item_select.Location = new System.Drawing.Point(175, 71);
            this.harga_input_item_select.Name = "harga_input_item_select";
            this.harga_input_item_select.ReadOnly = true;
            this.harga_input_item_select.Size = new System.Drawing.Size(100, 23);
            this.harga_input_item_select.TabIndex = 3;
            // 
            // label_harga_item_select
            // 
            this.label_harga_item_select.AutoSize = true;
            this.label_harga_item_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_harga_item_select.Location = new System.Drawing.Point(73, 69);
            this.label_harga_item_select.Name = "label_harga_item_select";
            this.label_harga_item_select.Size = new System.Drawing.Size(52, 21);
            this.label_harga_item_select.TabIndex = 2;
            this.label_harga_item_select.Text = "Harga";
            this.label_harga_item_select.Click += new System.EventHandler(this.harga_item_select_Click);
            // 
            // label_item_select
            // 
            this.label_item_select.AutoSize = true;
            this.label_item_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_item_select.Location = new System.Drawing.Point(73, 20);
            this.label_item_select.Name = "label_item_select";
            this.label_item_select.Size = new System.Drawing.Size(87, 21);
            this.label_item_select.TabIndex = 1;
            this.label_item_select.Text = "Nama Item";
            // 
            // name_input_item_select
            // 
            this.name_input_item_select.Location = new System.Drawing.Point(175, 22);
            this.name_input_item_select.Name = "name_input_item_select";
            this.name_input_item_select.ReadOnly = true;
            this.name_input_item_select.Size = new System.Drawing.Size(100, 23);
            this.name_input_item_select.TabIndex = 0;
            this.name_input_item_select.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(555, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Yang Dipilih";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // input_lvl_makanan
            // 
            this.input_lvl_makanan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_lvl_makanan.Location = new System.Drawing.Point(112, 27);
            this.input_lvl_makanan.Name = "input_lvl_makanan";
            this.input_lvl_makanan.Size = new System.Drawing.Size(120, 25);
            this.input_lvl_makanan.TabIndex = 25;
            // 
            // topingcheck2
            // 
            this.topingcheck2.AutoSize = true;
            this.topingcheck2.Location = new System.Drawing.Point(159, 20);
            this.topingcheck2.Name = "topingcheck2";
            this.topingcheck2.Size = new System.Drawing.Size(59, 25);
            this.topingcheck2.TabIndex = 26;
            this.topingcheck2.Text = "Keju";
            this.topingcheck2.UseVisualStyleBackColor = true;
            this.topingcheck2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // topingcheck3
            // 
            this.topingcheck3.AutoSize = true;
            this.topingcheck3.Location = new System.Drawing.Point(235, 20);
            this.topingcheck3.Name = "topingcheck3";
            this.topingcheck3.Size = new System.Drawing.Size(67, 25);
            this.topingcheck3.TabIndex = 27;
            this.topingcheck3.Text = "Seres";
            this.topingcheck3.UseVisualStyleBackColor = true;
            // 
            // topingcheck1
            // 
            this.topingcheck1.AutoSize = true;
            this.topingcheck1.Location = new System.Drawing.Point(80, 20);
            this.topingcheck1.Name = "topingcheck1";
            this.topingcheck1.Size = new System.Drawing.Size(64, 25);
            this.topingcheck1.TabIndex = 28;
            this.topingcheck1.Text = "Boba";
            this.topingcheck1.UseVisualStyleBackColor = true;
            this.topingcheck1.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // box_toping
            // 
            this.box_toping.Controls.Add(this.topingcheck2);
            this.box_toping.Controls.Add(this.topingcheck1);
            this.box_toping.Controls.Add(this.topingcheck3);
            this.box_toping.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_toping.Location = new System.Drawing.Point(817, 43);
            this.box_toping.Name = "box_toping";
            this.box_toping.Size = new System.Drawing.Size(358, 51);
            this.box_toping.TabIndex = 31;
            this.box_toping.TabStop = false;
            this.box_toping.Text = "Toping Minuman";
            this.box_toping.Enter += new System.EventHandler(this.box_toping_Enter);
            // 
            // box_makanan
            // 
            this.box_makanan.Controls.Add(this.input_lvl_makanan);
            this.box_makanan.Enabled = false;
            this.box_makanan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_makanan.Location = new System.Drawing.Point(817, 96);
            this.box_makanan.Name = "box_makanan";
            this.box_makanan.Size = new System.Drawing.Size(338, 57);
            this.box_makanan.TabIndex = 32;
            this.box_makanan.TabStop = false;
            this.box_makanan.Text = "Level Pedas Makanan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 623);
            this.Controls.Add(this.box_makanan);
            this.Controls.Add(this.box_toping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablefoods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_outlit);
            this.Controls.Add(this.label_outlit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_member.ResumeLayout(false);
            this.panel_member.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_diskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefoods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_lvl_makanan)).EndInit();
            this.box_toping.ResumeLayout(false);
            this.box_toping.PerformLayout();
            this.box_makanan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_outlit;
        private ComboBox input_outlit;
        private Label label2;
        private Label label3;
        private Label label_nama;
        private Label label_alamat;
        private Label label_nohp;
        private TextBox input_nama;
        private TextBox input_alamat;
        private TextBox input_nohp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton MinumanOption;
        private RadioButton MakananOption;
        private Label label_note;
        private TextBox input_note;
        private Button submit;
        private Label label_kcustomer;
        private Label label10;
        private ComboBox input_takeaway;
        private RadioButton nonmember_option;
        private RadioButton member_option;
        private NumericUpDown input_jumlah;
        private Label label_jumlah;
        private Label label_takeaway;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView tablefoods;
        private Panel panel1;
        private Label label_item_select;
        private TextBox name_input_item_select;
        private TextBox harga_input_item_select;
        private Label label_harga_item_select;
        private Label label5;
        private NumericUpDown input_lvl_makanan;
        private CheckBox topingcheck2;
        private CheckBox topingcheck3;
        private CheckBox topingcheck1;
        private GroupBox box_toping;
        private GroupBox box_makanan;
        private Panel panel_member;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private NumericUpDown input_diskon;
    }
}