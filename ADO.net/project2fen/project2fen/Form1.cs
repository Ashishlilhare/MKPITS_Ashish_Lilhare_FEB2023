using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2fen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration.GetNation();
            comboBox1.DataSource = ds.Tables["TableNation"];
            comboBox1.DisplayMember = "Nationaname";
            comboBox1.ValueMember = "NationID";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds=new DataSet();
            ds=CourseRegistration.GetState(comboBox1.Text);
            comboBox2.DataSource =ds.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
