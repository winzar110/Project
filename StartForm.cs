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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            FLogin fl = new FLogin();
            fl.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Calculator a = new Calculator();
            a.label4.Text = label1.Text;
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FilialsF f = new FilialsF();
            f.Show();
            f.label2.Text = label1.Text;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            OrderForm or = new OrderForm();
            if (label1.Text != "Гость")
            {
                or.lblUserName.Text = label1.Text;
                or.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Сначала зарегестрируйтесь!");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            OrderReg reg = new OrderReg();
            if (label1.Text != "Гость")
            {
                reg.label8.Text = label1.Text;
                reg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Сначала зарегестрируйтесь!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FLogin log = new FLogin();
            log.Show();
            this.Hide();
        }
    }
}
