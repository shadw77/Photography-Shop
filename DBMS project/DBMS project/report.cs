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
    public partial class report : Form
    {
        CrystalReport3 cr1;
        public report()
        {
            this.BackgroundImage = Properties.Resources.pho;  
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr1.SetParameterValue(0, comboBox1.Text);
            cr1.SetParameterValue(1, textBox1.Text);
            cr1.SetParameterValue(2, textBox2.Text);
            crystalReportViewer1.ReportSource = cr1;
        }

        private void report_Load(object sender, EventArgs e)
        {
            cr1 = new CrystalReport3();
            foreach (ParameterDiscreteValue v in cr1.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }
    }
}
