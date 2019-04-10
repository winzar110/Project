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
    public partial class FilialsF : Form
    {
        public FilialsF()
        {
            InitializeComponent();
        }

        private void FilialsF_Load(object sender, EventArgs e)
        {
            TruckingIndustryEntities8 obj = new TruckingIndustryEntities8();
            //dataGridView1.DataSource = obj.(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.label1.Text = label2.Text;
            start.Activate();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
