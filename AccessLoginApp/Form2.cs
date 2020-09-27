using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AccessLoginApp
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_dd1_Click(object sender, EventArgs e)
        {
            DD1 d1 = new DD1();
            d1.Show();
        }

        private void btn_dd2_Click(object sender, EventArgs e)
        {
            DD2 d2 = new DD2();
            d2.Show();
        }

        private void btn_dd3_Click(object sender, EventArgs e)
        {
            DD3 d3 = new DD3();
            d3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_generation_Click(object sender, EventArgs e)
        {
            Generation_Division d4 = new Generation_Division();
            d4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_Division d5 = new Project_Division();
            d5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transmission_Division d6 = new Transmission_Division();
            d6.Show();
        }
    }
}
