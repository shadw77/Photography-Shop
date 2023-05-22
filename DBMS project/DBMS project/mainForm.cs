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
    public partial class mainForm : Form
    {
        public mainForm()
        {
             this.BackgroundImage = Properties.Resources.photo;  
            InitializeComponent();

           }     

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1  f = new Form1();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payForm secondForm;
            secondForm = new payForm();
            secondForm.Show();
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report r;
            r = new report();
            r.Show();
        }

        private void displayInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            photographer thirdForm;
            thirdForm = new photographer();
            thirdForm.Show();
        }

        private void displayTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q4 fourthForm;
            fourthForm = new Q4();
            fourthForm.Show();
        }

        private void displayPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disconn fifthForm;
            fifthForm = new disconn();
            fifthForm.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log;
            log = new login();
            log.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void displaySellerInSpecificLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sellerInfo sell;
            sell = new sellerInfo();
            sell.Show();
        }

        private void viewSupplierPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supp s;
            s = new supp();
            s.Show();
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2 r;
            r = new report2();
            r.Show();
        }
    }
}
