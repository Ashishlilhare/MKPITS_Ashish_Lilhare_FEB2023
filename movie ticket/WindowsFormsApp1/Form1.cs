using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";

            switch (comboBox1.Text)
            {
                case "Evil Dead Rise":
                    comboBox2.Items.Add("Alankar Cinema");
                    comboBox2.Items.Add("Inox");
                   break;
                case "Kisi Ka Bhai Kisi Ki Jaan":
                    comboBox2.Items.Add("MovieMax");
                    comboBox2.Items.Add("Panchsheel Cinema");
                    break;
                case "Bholaa":
                    comboBox2.Items.Add("PVR");
                    comboBox2.Items.Add("Liberty Cinema");
                    break;
                case "Avatar: The Way of Water":
                    comboBox2.Items.Add("Janki theater");
                    comboBox2.Items.Add("Sudama Talkies");
                    break;
                case "Tu Jhoothi Main Makkaar":
                    comboBox2.Items.Add("Goyal Talkies");
                    comboBox2.Items.Add("Wonder Cinema");
                    break; 

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "Alankar Cinema":
                    comboBox3.Items.Add("12:00");
                    comboBox3.Items.Add("6:00");
                    textBox1.Text = "250";
                    break;
                case "Inox":
                    comboBox3.Items.Add("9:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("6:00");
                    textBox1.Text = "500";
                    break;
                case "MovieMax":
                    comboBox3.Items.Add("9:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("6:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "100";
                    break;
                case "Panchsheel Cinema":
                    comboBox3.Items.Add("9:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("6:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "200";
                    break;
                case "PVR":
                    comboBox3.Items.Add("9:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("6:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "250";
                    break;
                case "Liberty Cinema":
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("6:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "500";
                    break;
                case "Janki theater":
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "250";
                    break;
                case "Sudama Talkies":
                    comboBox3.Items.Add("12:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "200";
                    break;
                case "Goyal Talkies":
                    comboBox3.Items.Add("9:00");
                    comboBox3.Items.Add("12:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "200";
                    break;
                case "Wonder Cinema":
                    comboBox3.Items.Add("9:00");
                    comboBox3.Items.Add("12:00");
                    comboBox3.Items.Add("3:00");
                    comboBox3.Items.Add("9:00");
                    textBox1.Text = "100";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt = new Online_Booking(comboBox1.Text,comboBox2.Text,comboBox3.Text,Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            else if (radioButton2.Checked) 
            {
                mt=new BoxOffice(comboBox1.Text,comboBox2.Text,comboBox3.Text,Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            label7.Text=mt.Calculate_Ticket_Price();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
