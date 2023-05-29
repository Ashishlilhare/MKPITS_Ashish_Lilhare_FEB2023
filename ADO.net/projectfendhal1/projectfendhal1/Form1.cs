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
        enum Category { Student,IT_Professional}
        enum Gender { Male, Female, Other}    
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        Category category;
        Gender gender;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = Category.IT_Professional;
                textBox2.Text = "3000";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = Category.Student;
                textBox2.Text = "1000";
            }
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
            textBox2.Text="1000";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        double total = 0;
        double fp = 0;
        double bal_amount = 0;

        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount();
        }
        public void check_balance_amount()
        {
            total=Convert.ToDouble(textBox2.Text);
            
            if (category==0)
            {
                fp = total * 0.5;
            }
            else 
            { 
                fp=total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {
                MessageBox.Show("paid amount should be atleast 50% for student & 80% for IT professional");
            }
            else
            {
                double bal_amount=Convert.ToDouble(textBox2.Text)-Convert.ToDouble(textBox3.Text);
                textBox4.Text = bal_amount.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = Class_DB.saveTableCourseRegDetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
            MessageBox.Show(result);
            result = Class_DB.saveTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(comboBox2.SelectedValue),Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);
            result=Class_DB.saveTableFeeDetail(Convert.ToDouble(textBox2.Text),Convert.ToDouble(textBox4.Text),fp,Convert.ToDouble(textBox3.Text),dateTimePicker1.Value);
            MessageBox.Show(result);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked)
                gender = Gender.Male;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton4.Checked)
                gender = Gender.Female;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton5.Checked)
                gender = Gender.Other;

        }
    }
}
