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

namespace Admissionform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Admissiondata.GetTableCountry();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "country";
            comboBox1.ValueMember = "country";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 =Admissiondata.GetTableCity(comboBox2.Text);
            comboBox3.DataSource = ds1.Tables[0];
            comboBox3.DisplayMember= "city";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = Admissiondata.GetTablestate(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "admin_name";
        }
    }
}
