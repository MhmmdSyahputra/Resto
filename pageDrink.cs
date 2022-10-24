using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contoh2
{
    public partial class pageDrink : UserControl
    {
        public pageDrink()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void pageDrink_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("table");

            //string[] milo = new String[] { "img", "Milo", "15.000" };
            //string[] taro = new String[] { "img", "Taro", "16.000" };
            //string[] ice_cream = new String[] { "img", "Ice Cream", "15.000" };
            //string[] capucino_blend = new String[] { "img", "Capucino Blend", "25.000" };
            //string[] red_velvet = new String[] { "img", "Red Velvet", "20.000" };
            //string[] Sanger = new String[] { "img", "Sanger", "20.000" };

            string[] arr1 = new String[] { "a", "b", "c" };

            string[] arr2 = new String[] { "d", "e", "f" };

            dt.Columns.Add("img", Type.GetType("System.String"));
            dt.Columns.Add("nama", Type.GetType("System.String"));
            

            //DataRow row;
            //var numberOfRows = 3;
            //for (int i = 0; i < numberOfRows; i++)
            //{
            //    row = dt.NewRow();
            //    if (i < arr1.Length)
            //        row["Column1"] = arr1[i];
            //    if (i < arr2.Length)
            //        row["Column2"] = arr2[i];
            //    dt.Rows.Add(row);
            //}

        }
    }
}
