using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Signupform
{
    public partial class Admin_View : Form
    {
        public Admin_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Admin_View_Order();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new ViewCustomers();
            this.Hide();
            f2.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f3 = new ViewEmployees();
            this.Hide();
            f3.Show();
        }

        private void Admin_View_Load(object sender, EventArgs e)
        {

        }
    }
}
