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

namespace dropbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Text = "";
            comboBox4.Items.Clear();
            string country = comboBox3.Text;
            // MessageBox.Show(country);
        switch (country) 
            {
                case "India":
                    comboBox4.Items.Add("Mumbai");
                    comboBox4.Items.Add("Bengluru");
                    comboBox4.Items.Add("Hyderabad");
                break;
                case "Usa":
                    comboBox4.Items.Add("New York");
                    comboBox4.Items.Add("Los Angeles");
                    comboBox4.Items.Add("Chocago");
                break;
                case "China" :
                    comboBox4.Items.Add("Beijing");
                    comboBox4.Items.Add("Shanghai ");
                    comboBox4.Items.Add("Chongqing");
                break;
                case "Russia":
                    comboBox4.Items.Add("Moscow");
                    comboBox4.Items.Add("Saint Petersburg ");
                    comboBox4.Items.Add("Novosibirsk");
                break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
