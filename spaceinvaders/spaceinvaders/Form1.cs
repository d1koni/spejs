using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceinvaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int br = 0;
        PictureBox[] metak;
        Image metkovi = Image.FromFile(@"C:\Users\kurs\Documents\Visual Studio 2017\Projects\spaceinvaders\slike\metak.png");
        
        public int pspeed = 10;
        
        public void GameOver()
        {
            label1.Visible = true;
            pspeed = 0;
            gametimer.Stop();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
            avion.Visible = true;
            avion2.Visible = true;
            int metaksp = 20;
            metak = new PictureBox[5];
            
            
            

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timer1.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                timer2.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                timer3.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                timer4.Start();
            }
            if (e.KeyCode == Keys.W)
            {
                timer5.Start();
            }
            if (e.KeyCode == Keys.S)
            {
                timer6.Start();
            }
            if (e.KeyCode == Keys.D)
            {
                timer7.Start();
            }
            if (e.KeyCode == Keys.A)
            {
                timer8.Start();
            }
            

        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timer1.Stop();
            }
            if (e.KeyCode == Keys.Down)
            {
                timer2.Stop();
            }
            if (e.KeyCode == Keys.Right)
            {
                timer3.Stop();
            }
            if (e.KeyCode == Keys.Left)
            {
                timer4.Stop();
            }
            if (e.KeyCode == Keys.W)
            {
                timer5.Stop();
            }
            if (e.KeyCode == Keys.S)
            {
                timer6.Stop();
            }
            if (e.KeyCode == Keys.D)
            {
                timer7.Stop();
            }
            if (e.KeyCode == Keys.A)
            {
                timer8.Stop();
            }
            if (e.KeyCode == Keys.Space)
            {
                if(br < 5)
                {
                    metak[br] = new PictureBox();
                    metak[br].Size = new Size(8, 10);
                    metak[br].Image = metkovi;
                    metak[br].SizeMode = PictureBoxSizeMode.StretchImage;
                    metak[br].Location = new Point( avion2.Location.X + 39, avion2.Location.Y);
                    this.Controls.Add(metak[br]);
                    foreach(Control x in this.Controls)
                    {
                        if(x is PictureBox)
                        {
                            x.Tag = "bullet";
                        }
                    }
                    br++;
                }

            }
            if(e.KeyCode == Keys.Enter)
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(avion.Top < 625)
            {
                avion.Top += pspeed;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(avion.Left < 800)
            {
                avion.Left += pspeed;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (avion.Left > 13)
            {
                avion.Left -= pspeed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (avion.Top > 100)
            {
                avion.Top -= pspeed;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (avion2.Top > 100)
            {
                avion2.Top -= pspeed;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (avion2.Top < 625)
            {
                avion2.Top += pspeed;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (avion2.Left < 800)
            {
                avion2.Left += pspeed;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (avion2.Left > 13)
            {
                avion2.Left -= pspeed;
            }
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            if (avion.Bounds.IntersectsWith(avion2.Bounds))
            {
                GameOver();
            }
                
        }

        private void MetakTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
