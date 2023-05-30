using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project3fendhal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ProductDB.GetName();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
            //listBox1.ValueMember = "ID";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductDB.GETDetails(listBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {

                textBox1.Text = dr["Name"].ToString();


            }
        }
    }
}
