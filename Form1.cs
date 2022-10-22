namespace contoh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}