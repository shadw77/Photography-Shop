using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DBMS_project
{
    public partial class payForm : Form
    {
        string db = "data source = orclll; user id =scott; password=tiger;";
        OracleConnection conn;
        public payForm()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }
        private void payForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
         
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT max(CUST_ID) FROM CUSTOMER";
            cmd.CommandType = CommandType.Text;
            string id = "";
            OracleDataReader dr = cmd.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                id = dr[0].ToString();
                MessageBox.Show(id);
                 x= int.Parse(id);
                x += 1;
                id = x.ToString();
                MessageBox.Show("Your customer id is "+id);
                idd.Text = id;
                
            }
            dr.Dispose();
            cmd.CommandText = "insert into CUSTOMER values (:FNAME,:MNAME,:NATIONAL_ID,:cust_id,:PHONENUMBER,:ADDRESS)";
            
            cmd.Parameters.Add("FNAME", txt_fname.Text);
            cmd.Parameters.Add("MNAME", txt_mname.Text);
            cmd.Parameters.Add("NATIONAL_ID", txt_id.Text);
            cmd.Parameters.Add("cust_id", idd.Text);
            cmd.Parameters.Add("PHONENUMBER", txt_phone.Text);
            cmd.Parameters.Add("ADDRESS", txt_address.Text);
            
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                
                MessageBox.Show("new customer Added");
                id = "";
            }

            
        }


        private void payForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

      
    }
}
