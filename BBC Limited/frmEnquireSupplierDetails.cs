using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DbaseData;


namespace BBC_Limited
{
    public partial class frmEnquireSupplierDetails : Form
    {
        public frmEnquireSupplierDetails()
        {
            InitializeComponent();
        }

        private void frmEnquireSupplierDetails_Load(object sender, EventArgs e)
        {
            Result_grpbx.Visible = false;
            ClearClose_grpbx.Visible = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

            Dbase db = new Dbase();

            string[] EbRows = File.ReadAllLines(db.filePath + "\\SupplierDetails.Ebase");

            for (int i = 0; i < EbRows.Length; i++)
            {
                string[] EbCol = EbRows[i].Split(';');

                for (int j = 0; j < EbCol.Length; j++)
                {
                    string supplierid = SupID_txtbx.Text;

                    if (supplierid.Equals(EbCol[0]))
                    {
                        //FirstName_txtbx  LastName_txtbx   Address_txtbx Phone_txtbx  Country_txtbx  

                        FirstName_txtbx.Text = EbCol[1];
                        LastName_txtbx.Text = EbCol[2];
                        Address_txtbx.Text = EbCol[3];
                        Phone_txtbx.Text = EbCol[4];
                        Country_txtbx.Text = EbCol[5];
                    }
                }
            }
                Result_grpbx.Visible = true;
                ClearClose_grpbx.Visible = true;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            FirstName_txtbx.Text = "";
            LastName_txtbx.Text = "";
            Address_txtbx.Text = "";
            Phone_txtbx.Text = "";
            Country_txtbx.Text = "";
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
