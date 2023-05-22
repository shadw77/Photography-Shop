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
    public partial class disconn : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder ;
        DataSet ds;
        public disconn()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void disconn_Load(object sender, EventArgs e)
        {

          
            
        }

        private void disconn_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "data source = orclll; user id =scott; password=tiger;";
             string cmdstr = "SELECT p_id, price from Product p where p.P_NAME=:name";
          //  string cmdstr = "SELECT * from Product";

            adapter = new OracleDataAdapter(cmdstr, constr);
           adapter.SelectCommand.Parameters.Add("name", textBox1.Text);
            
            ds = new DataSet();
            adapter.Fill(ds);
          
            dataGridView1.DataSource = ds.Tables[0];
      
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update price
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Price updated");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
