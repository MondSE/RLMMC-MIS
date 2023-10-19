using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            guna2CirclePictureBox1.Parent = pictureBox1;
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2Button1.Parent = pictureBox1;
            guna2Button1.BackColor = Color.Transparent;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            label1.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;
            guna2CirclePictureBox2.Parent = pictureBox3;
            guna2CirclePictureBox2.BackColor = Color.Transparent;
            label2.Parent = pictureBox3;
            label2.BackColor = Color.Transparent;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            string user = "Root";
            string pass = "Admin";

            if ((username==user)&&(password==pass))
            {
                Loading _load = new Loading();
                _load.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
