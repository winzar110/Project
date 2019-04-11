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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            StartForm sf = new StartForm();
            sf.Show();
            this.Hide();
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            TruckingIndustryEntities8 obj = new TruckingIndustryEntities8();
            obj.klienty_Ins(tbFullName.Text,tbMail.Text,tbLogin.Text,textBox1.Text,tbAdres.Text,Convert.ToInt32(tbPhone.Text));
            StartForm obje = new StartForm();
            obje.Show();
            MessageBox.Show("Регистрация прошла успешно!");
            this.Hide();
        }
    }
}
