using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_Dvizenje_1
{
    public partial class Form1 : Form
    {

        bool goleft = false;
        bool goright = false;
        bool jump = false;
        bool hasKey = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        int playSpeed = 8;
        int backLeft = 8;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Start();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.Top += jumpSpeed;
            Player.Refresh();
            if(jump && force < 0)
            {
                jump = false;
            }
            if (jump)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if(goleft && Player.Left > 100)
            {
                Player.Left -= playSpeed;
            }

            if(goright && Player.Left + (Player.Width + 500) < this.ClientSize.Width)
            {
                Player.Left += playSpeed;
            }

            if(goright && Background.Left > -1350)
            {
                Background.Left -= backLeft;

                foreach(Control c in this.Controls)
                {
                    if(c is PictureBox && c.Tag == "platform" || c is PictureBox && c.Tag == "coin" || c is PictureBox && c.Tag =="door" || c is PictureBox && c.Tag == "key")
                    {
                        c.Left -= backLeft;
                    }
                }
            }

            if (goleft && Background.Left < 2)
            {
                Background.Left += backLeft;

                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "platform" || c is PictureBox && c.Tag == "coin" || c is PictureBox && c.Tag == "door" || c is PictureBox && c.Tag == "key")
                    {
                        c.Left += backLeft;
                    }
                }
            }

            foreach(Control c in this.Controls)
            {
                if( c is PictureBox && c.Tag == "platform")
                {
                    if(Player.Bounds.IntersectsWith(c.Bounds) && !jump)
                    {
                        force = 8;
                        Player.Top = c.Top - Player.Height;
                        jumpSpeed = 0;

                    }
                    
                }
                if (c is PictureBox && c.Tag == "coin")
                {
                    if (Player.Bounds.IntersectsWith(c.Bounds))
                    {
                        this.Controls.Remove(c);
                        score++;

                    }

                }
                if(Player.Bounds.IntersectsWith(Door.Bounds) && hasKey)
                {
                    Door.Image = Properties.Resources.door_open;
                    gameTimer.Stop();
                    MessageBox.Show("MOCAJ GI MAJSTOREEEEE");
                }
                if (Player.Bounds.IntersectsWith(Key.Bounds))
                {
                    hasKey = true;
                    this.Controls.Remove(Key);
                }

                if(Player.Top + Player.Height  > this.ClientSize.Height + 60)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Umre majstore, toa e...");
                    
                }

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if(e.KeyCode == Keys.Up && !jump)
            {
                jump = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = false;

            }
            if(e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jump)
            {
                jump = false;
            }

        }
    }
}
