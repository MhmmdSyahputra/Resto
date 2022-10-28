using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection.Emit;
using Resto.Properties;

namespace contoh2
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");

        //System.Data.DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

        }
        string menunya;

        private void Datamakanan()
        {
            //bersih kan semua table
            tablefoods.Rows.Clear();
            tablefoods.Columns.Clear();


            //Create Name column/Field 
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "gambar";
            img.ImageLayout = DataGridViewImageCellLayout.Stretch; //width=100%

            DataGridViewTextBoxColumn nama = new DataGridViewTextBoxColumn();
            nama.Name = "Nama";

            DataGridViewTextBoxColumn harga = new DataGridViewTextBoxColumn();
            harga.Name = "harga";

            //Insert data Column tadi
            tablefoods.Columns.Add(img);
            tablefoods.Columns.Add(nama);
            tablefoods.Columns.Add(harga);

            //setting img agar terlihat lebar
            tablefoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablefoods.RowTemplate.Height = 90;
            tablefoods.AllowUserToAddRows = false;

            //data 1
            Image gambar = Resources.ayam_rica;
            string namafoods = "Ayam Rica";
            int price = 20000;
            Object[] row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 2
            gambar = Resources.ayam_geprek;
            namafoods = "Ayam Geprek";
            price = 15000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 3
            gambar = Resources.nasi_goreng;
            namafoods = "Nasi Goreng";
            price = 15000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 4
            gambar = Resources.nasi_bakar;
            namafoods = "Nasi Bakar";
            price = 25000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 5
            gambar = Resources.ayam_sambal;
            namafoods = "Ayam Sambal";
            price = 15000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 6
            gambar = Resources.ayam_bakar;
            namafoods = "Ayam Bakar";
            price = 18000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);



        }
        private void Dataminuman()
        {
            //bersih kan semua table
            tablefoods.Rows.Clear();
            tablefoods.Columns.Clear();

            //Create Name column/Field 
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "gambar";
            img.ImageLayout = DataGridViewImageCellLayout.Stretch; //width=100%

            DataGridViewTextBoxColumn nama = new DataGridViewTextBoxColumn();
            nama.Name = "Nama";

            DataGridViewTextBoxColumn harga = new DataGridViewTextBoxColumn();
            harga.Name = "harga";

            //Insert data Column tadi
            tablefoods.Columns.Add(img);
            tablefoods.Columns.Add(nama);
            tablefoods.Columns.Add(harga);

            //setting img agar terlihat lebar
            tablefoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablefoods.RowTemplate.Height = 90;
            tablefoods.AllowUserToAddRows = false;

            //data 1
            Image gambar = Resources.milo;
            string namafoods = "Milo Dingin";
            int price = 15000;
            Object[] row = new object[] { gambar, namafoods, price };
            tablefoods.Rows.Add(row);

            //data 2
            gambar = Resources.taro;
            namafoods = "Taro";
            price = 16000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 3
            gambar = Resources.ice_cream;
            namafoods = "Ice Cream";
            price = 15000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 4
            gambar = Resources.capucino_blend;
            namafoods = "Capucino Bleand";
            price = 25000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 5
            gambar = Resources.redvelvet;
            namafoods = "Red velvet";
            price = 15000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

            //data 6
            gambar = Resources.sanger;
            namafoods = "Sanger";
            price = 15000;
            row = new object[] { gambar, namafoods, $"{price}" };
            tablefoods.Rows.Add(row);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            box_toping.Enabled = true;

            Dataminuman();

            table.Columns.Add("    GEPREK NAMPOL ", Type.GetType("System.String"));
            table.Columns.Add(" ", Type.GetType("System.String"));
            dataGridView1.DataSource = table;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Datamakanan();
            string makanan = MakananOption.Text.ToString(); ;

            //jika checkbox yg dipilih makanan maka
            if (makanan == "Makanan")
            {
                //box toping disabled
                box_toping.Enabled = false;

                //box makanan enabled
                box_makanan.Enabled = true;

                //and value checkbox set empty
                topingcheck1.Checked = false;
                topingcheck2.Checked = false;
                topingcheck3.Checked = false;
            }

        }

        private void MinumanOption_CheckedChanged(object sender, EventArgs e)
        {
            string minuman = MinumanOption.Text.ToString();
            Dataminuman();

            //jika checkbox yg dipilih minuman maka
            if (minuman == "Minuman")
            {
                //box makanan disabled
                box_makanan.Enabled = false;

                //box toping enabled
                box_toping.Enabled = true;

                //and value input level set 0
                input_lvl_makanan.Value = 0;
            }

        }

        private void foodpage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if(name_input_item_select.Text == String.Empty)
            {
                MessageBox.Show("Pilih menu yang valid");
                return;
            }

            //kosongkan dahulu
            table.Rows.Clear();

            //jika button pn click muncul popup
            MessageBox.Show("Makanan Berhasil Dipesan!");

            //mengecek satu persatu isi dari checkbox apakah di pilih atau tidak
            //jika dipilih simpan value nya
            string toping1 = "";
            if (topingcheck1.CheckState == CheckState.Checked)
            {
                toping1 += "Boba";
            }

            string toping2 = "";
            if (topingcheck2.CheckState == CheckState.Checked)
            {
                toping2 += "Keju";
            }

            string toping3 = "";
            if (topingcheck3.CheckState == CheckState.Checked)
            {
                toping3 += "Seres";
            }

            //membuat data baru/field
            table.Rows.Add("Nama ", input_nama.Text);
            table.Rows.Add("No Hp ", input_nohp.Text);
            table.Rows.Add("Alamat ", input_alamat.Text);
            table.Rows.Add("Order ", input_takeaway.Text);

            table.Rows.Add("-------------------", "-------------------");

            //add row nama item
            table.Rows.Add("Menu ", name_input_item_select.Text);

            string minuman = MinumanOption.Text.ToString();
            string makanan = MakananOption.Text.ToString();
            //jika yg dipilih minuman berarti toping terisi
            if (minuman == "Minuman")
            {
                table.Rows.Add("Toping ", $"{toping1} {toping2} {toping3}");

            }

            //jika yg dipilih makanan berarti level terisi
            if (makanan == "Makanan")
            {
                table.Rows.Add("Level ", input_lvl_makanan.Text);
            }
            //add row jumlah item
            table.Rows.Add("Jumlah ", input_jumlah.Text);

            //add row harga item
            table.Rows.Add("Harga/Item ", String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", harga_input_item_select.Text));
            int pajak = 1500 * Int16.Parse(input_jumlah.Text);
            int total = Int16.Parse(harga_input_item_select.Text) * Int16.Parse(input_jumlah.Text) + pajak;

            //add row pajak
            table.Rows.Add("Pajak ", String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", pajak));

            int diskon = total * Int16.Parse(input_diskon.Text) / 100;
            //add row diskon
            table.Rows.Add("Diskon ", String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", diskon));

            //add row total bayar
            table.Rows.Add("Total ", String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", total));

            //add row total bayar potong diskon
            table.Rows.Add("Total Dengan Diskon ", String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", total - diskon));

            //kosongkan input
            input_nama.Text = String.Empty;
            input_nohp.Text = String.Empty;
            input_alamat.Text = String.Empty;

            makanan = "";
            minuman = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            string member = member_option.Text.ToString(); ;

            //jika radiobtn yg dipilikh member
            if (member == "Member")
            {
                //maka panel member enabled
                panel_member.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            string nonmember = nonmember_option.Text.ToString(); ;

            //jika radiobtn yg dipilikh non-member
            if (nonmember == "Non_Member")
            {
                //maka panel member disabled
                panel_member.Enabled = false;
                //and value textbox set 0
                input_diskon.Value = 0;
            }
        }

        private void diskonmember_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void input_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tablefoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //jika table di select atau dipilih atau data nya ada/tidak kosong
            if (tablefoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //jika table yg dipilih true
                tablefoods.CurrentRow.Selected = true;

                //maka simpan masing masing nilai nya
                name_input_item_select.Text = tablefoods.Rows[e.RowIndex].Cells["nama"].FormattedValue.ToString();
                harga_input_item_select.Text = tablefoods.Rows[e.RowIndex].Cells["harga"].FormattedValue.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_item_select_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box_toping_Enter(object sender, EventArgs e)
        {

        }
    }
}