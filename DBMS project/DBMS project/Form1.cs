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
using System.IO;
using System.Data.SqlClient;

namespace DBMS_project
{
    public partial class Form1 : Form
    {
        string db = "data source = orclll; user id =scott; password=tiger;";
        OracleConnection conn;
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }
       
        public static Image ToIm(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT  P_NAME FROM PRODUCT";
            cmd.CommandType = CommandType.Text;
            OracleDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                comboBox1.Items.Add(d[0]);
            }
          
          /*  cmd.CommandText = "SELECT  IMAGE FROM PRODUCT_IMAGE";
            cmd.CommandType = CommandType.Text;
            d = cmd.ExecuteReader();
            while (d.Read())
            {
                
                byte[] byteBLOBData = (byte[])d[0];
                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(byteBLOBData));
                pictureBox1.Image = x;
                pictureBox1.Image =d.GetOracleBlob(0);
                pictureBox1.Image =ToIm(byteBLOBData);
                
                }
                d.Close();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT P_ID, COUNTRY, PRICE,BRAND,P_CATEGORY,YEAR_OF_RELEASE FROM PRODUCT where P_NAME=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", comboBox1.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id.Text = dr[0].ToString();
                country.Text = dr[1].ToString();
                price.Text = dr[2].ToString();
                brand.Text = dr[3].ToString();
                category.Text = dr[4].ToString();
                year_of_release.Text = dr[5].ToString();

            }
            dr.Close();
        }

       
    }
}
