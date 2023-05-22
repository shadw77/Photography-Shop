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
    public partial class Q4 : Form
    {
        string db = "data source = orclll; user id =scott; password=tiger;";
        OracleConnection conn;
        public Q4()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void Q4_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Q4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "photoType";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("type", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c_types.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
