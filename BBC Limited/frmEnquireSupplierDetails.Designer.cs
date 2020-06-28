namespace BBC_Limited
{
    partial class frmEnquireSupplierDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SupID_txtbx = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Result_grpbx = new System.Windows.Forms.GroupBox();
            this.ClearClose_grpbx = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstName_txtbx = new System.Windows.Forms.TextBox();
            this.Country_txtbx = new System.Windows.Forms.TextBox();
            this.LastName_txtbx = new System.Windows.Forms.TextBox();
            this.Phone_txtbx = new System.Windows.Forms.TextBox();
            this.Address_txtbx = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Result_grpbx.SuspendLayout();
            this.ClearClose_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_btn);
            this.groupBox1.Controls.Add(this.SupID_txtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(439, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquire Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Supplier ID";
            // 
            // SupID_txtbx
            // 
            this.SupID_txtbx.Location = new System.Drawing.Point(196, 38);
            this.SupID_txtbx.Name = "SupID_txtbx";
            this.SupID_txtbx.Size = new System.Drawing.Size(194, 26);
            this.SupID_txtbx.TabIndex = 2;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(277, 86);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(113, 35);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Result_grpbx
            // 
            this.Result_grpbx.Controls.Add(this.Phone_txtbx);
            this.Result_grpbx.Controls.Add(this.LastName_txtbx);
            this.Result_grpbx.Controls.Add(this.Country_txtbx);
            this.Result_grpbx.Controls.Add(this.Address_txtbx);
            this.Result_grpbx.Controls.Add(this.FirstName_txtbx);
            this.Result_grpbx.Controls.Add(this.label6);
            this.Result_grpbx.Controls.Add(this.label5);
            this.Result_grpbx.Controls.Add(this.label4);
            this.Result_grpbx.Controls.Add(this.label3);
            this.Result_grpbx.Controls.Add(this.label2);
            this.Result_grpbx.Location = new System.Drawing.Point(31, 172);
            this.Result_grpbx.Name = "Result_grpbx";
            this.Result_grpbx.Size = new System.Drawing.Size(439, 280);
            this.Result_grpbx.TabIndex = 1;
            this.Result_grpbx.TabStop = false;
            this.Result_grpbx.Text = "Result";
            // 
            // ClearClose_grpbx
            // 
            this.ClearClose_grpbx.Controls.Add(this.Close_btn);
            this.ClearClose_grpbx.Controls.Add(this.Clear_btn);
            this.ClearClose_grpbx.Location = new System.Drawing.Point(31, 458);
            this.ClearClose_grpbx.Name = "ClearClose_grpbx";
            this.ClearClose_grpbx.Size = new System.Drawing.Size(439, 60);
            this.ClearClose_grpbx.TabIndex = 0;
            this.ClearClose_grpbx.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FirstName_txtbx
            // 
            this.FirstName_txtbx.Location = new System.Drawing.Point(19, 60);
            this.FirstName_txtbx.Name = "FirstName_txtbx";
            this.FirstName_txtbx.ReadOnly = true;
            this.FirstName_txtbx.Size = new System.Drawing.Size(171, 26);
            this.FirstName_txtbx.TabIndex = 6;
            // 
            // Country_txtbx
            // 
            this.Country_txtbx.Location = new System.Drawing.Point(232, 60);
            this.Country_txtbx.Name = "Country_txtbx";
            this.Country_txtbx.ReadOnly = true;
            this.Country_txtbx.Size = new System.Drawing.Size(171, 26);
            this.Country_txtbx.TabIndex = 9;
            // 
            // LastName_txtbx
            // 
            this.LastName_txtbx.Location = new System.Drawing.Point(19, 134);
            this.LastName_txtbx.Name = "LastName_txtbx";
            this.LastName_txtbx.ReadOnly = true;
            this.LastName_txtbx.Size = new System.Drawing.Size(171, 26);
            this.LastName_txtbx.TabIndex = 10;
            // 
            // Phone_txtbx
            // 
            this.Phone_txtbx.Location = new System.Drawing.Point(19, 216);
            this.Phone_txtbx.Name = "Phone_txtbx";
            this.Phone_txtbx.ReadOnly = true;
            this.Phone_txtbx.Size = new System.Drawing.Size(171, 26);
            this.Phone_txtbx.TabIndex = 11;
            // 
            // Address_txtbx
            // 
            this.Address_txtbx.Location = new System.Drawing.Point(232, 134);
            this.Address_txtbx.Multiline = true;
            this.Address_txtbx.Name = "Address_txtbx";
            this.Address_txtbx.ReadOnly = true;
            this.Address_txtbx.Size = new System.Drawing.Size(171, 108);
            this.Address_txtbx.TabIndex = 7;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(186, 25);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(96, 29);
            this.Clear_btn.TabIndex = 0;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(307, 25);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(96, 29);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // frmEnquireSupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 538);
            this.ControlBox = false;
            this.Controls.Add(this.ClearClose_grpbx);
            this.Controls.Add(this.Result_grpbx);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEnquireSupplierDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBC Limited - Enquire Supplier Details";
            this.Load += new System.EventHandler(this.frmEnquireSupplierDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Result_grpbx.ResumeLayout(false);
            this.Result_grpbx.PerformLayout();
            this.ClearClose_grpbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox SupID_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Result_grpbx;
        private System.Windows.Forms.GroupBox ClearClose_grpbx;
        private System.Windows.Forms.TextBox FirstName_txtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phone_txtbx;
        private System.Windows.Forms.TextBox LastName_txtbx;
        private System.Windows.Forms.TextBox Country_txtbx;
        private System.Windows.Forms.TextBox Address_txtbx;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}