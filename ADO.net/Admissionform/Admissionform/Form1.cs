using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataSet ds = productstore.GetTableCountry();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "country";
            comboBox1.ValueMember = "country";
        }

    }
}
