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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        TruckingIndustryEntities8 obj = new TruckingIndustryEntities8();
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            StartForm sf = new StartForm();
            sf.Show();
            sf.label1.Text = lblUserName.Text;
            this.Hide();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            
            dgv.DataSource = obj.pocylki(lblUserName.Text);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
