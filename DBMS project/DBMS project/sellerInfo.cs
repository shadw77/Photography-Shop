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
    public partial class sellerInfo : Form
    {

        string db = "data source = orclll; user id =scott; password=tiger;";
        OracleConnection conn;
        public sellerInfo()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void sellerInfo_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = true;
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT  S_LOCATION FROM SELLER ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {       
                comboBox1.Items.Add(d[0]);   
            }
            d.Close();
            for (int i = 0; i < comboBox1.Items.Count; i++) {
                for (int j = i+1; j < comboBox1.Items.Count; j++)
                {
                    if (comboBox1.Items[i].Equals(comboBox1.Items[j]))
                    {
                        comboBox1.Items.Remove(comboBox1.Items[i]);
                    }
                }  
                }  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT PHONE, FNAME, LNAME,BUISNESS_EMAIL,S_LOCATION FROM seller where S_LOCATION=:loc";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("loc", comboBox1.Text);


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("PHONE");
            dataTable.Columns.Add("FNAME");
            dataTable.Columns.Add("LNAME");
            dataTable.Columns.Add("BUISNESS_EMAIL");
            dataTable.Columns.Add("S_LOCATION");

     
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["PHONE"] = dr[0];
                row["FNAME"] = dr[1];
                row["LNAME"] = dr[2];
                row["BUISNESS_EMAIL"] = dr[3];
                row["S_LOCATION"] = dr[4];
                dataTable.Rows.Add(row);
                

            }
            dataGridView1.DataSource = dataTable;
 
            dr.Close();
        }
    }
}
