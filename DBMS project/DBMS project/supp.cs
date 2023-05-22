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
    public partial class supp : Form
    {
        string db = "data source = orclll; user id =scott; password=tiger;";
        OracleConnection conn;
        public supp()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void supp_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT  ADDRESS FROM supplier";
            cmd.CommandType = CommandType.Text;
            OracleDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                comboBox1.Items.Add(d[0]);
            }
            d.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "suppPhone";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ADDress",comboBox1.Text);
            cmd.Parameters.Add("phone", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                
            }
            dr.Close();
        }
    }
}
