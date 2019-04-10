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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }
        TruckingIndustryEntities8 obj = new TruckingIndustryEntities8();
        private void button1_Click(object sender, EventArgs e)
        {
            var where = Convert.ToInt32(obj.TARIF_SELECT(textBox1.Text).FirstOrDefault());
            //(from a in obj.Tariff
            // where a.City == textBox1.Text
            //select new { a.Tariff1 }).FirstOrDefault();
            var ves = Convert.ToInt32(obj.Cat_Select(Convert.ToInt32(textBox2.Text)).FirstOrDefault());
            
            textBox3.Text = Convert.ToString(ves*where);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StartForm a = new StartForm();
            a.label1.Text = label4.Text;
            a.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
