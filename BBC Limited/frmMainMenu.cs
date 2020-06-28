using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBC_Limited
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void operationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierDetails sud = new frmSupplierDetails();
            sud.MdiParent = this;
            sud.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployees emp = new frmEmployees();
            emp.MdiParent = this;
            emp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemDetails idt = new frmItemDetails();
            idt.MdiParent = this;
            idt.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderDetails ord = new frmOrderDetails();
            ord.MdiParent = this;
            ord.Show();

        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductCategory prdct = new frmProductCategory();
            prdct.MdiParent = this;
            prdct.Show();
            
        }

       
        private void enquireSupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnquireSupplierDetails esupdt = new frmEnquireSupplierDetails();
            esupdt.MdiParent = this;
            esupdt.Show();
        }
    }
}
