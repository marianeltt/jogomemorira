using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_04
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("../../img/img1.jpg");
            c1 = "../../img/img1.jpg";
            if (c1 == c4)
            {
                MessageBox.Show("acertou");
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
            }
            else
            {
                // Restaura a imagem inicial após 2 segundos
                Timer timer = new Timer();
                timer.Interval = 2000; // 2 segundos
                timer.Tick += (s, ev) =>
                {
                    pictureBox1.Load("../../img/fimg.png");
                    c1 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Load("../../img/img2.jpg");
            c2 = "../../img/img2.jpg";
            if (c2 == c3)
            {
                MessageBox.Show("acertou");
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000; 
                timer.Tick += (s, ev) =>
                {
                    pictureBox2.Load("../../img/fimg.png");
                    c2 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Load("../../img/img2.jpg");
            c3 = "../../img/img2.jpg";
            if (c2 == c3)
            {
                MessageBox.Show("acertou");
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000; 
                timer.Tick += (s, ev) =>
                {
                    pictureBox3.Load("../../img/fimg.png");
                    c3 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Load("../../img/img1.jpg");
            c4 = "../../img/img1.jpg";
            if(c1 == c4)
            {
                MessageBox.Show("acertou");
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000; 
                timer.Tick += (s, ev) =>
                {
                    pictureBox4.Load("../../img/fimg.png");
                    c4 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Load("../../img/img3.png");
            c5 = "../../img/img3.jpg";
            if (c5 == c7)
            {
                MessageBox.Show("acertou");
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    pictureBox5.Load("../../img/fimg.png");
                    c5 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }
         
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Load("../../img/img4.jpg");
            c6 = "../../img/img4.jpg";
            if (c6 == c9)
            {
                MessageBox.Show("acertou");
                pictureBox6.Visible = false;
                pictureBox9.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    pictureBox6.Load("../../img/fimg.png");
                    c6 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Load("../../img/img3.png");
            c7 = "../../img/img3.jpg";
            if (c5 == c7)
            {
                MessageBox.Show("acertou");
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    pictureBox7.Load("../../img/fimg.png");
                    c7 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Load("../../img/img5.jpg");
            c8 = "../../img/img5.jpg";
            if (c8 == c10)
            {
                MessageBox.Show("acertou");
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    pictureBox8.Load("../../img/fimg.png");
                    c8 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Load("../../img/img4.jpg");
            c9 = "../../img/img4.jpg";
            if (c6 == c9)
            {
                MessageBox.Show("acertou");
                pictureBox6.Visible = false;
                pictureBox9.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    pictureBox9.Load("../../img/fimg.png");
                    c9 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Load("../../img/img5.jpg");
            c10 = "../../img/img5.jpg";
            if (c8 == c10)
            {
                MessageBox.Show("acertou");
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    pictureBox10.Load("../../img/fimg.png");
                    c10 = "../../img/fimg.png";
                    timer.Stop();
                };
                timer.Start();
            }
        }
    }
}
