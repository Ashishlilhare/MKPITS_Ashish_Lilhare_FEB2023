using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectfendhal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Class_DB.GetNation();
            comboBox1.DataSource = ds.Tables["TableNation"];
            comboBox1.DisplayMember = "NationaName";
            comboBox1.ValueMember = "NationID";
            ;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds=Class_DB.GetState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds=Class_DB.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables["tablecity"];
            comboBox3.DisplayMember = "cityname";
            comboBox3.ValueMember = "cityid";
        }
    }
}
