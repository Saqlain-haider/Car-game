using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - 10;


            if (pictureBox1.Right > pictureBox2.Left) {

                MessageBox.Show("car crashed..");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left =  pictureBox1.Left+10;

            if (pictureBox1.Right > pictureBox2.Left)
            {

                MessageBox.Show("car crashed..");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
