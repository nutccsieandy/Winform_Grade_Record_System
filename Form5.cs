using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Information_System
{
    public partial class Form5 : Form
    {
       

        public Form5()
        {
            InitializeComponent();
        }
               
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Visible = false;
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Visible = false;
            f.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
