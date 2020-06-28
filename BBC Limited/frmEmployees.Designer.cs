namespace BBC_Limited
{
    partial class frmEmployees
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
            this.City_cmbbx = new System.Windows.Forms.ComboBox();
            this.PhoneNumber_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeID_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.City_cmbbx);
            this.groupBox1.Controls.Add(this.PhoneNumber_txtbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LastName_txtbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FirstName_txtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmployeeID_txtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Employee details";
            // 
            // City_cmbbx
            // 
            this.City_cmbbx.FormattingEnabled = true;
            this.City_cmbbx.Items.AddRange(new object[] {
            "Lagos",
            "Ibadan",
            "Oshogbo",
            "Akure",
            "Abeokuta"});
            this.City_cmbbx.Location = new System.Drawing.Point(163, 203);
            this.City_cmbbx.Name = "City_cmbbx";
            this.City_cmbbx.Size = new System.Drawing.Size(146, 28);
            this.City_cmbbx.TabIndex = 10;
            // 
            // PhoneNumber_txtbx
            // 
            this.PhoneNumber_txtbx.Location = new System.Drawing.Point(163, 260);
            this.PhoneNumber_txtbx.Name = "PhoneNumber_txtbx";
            this.PhoneNumber_txtbx.Size = new System.Drawing.Size(146, 26);
            this.PhoneNumber_txtbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // LastName_txtbx
            // 
            this.LastName_txtbx.Location = new System.Drawing.Point(163, 147);
            this.LastName_txtbx.Name = "LastName_txtbx";
            this.LastName_txtbx.Size = new System.Drawing.Size(146, 26);
            this.LastName_txtbx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // FirstName_txtbx
            // 
            this.FirstName_txtbx.Location = new System.Drawing.Point(163, 90);
            this.FirstName_txtbx.Name = "FirstName_txtbx";
            this.FirstName_txtbx.Size = new System.Drawing.Size(146, 26);
            this.FirstName_txtbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // EmployeeID_txtbx
            // 
            this.EmployeeID_txtbx.Location = new System.Drawing.Point(163, 42);
            this.EmployeeID_txtbx.Name = "EmployeeID_txtbx";
            this.EmployeeID_txtbx.Size = new System.Drawing.Size(146, 26);
            this.EmployeeID_txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.closeBtn);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Location = new System.Drawing.Point(42, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(205, 31);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(104, 28);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(80, 31);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 28);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 502);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBC Limited - Employee Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PhoneNumber_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmployeeID_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox City_cmbbx;
    }
}