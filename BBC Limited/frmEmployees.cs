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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void ClearAfterSave()
        {
            EmployeeID_txtbx.Text = "";
            FirstName_txtbx.Text = "";
            LastName_txtbx.Text = "";
            City_cmbbx.Text = "";
            PhoneNumber_txtbx.Text = "";
        }

        private void dbaseEmployeeSave(string empid, string firnme, string lstnme, string city, string phnNum)
        {
            //EmployeeID_txtbx   FirstName_txtbx   LastName_txtbx   City_cmbbx    PhoneNumber_txtbx

            Dbase db = new Dbase();
            File.AppendAllText(db.filePath + "\\Employees.Ebase", "\n" + empid + ";" + firnme + ";" + lstnme + ";" + city + ";" + phnNum + ";" );

            ClearAfterSave();

            MessageBox.Show("All Employee Details Have been Saved");


        }
        private void validationSave()
        {
            //EmployeeID_txtbx   FirstName_txtbx   LastName_txtbx   City_cmbbx    PhoneNumber_txtbx

            if (EmployeeID_txtbx.Text != "")
            {
                string txt = EmployeeID_txtbx.Text;
                int minValue;
                    if (int.TryParse(txt, out minValue))
                    {

                        if (FirstName_txtbx.Text != "")
                        {
                            if (LastName_txtbx.Text != "")
                            {
                                if (City_cmbbx.Text != "")
                                {

                                    if (PhoneNumber_txtbx.Text != "")
                                    {
                                        string txtp = PhoneNumber_txtbx.Text;
                                        long minValuep;

                                        if (long.TryParse(txtp, out minValuep))
                                        {
                                            string txtpp = PhoneNumber_txtbx.Text;

                                            if (!(txtpp.Length != 11)) 
                                            {


                                                dbaseEmployeeSave(EmployeeID_txtbx.Text, FirstName_txtbx.Text, LastName_txtbx.Text,
                                                    City_cmbbx.Text, PhoneNumber_txtbx.Text);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Phone Number can only be 11 Digits");
                                                PhoneNumber_txtbx.Focus();
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Phone Number must be a Number ");
                                            PhoneNumber_txtbx.Focus();
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("Phone Number is not filled ");
                                        PhoneNumber_txtbx.Focus();
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("City is not filled ");
                                    City_cmbbx.Focus();
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
                            EmployeeID_txtbx.Focus();
                        }
            
                    }
                    else
                    {
                        MessageBox.Show("Employee ID must be a Number ");
                        EmployeeID_txtbx.Focus();
                    }

            }
            else
            {
                MessageBox.Show("Employee ID is not filled ");
                EmployeeID_txtbx.Focus();
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            validationSave();
        }
    }
}
