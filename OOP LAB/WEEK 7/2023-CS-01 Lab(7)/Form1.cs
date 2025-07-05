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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-HCUI8PD\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True; trusted_connection=True";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string cmd = string.Format("INSERT INTO REGION VALUES(@RegionID,@RegionDescription)");
            
            SqlCommand cmd2 = new SqlCommand(cmd, connection);
            cmd2.Parameters.AddWithValue("@RegionID", int.Parse(textBox1.Text));
            cmd2.Parameters.AddWithValue("@RegionDescription", textBox2.Text);
            try
            {
                int c = cmd2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid data");
            }
            connection.Close();
            MessageBox.Show("Values inserted Succesfully");
        }
    }
}
