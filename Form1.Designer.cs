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
            this.label_takeaway = new System.Windows.Forms.Label();
            this.input_jumlah = new System.Windows.Forms.NumericUpDown();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.diskonmember = new contoh2.pageDiskon();
            this.nonmember_option = new System.Windows.Forms.RadioButton();
            this.member_option = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.input_takeaway = new System.Windows.Forms.ComboBox();
            this.label_kcustomer = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.input_note = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.MinumanOption = new System.Windows.Forms.RadioButton();
            this.MakananOption = new System.Windows.Forms.RadioButton();
            this.label_pilih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tablefoods = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefoods)).BeginInit();
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
            this.groupBox2.Controls.Add(this.label_takeaway);
            this.groupBox2.Controls.Add(this.input_jumlah);
            this.groupBox2.Controls.Add(this.label_jumlah);
            this.groupBox2.Controls.Add(this.diskonmember);
            this.groupBox2.Controls.Add(this.nonmember_option);
            this.groupBox2.Controls.Add(this.member_option);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.input_takeaway);
            this.groupBox2.Controls.Add(this.label_kcustomer);
            this.groupBox2.Controls.Add(this.submit);
            this.groupBox2.Controls.Add(this.input_note);
            this.groupBox2.Controls.Add(this.label_note);
            this.groupBox2.Controls.Add(this.MinumanOption);
            this.groupBox2.Controls.Add(this.MakananOption);
            this.groupBox2.Controls.Add(this.label_pilih);
            this.groupBox2.Location = new System.Drawing.Point(416, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 367);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // diskonmember
            // 
            this.diskonmember.Location = new System.Drawing.Point(15, 288);
            this.diskonmember.Name = "diskonmember";
            this.diskonmember.Size = new System.Drawing.Size(331, 29);
            this.diskonmember.TabIndex = 27;
            this.diskonmember.Load += new System.EventHandler(this.diskonmember_Load);
            // 
            // nonmember_option
            // 
            this.nonmember_option.AutoSize = true;
            this.nonmember_option.Location = new System.Drawing.Point(253, 252);
            this.nonmember_option.Name = "nonmember_option";
            this.nonmember_option.Size = new System.Drawing.Size(98, 19);
            this.nonmember_option.TabIndex = 26;
            this.nonmember_option.TabStop = true;
            this.nonmember_option.Text = "Non-Member";
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
            this.member_option.TabStop = true;
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
            this.submit.Location = new System.Drawing.Point(202, 323);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(144, 39);
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
            // MinumanOption
            // 
            this.MinumanOption.AutoSize = true;
            this.MinumanOption.Location = new System.Drawing.Point(186, 30);
            this.MinumanOption.Name = "MinumanOption";
            this.MinumanOption.Size = new System.Drawing.Size(77, 19);
            this.MinumanOption.TabIndex = 19;
            this.MinumanOption.TabStop = true;
            this.MinumanOption.Text = "Minuman";
            this.MinumanOption.UseVisualStyleBackColor = true;
            this.MinumanOption.CheckedChanged += new System.EventHandler(this.MinumanOption_CheckedChanged);
            // 
            // MakananOption
            // 
            this.MakananOption.AutoSize = true;
            this.MakananOption.Location = new System.Drawing.Point(75, 30);
            this.MakananOption.Name = "MakananOption";
            this.MakananOption.Size = new System.Drawing.Size(74, 19);
            this.MakananOption.TabIndex = 18;
            this.MakananOption.TabStop = true;
            this.MakananOption.Text = "Makanan";
            this.MakananOption.UseVisualStyleBackColor = true;
            this.MakananOption.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label_pilih
            // 
            this.label_pilih.AutoSize = true;
            this.label_pilih.Location = new System.Drawing.Point(16, 30);
            this.label_pilih.Name = "label_pilih";
            this.label_pilih.Size = new System.Drawing.Size(30, 15);
            this.label_pilih.TabIndex = 15;
            this.label_pilih.Text = "Pilih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(391, 306);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 274);
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
            this.tablefoods.Location = new System.Drawing.Point(801, 98);
            this.tablefoods.Name = "tablefoods";
            this.tablefoods.RowTemplate.Height = 25;
            this.tablefoods.Size = new System.Drawing.Size(384, 513);
            this.tablefoods.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 623);
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
            ((System.ComponentModel.ISupportInitialize)(this.input_jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefoods)).EndInit();
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
        private Label label_pilih;
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
        private pageDiskon diskonmember;
        private NumericUpDown input_jumlah;
        private Label label_jumlah;
        private Label label_takeaway;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView tablefoods;
    }
}