using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;using System.Data.SqlClient;using System.Data;using static System.Windows.Forms.VisualStyles.VisualStyleElement;using System.Security.Cryptography.X509Certificates;namespace fen1{    public partial class Form1 : Form    {        //creating a enumumeration for Nationality        enum Nationality { Indian, NRI }        double cgst = 0;        double sgst = 0;        double igst = 0;        double tgst = 0;        Nationality nationality;        public Form1()        {            InitializeComponent();        }        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)        {            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            {                e.Handled = true;            }        }        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)        {            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            {                e.Handled = true;            }        }        private void label17_Click(object sender, EventArgs e)        {        }        private void groupBox1_Enter(object sender, EventArgs e)        {        }        private void Form1_Load(object sender, EventArgs e)        {            DataSet ds = ProStore.Gettableproductcategory();            comboBox1.DataSource = ds.Tables[0];            comboBox1.DisplayMember = "product_type_name";            comboBox1.ValueMember = "product_category_id";        }        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)        {            nationality = Nationality.Indian;            DataSet ds = ProStore.GettableProductName(comboBox1.Text);            comboBox2.DataSource = ds.Tables[0];            comboBox2.DisplayMember = "ProductName";            comboBox2.ValueMember = "productid";            //filling the gst textbox           DataSet ds1 = ProStore.GetGstdetails(comboBox1.Text);            foreach (DataRow dr in ds1.Tables[0].Rows)            {                cgst = Convert.ToDouble(dr["cgst"].ToString());                sgst = Convert.ToDouble(dr["sgst"].ToString());                igst = Convert.ToDouble(dr["igst"].ToString());            }            if (nationality == 0)            {                tgst = igst;            }            textBox4.Text=cgst.ToString();            textBox5.Text=sgst.ToString();            textBox6.Text=tgst.ToString();        }        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)        {            DataSet ds =ProStore.GetProductprice(comboBox2.Text);            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                textBox2.Text = dr["Product_price"].ToString();
            }        }        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)        {        }        private void radioButton1_CheckedChanged(object sender, EventArgs e)        {            nationality=Nationality.Indian;            textBox4.Text = cgst.ToString();            textBox5.Text = sgst.ToString();            textBox6.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text));            calculate_total();        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;

            textBox4.Text = cgst.ToString();
            textBox5.Text = sgst.ToString();
            textBox6.Text = igst.ToString();
            calculate_total();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text=="")
            {

            }
            else
            {
                calculate_total();            }
        
        }
        public void calculate_total()
        {
            double totalamount=Convert.ToDouble(textBox2.Text)*Convert.ToDouble(textBox2.Text);
            textBox10.Text = totalamount.ToString();

            double cgstamount = Convert.ToDouble(textBox2.Text)*Convert.ToDouble(textBox4.Text)/100;
            textBox7.Text = cgstamount.ToString();

            double sgstamount = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox5)/100;
            textBox8.Text = sgstamount.ToString();

            double igstamount = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox6.Text)/100;
            textBox9.Text = igstamount.ToString();

            double netamount = 0;
            if (nationality == 0)
            {
                netamount = Convert.ToDouble(textBox9.Text)+Convert.ToDouble(textBox10);
            }
            else
            {
                netamount = Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox10);
            }
            textBox11.Text=netamount.ToString();
        }
    }}