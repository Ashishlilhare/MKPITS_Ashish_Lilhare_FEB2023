﻿using System;
            {
                textBox2.Text = dr["Product_price"].ToString();
            }

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
                calculate_total();
        
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
    }