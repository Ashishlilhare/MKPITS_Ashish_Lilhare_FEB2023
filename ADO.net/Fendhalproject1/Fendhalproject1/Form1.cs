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
using System.Data.SqlClient;

namespace Fendhalproject1
{

    public partial class Form1 : Form
    {
        //creating an enum Nationality
        enum Nationality { Indian, NRI }
        double cgst = 0;
        double sgst = 0;
        double igst = 0;
        double tgst = 0;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = productstore.GetTableProductCategory();
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "product_type_name";
            comboBox3.ValueMember = "product_category_id";


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;

            DataSet ds = productstore.GettableProductName(comboBox3.Text);
            comboBox4.DataSource = ds.Tables[0];
            comboBox4.DisplayMember = "Productname";
            comboBox4.ValueMember = "ProductID";


            //filling the gst detail box
            DataSet ds11 = productstore.GetGstDetail(comboBox3.Text);
            foreach (DataRow dr1 in ds11.Tables[0].Rows)
            {
                cgst = Convert.ToDouble(dr1["cgst"].ToString());
                sgst = Convert.ToDouble(dr1["sgst"].ToString());
                igst = Convert.ToDouble(dr1["igst"].ToString());
            }
            if (nationality == 0)
            {
                tgst = cgst + sgst;//pro//
            }
            else
            {
                tgst = igst;
            }
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = igst.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filling the product price
            DataSet ds1 = productstore.GetProductprice(comboBox4.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox12.Text = dr["Product_price"].ToString();
            }
        }
        Nationality nationality;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            // MessageBox.Show(nationality.ToString());
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text));
            calculate_total();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            // MessageBox.Show(nationality.ToString());
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = igst.ToString();
            calculate_total();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {

            double totalamount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox12.Text);
            textBox3.Text = totalamount.ToString();
            double cgstamount = Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(textBox6.Text) / 100);
            textBox9.Text = cgstamount.ToString();
            double sgstamount = Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(textBox7.Text) / 100);
            textBox10.Text = sgstamount.ToString();
            double igsamount = Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(textBox8.Text) / 100);
            textBox11.Text = igsamount.ToString();


            double netamount = 0;
            if (nationality == 0)
            {
                netamount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);
            }
            else
            {
                netamount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);
            }
            textBox5.Text = netamount.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }
        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the detail");
            }
            else if (textBox4.Text == "0")
            {
                MessageBox.Show("quantity can not be zero");
            }
            else
            {
                string result = productstore.saveTableInvoiceDetails1(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(nationality), dateTimePicker2.Value, Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox12.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox11.Text), Convert.ToDecimal(textBox3.Text));
                MessageBox.Show(result);

            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

