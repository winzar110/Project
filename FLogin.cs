using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industry
{
    public partial class FLogin : Form
    {
        StartForm sf = new StartForm();
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            StartForm sf = new StartForm();
            sf.Show();
            this.Hide();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            SingUp su = new SingUp();
            su.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            sf.Show();
            this.Hide();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            StartForm a = new StartForm();
            a.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TruckingIndustryEntities8 obj = new TruckingIndustryEntities8();
           
               string a = obj.SELECT_LP(textBox1.Text, textBox2.Text).FirstOrDefault().ToString();
            if(a == textBox1.Text)
            {
                sf.label1.Text = textBox1.Text;
                this.Hide();
                sf.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
