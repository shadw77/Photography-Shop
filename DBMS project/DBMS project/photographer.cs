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
    public partial class photographer : Form
    {
        string db = "data source = orclll; user id =scott; password=tiger;";
        OracleConnection conn;
        public photographer()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void photographer_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SCOTT.GET_PHOTOGRAPHERINFO";
            cmd.CommandType = CommandType.StoredProcedure;
            
             cmd.Parameters.Add("fname",txt_fname.Text);
             cmd.Parameters.Add("phone", OracleDbType.Int32,ParameterDirection.Output);

             int r = cmd.ExecuteNonQuery();
            // if (r != -1)
             {

                 int x = Convert.ToInt32(cmd.Parameters["phone"].Value.ToString());
                 txt_phone.Text = x.ToString();

             }

            /*

            OracleDataReader dr = cmd.ExecuteReader();
            Console.Out.WriteLine(dr);
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txt_phone.Text = dr[0].ToString();

                }
            }
            dr.Close();

        */
        }

       

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }
        private void photographer_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

      
    }
}
