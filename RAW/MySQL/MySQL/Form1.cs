using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string ConnectionString = "Driver={MySQL};SERVER = localhost; " + "DATABASE= NorthwindMySQL; ";
            OdbcConnection conn = new OdbcConnection(ConnectionString);
            conn.Open();

            OdbcDataAdapter da = new OdbcDataAdapter
            ("SELECT CustomerID, ContactName, ContactTitle FROM Customers", conn);

            DataSet ds = new DataSet("cust");
            da.Fill(ds, "Customers");
            dataGrid1.DataSource = ds.DefaultViewManager;

            conn.Close();

        }
    }
}