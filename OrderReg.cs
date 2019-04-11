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
    public partial class OrderReg : Form
    {
        public OrderReg()
        {
            InitializeComponent();
        }
        TruckingIndustryEntities8 obj = new TruckingIndustryEntities8();
        StartForm start = new StartForm();
        private void button1_Click(object sender, EventArgs e)
        {
            obj.pocylki_Ins(label8.Text,textBox1.Text,Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text),Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text));
            start.label1.Text = label8.Text;
            start.Show();
            this.Hide();

        }

        private void OrderReg_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.label1.Text = label8.Text;
            start.Show();
            this.Hide();
        }
    }
}
