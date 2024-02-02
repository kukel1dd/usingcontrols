namespace Lab3Controls
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.RadBtnPC = new System.Windows.Forms.RadioButton();
            this.RadBtnMac = new System.Windows.Forms.RadioButton();
            this.RadBtnUnix = new System.Windows.Forms.RadioButton();
            this.CB2yr = new System.Windows.Forms.CheckBox();
            this.CB4yr = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblassociate = new System.Windows.Forms.Label();
            this.lblBachelor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxName, " Enter your name");
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(13, 50);
            this.TextBoxPhone.Mask = "(999) 000-0000";
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPhone.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TextBoxPhone, "Phone Number");
            // 
            // RadBtnPC
            // 
            this.RadBtnPC.AutoSize = true;
            this.RadBtnPC.Location = new System.Drawing.Point(6, 19);
            this.RadBtnPC.Name = "RadBtnPC";
            this.RadBtnPC.Size = new System.Drawing.Size(39, 17);
            this.RadBtnPC.TabIndex = 0;
            this.RadBtnPC.TabStop = true;
            this.RadBtnPC.Text = "PC";
            this.RadBtnPC.UseVisualStyleBackColor = true;
            // 
            // RadBtnMac
            // 
            this.RadBtnMac.AutoSize = true;
            this.RadBtnMac.Location = new System.Drawing.Point(6, 42);
            this.RadBtnMac.Name = "RadBtnMac";
            this.RadBtnMac.Size = new System.Drawing.Size(48, 17);
            this.RadBtnMac.TabIndex = 1;
            this.RadBtnMac.TabStop = true;
            this.RadBtnMac.Text = "MAC";
            this.RadBtnMac.UseVisualStyleBackColor = true;
            // 
            // RadBtnUnix
            // 
            this.RadBtnUnix.AutoSize = true;
            this.RadBtnUnix.Location = new System.Drawing.Point(6, 65);
            this.RadBtnUnix.Name = "RadBtnUnix";
            this.RadBtnUnix.Size = new System.Drawing.Size(51, 17);
            this.RadBtnUnix.TabIndex = 2;
            this.RadBtnUnix.TabStop = true;
            this.RadBtnUnix.Text = "UNIX";
            this.RadBtnUnix.UseVisualStyleBackColor = true;
            this.RadBtnUnix.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // CB2yr
            // 
            this.CB2yr.AutoSize = true;
            this.CB2yr.Location = new System.Drawing.Point(13, 190);
            this.CB2yr.Name = "CB2yr";
            this.CB2yr.Size = new System.Drawing.Size(79, 17);
            this.CB2yr.TabIndex = 3;
            this.CB2yr.Text = "2-yr degree";
            this.toolTip1.SetToolTip(this.CB2yr, " 2 year degree");
            this.CB2yr.UseVisualStyleBackColor = true;
            // 
            // CB4yr
            // 
            this.CB4yr.AutoSize = true;
            this.CB4yr.Location = new System.Drawing.Point(13, 213);
            this.CB4yr.Name = "CB4yr";
            this.CB4yr.Size = new System.Drawing.Size(79, 17);
            this.CB4yr.TabIndex = 4;
            this.CB4yr.Text = "4-yr degree";
            this.toolTip1.SetToolTip(this.CB4yr, "4 year degree");
            this.CB4yr.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 250);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.monthCalendar1, "Select a date");
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(319, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(319, 57);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 13);
            this.lblPhone.TabIndex = 12;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(319, 112);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(0, 13);
            this.lblOS.TabIndex = 11;
            // 
            // lblassociate
            // 
            this.lblassociate.AutoSize = true;
            this.lblassociate.Location = new System.Drawing.Point(319, 194);
            this.lblassociate.Name = "lblassociate";
            this.lblassociate.Size = new System.Drawing.Size(0, 13);
            this.lblassociate.TabIndex = 10;
            // 
            // lblBachelor
            // 
            this.lblBachelor.AutoSize = true;
            this.lblBachelor.Location = new System.Drawing.Point(319, 217);
            this.lblBachelor.Name = "lblBachelor";
            this.lblBachelor.Size = new System.Drawing.Size(0, 13);
            this.lblBachelor.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(319, 315);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 8;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(208, 479);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.BtnSubmit, "Submit your form");
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadBtnPC);
            this.groupBox1.Controls.Add(this.RadBtnMac);
            this.groupBox1.Controls.Add(this.RadBtnUnix);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.toolTip1.SetToolTip(this.groupBox1, "Choose an OS");
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(414, 479);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "Form 2";
            this.toolTip1.SetToolTip(this.btnForm2, "Continue to form 2");
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 552);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBachelor);
            this.Controls.Add(this.lblassociate);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CB4yr);
            this.Controls.Add(this.CB2yr);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox TextBoxPhone;
        private System.Windows.Forms.RadioButton RadBtnPC;
        private System.Windows.Forms.RadioButton RadBtnMac;
        private System.Windows.Forms.RadioButton RadBtnUnix;
        private System.Windows.Forms.CheckBox CB2yr;
        private System.Windows.Forms.CheckBox CB4yr;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblassociate;
        private System.Windows.Forms.Label lblBachelor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnForm2;
    }
}

