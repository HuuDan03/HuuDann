using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcau1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Cau1 c1= new Cau1();
          
            c1.Show();
        }

        private void btcau2_Click(object sender, EventArgs e)
        {

            //this.Hide();
            Cau2 c2 = new Cau2();

            c2.Show();
        }

        private void btcau3_Click(object sender, EventArgs e)
        {

            //this.Hide();
            Cau3 c3 = new Cau3();

            c3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btcau4_Click(object sender, EventArgs e)
        {
            Cau4 c4= new Cau4();
            c4.Show();
        }

        private void btc5_Click(object sender, EventArgs e)
        {
            Cau5 c5= new Cau5();
                c5.Show();
        }
    }
}
