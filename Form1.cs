using System.Data;
using System.Text;
using System.Windows.Forms;

namespace contoh2
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");

        //System.Data.DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

            
            //imgcol.HeaderText = "Gambar";
            //imgcol.Name = "Gambar";
            //imgcol2.Name = "a";
            //imgcol3.Name = "ambar";
            //Image image = Image.FromFile(path);
            //imgcol.Image = image;
            //tablefoods.Columns.Add(imgcol);
            //tablefoods.Columns.Add(imgcol);
            //tablefoods.Columns.Add(imgcol);


            //tablefoods.ColumnCount = 3;
            //tablefoods.Columns[0].Name = "img";
            //tablefoods.Columns[1].Name = "Nama";
            //tablefoods.Columns[2].Name = "Harga";
            //
            //
            //  
            //tablefoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        string menunya;

        private void Datamakanan()
        {

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
            Image gambar = Image.FromFile("C:\\img\\ayam-rica.JPG");
            string namafoods = "Ayam Rica";
            int price = 20000;
            Object[] row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 2
            gambar = Image.FromFile("C:\\img\\ayam-geprek.JPG");
            namafoods = "Ayam Geprek";
            price = 15000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 3
            gambar = Image.FromFile("C:\\img\\nasi-goreng.JPG");
            namafoods = "Nasi Goreng";
            price = 15000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 4
            gambar = Image.FromFile("C:\\img\\nasi-bakar.JPG");
            namafoods = "Nasi Bakar";
            price = 25000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 5
            gambar = Image.FromFile("C:\\img\\ayam-sambal.JPG");
            namafoods = "Ayam Sambal";
            price = 15000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);
          
             
          
            

            //row = new[] {$"{image1}","ayam Bakar","Rp. 17.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar ayam Geprek","ayam Geprel","Rp. 18.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar ayam Sambal","ayam Sambal","Rp. 20.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar ayam rica","ayam Rica","Rp. 15.000"};
            //tablefoods.Rows.Add(row);

            

        } 
        private void Dataminuman()
        {
            //bersih kan semua table
            tablefoods.Rows.Clear();
            tablefoods.Columns.Clear();

            DataGridViewImageColumn img = new DataGridViewImageColumn();

            //Create Name column/Field 
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
            Image gambar = Image.FromFile("C:\\img\\milo.JPG");
            string namafoods = "Milo Dingin";
            int price = 15000;
            Object[] row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 2
            gambar = Image.FromFile("C:\\img\\taro.JPG");
            namafoods = "Taro";
            price = 16000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 3
            gambar = Image.FromFile("C:\\img\\ice-cream.JPG");
            namafoods = "Ice Cream";
            price = 15000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 4
            gambar = Image.FromFile("C:\\img\\capucino-blend.JPG");
            namafoods = "Capucino Bleand";
            price = 25000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //data 5
            gambar = Image.FromFile("C:\\img\\redvelvet.JPG");
            namafoods = "Red velvet";
            price = 15000;
            row = new object[] { gambar, namafoods, $"Rp. {price}" };
            tablefoods.Rows.Add(row);

            //tablefoods.Rows.Clear();
            //string[] row ={$"gambar Taro{menunya}","Taro","Rp. 15.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar Milo","Milo","Rp. 17.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar Sanger","Sanger","Rp. 18.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar Red Velvet","Redvelvet","Rp. 20.000"};
            //tablefoods.Rows.Add(row);
            //
            //row = new[] {"gambar Macha","Macha","Rp. 15.000"};
            //tablefoods.Rows.Add(row);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (menunya == "makanan")
            {
                
            }else if(menunya == "minuman")
            {

            }
            //FillData();
            table.Columns.Add("---Struk---", Type.GetType("System.String"));
            table.Columns.Add("p", Type.GetType("System.String"));
            //table.Columns.Add("Alamat", Type.GetType("System.String"));
            dataGridView1.DataSource = table;

            //drinkpage.Hide();
            //foodpage.Hide();
            diskonmember.Hide();

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
            //drinkpage.Hide();

            //foodpage.Show();

            //foodpage.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foodpage.Hide();

            //drinkpage.Show();

            //drinkpage.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Datamakanan();
            menunya = "makanan";
            //drinkpage.Hide();

            //foodpage.Show();

            //foodpage.BringToFront();
        }

        private void MinumanOption_CheckedChanged(object sender, EventArgs e)
        {
            Dataminuman();
            menunya = "minuman";
            //foodpage.Hide();

            //drinkpage.Show();

            //drinkpage.BringToFront();
        }

        private void foodpage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //kosongkan dahulu
            table.Rows.Clear();

            //lalu isi dengan data baru
            table.Rows.Add("Nama ", input_nama.Text);
            table.Rows.Add("No Hp ", input_nohp.Text);
            table.Rows.Add("Alamat ", input_alamat.Text);

            table.Rows.Add("", "");

            table.Rows.Add("Menu ", "Nasi Goreng");
            table.Rows.Add("Jumlah ", input_jumlah.Text);
            table.Rows.Add("Harga ", "Rp 15.000");
            int pajak = 1500 * Int16.Parse(input_jumlah.Text);
            int total = 15000 * Int16.Parse(input_jumlah.Text) + pajak;
            table.Rows.Add("Pajak ", pajak);
            table.Rows.Add("Total ", $"RP. {total}");

            //kosongkan input
            input_nama.Text = String.Empty;
            input_nohp.Text = String.Empty;
            input_alamat.Text = String.Empty;


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
            diskonmember.Show();

            diskonmember.BringToFront();
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            diskonmember.Hide();
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

       
    }
}