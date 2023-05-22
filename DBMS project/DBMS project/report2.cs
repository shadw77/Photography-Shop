using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.Shared;

namespace DBMS_project
{
   
    
    public partial class report2 : Form
    {
        CrystalReport4 cr1;
        public report2()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void report2_Load(object sender, EventArgs e)
        {
            cr1 = new CrystalReport4();
            foreach (ParameterDiscreteValue v in cr1.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr1.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
