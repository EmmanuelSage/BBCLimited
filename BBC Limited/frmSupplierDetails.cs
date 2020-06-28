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
    public partial class frmSupplierDetails : Form
    {
        public frmSupplierDetails()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void dbaseSupplierSave(string supId, string firNme, string lstnme, string addrss, string phnNum, string contry)
        {

            Dbase db = new Dbase();
            File.AppendAllText(db.filePath + "\\SupplierDetails.Ebase", "\n" + supId + ";" + firNme + ";" + lstnme + ";" + addrss + ";" + phnNum + ";" + contry + ";");

            ClearAfterSave();

            MessageBox.Show("All Supplier Details Have been Saved");


        }

        private void ClearAfterSave()
        {
            SupplierId_txtbx.Text  = "";
            FirstName_txtbx.Text = "";
            LastName_txtbx.Text = "";
            Address_txtbx.Text = "";
            PhoneNum_txtbx.Text = "";
            Country_combx.Text = "";
        }
        private void validationSave()
        {
            // SupplierId_txtbx FirstName_txtbx LastName_txtbx Address_txtbx PhoneNum_txtbx Country_combx

            if (SupplierId_txtbx.Text != "")
            {
                string txt = SupplierId_txtbx.Text;
                int minValue;

                if (int.TryParse(txt, out minValue))
                {
                    
                    if (FirstName_txtbx.Text != "")
                    {
                        if (LastName_txtbx.Text != "")
                        {
                            if (Address_txtbx.Text != "")
                            {
                                if (PhoneNum_txtbx.Text != "")
                                {
                                    string txtp = PhoneNum_txtbx.Text;
                                    long minValuep;

                                    if (long.TryParse(txtp, out minValuep))
                                    {
                                        string txtpp = PhoneNum_txtbx.Text;

                                        if (!(txtpp.Length != 11)) 
                                        {

                                            if (Country_combx.Text != "")
                                            {
                                                dbaseSupplierSave(SupplierId_txtbx.Text, FirstName_txtbx.Text, LastName_txtbx.Text, Address_txtbx.Text, PhoneNum_txtbx.Text, Country_combx.Text);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Country is not filled ");
                                                Country_combx.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Phone Number can only be 11 Digits");
                                            PhoneNum_txtbx.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Phone Number can only be Digits");
                                        PhoneNum_txtbx.Focus();
                                    }
                                
                                
                                }
                                else
                                {
                                    MessageBox.Show("Phone Number is not filled ");
                                    PhoneNum_txtbx.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Address is not filled ");
                                Address_txtbx.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Last Name is not filled ");
                            LastName_txtbx.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("First Name is not filled ");
                        FirstName_txtbx.Focus();
                    }
            }
                else
                    
                    MessageBox.Show("supplier Id can only be Digits");
                    SupplierId_txtbx.Focus();
                    } 
            else
            {
                MessageBox.Show("Supplier ID is not filled ");
                SupplierId_txtbx.Focus();
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            validationSave();
            
        }


    }
}
