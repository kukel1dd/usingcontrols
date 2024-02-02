using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblName.Text = textBoxName.Text;
            lblPhone.Text = TextBoxPhone.Text;
            if (RadBtnPC.Checked)
            {
                lblOS.Text = RadBtnPC.Text;
            }
            if (RadBtnMac.Checked)
            {
                lblOS.Text = RadBtnMac.Text;
            }
            if (RadBtnUnix.Checked)
            {
                lblOS.Text = RadBtnUnix.Text;
            }
            if (CB2yr.Checked)
            {
                lblassociate.Text = CB2yr.Text;
            }
            else
                lblassociate.Text = "";

            if (CB4yr.Checked)
            {
                lblBachelor.Text = CB4yr.Text;
            }
            else
                lblBachelor.Text = "";
            lblDate.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
