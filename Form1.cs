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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Nama", Type.GetType("System.String"));
            table.Columns.Add("Nohp", Type.GetType("System.String"));
            table.Columns.Add("Alamat", Type.GetType("System.String"));
            dataGridView1.DataSource = table;

            //dt.Columns.AddRange(new DataColumn[3]
            //    (
            //    new DataColumn("nama", typeof(string)),
            //    new DataColumn("noHp", typeof(string)),
            //    new DataColumn("Alamat", typeof(string))
            //    )
            //    );

            //DataGridViewTextBoxColumn Col1 = new DataGridViewTextBoxColumn();
            //Col1.HeaderText = "test";
            //DataGridViewTextBoxColumn Col2 = new DataGridViewTextBoxColumn();
            //Col2.HeaderText = "test2";
            //DataGridViewTextBoxColumn Col3 = new DataGridViewTextBoxColumn();
            //Col3.HeaderText = "test3";
            //
            //dt.Columns.AddRange(Columns :new DataColumn[3]);

            drinkpage.Hide();
            foodpage.Hide();
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
            drinkpage.Hide();

            foodpage.Show();

            foodpage.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foodpage.Hide();

            drinkpage.Show();

            drinkpage.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drinkpage.Hide();

            foodpage.Show();

            foodpage.BringToFront();
        }

        private void MinumanOption_CheckedChanged(object sender, EventArgs e)
        {
            foodpage.Hide();

            drinkpage.Show();

            drinkpage.BringToFront();
        }

        private void foodpage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dt.Rows.Add(input_nama.Text, input_nohp.Text, input_alamat.Text);
            //this.dataGridView1.DataSource = dt;

            table.Rows.Add(input_nama.Text, input_nohp.Text, input_alamat.Text);

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