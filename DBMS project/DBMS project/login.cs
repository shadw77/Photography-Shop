using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class login : Form
    {
        public login()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("scott") && textBox2.Text.Equals("tiger"))
            {
                displayCust f;
                f = new displayCust();
                f.Show();
            }
        }
    }
}
