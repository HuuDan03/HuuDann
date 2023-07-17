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
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }
        void Form1_ResizeEnd(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = Width.ToString() + "-" + height.ToString();

        }


        private void Cau1_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = Width.ToString() + "-" + height.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
