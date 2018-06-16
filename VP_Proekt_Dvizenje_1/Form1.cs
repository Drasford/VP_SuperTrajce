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


        Form2 level2 = new Form2();

        bool goleft = false;
        bool goright = false;
        bool jump = false;
        bool hasKey = false;
        bool state = true;

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

            Player.Refresh();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state)
            {


                toolStripStatusLabel1.Text = string.Format("Coins: {0}", score);
                if (hasKey == false)
                {
                    toolStripStatusLabel2.Text = string.Format("Key: 0");
                }
                else
                {
                    toolStripStatusLabel2.Text = string.Format("Key: 1");
                }

                Player.Top += jumpSpeed;
                if (jump && force < 0)
                {
                    jump = false;
                }
                if (jump)
                {
                    jumpSpeed = -10;
                    force -= 1;
                }
                else
                {
                    jumpSpeed = 10;
                }
                if (goleft && Player.Left > 100)
                {
                    Player.Left -= playSpeed;
                }

                if (goright && Player.Left + (Player.Width + 500) < this.ClientSize.Width)
                {
                    Player.Left += playSpeed;
                }

                if (goright && Background.Left > -1350)
                {
                    Background.Left -= backLeft;

                    foreach (Control c in this.Controls)
                    {
                        if (c is PictureBox && c.Tag == "platform" || c is PictureBox && c.Tag == "coin" || c is PictureBox && c.Tag == "door" || c is PictureBox && c.Tag == "key")
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

                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "platform")
                    {
                        if (Player.Bounds.IntersectsWith(c.Bounds) && !jump)
                        {
                            force = 7;
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
                    if (Player.Bounds.IntersectsWith(Door.Bounds) && hasKey)
                    {
                        Door.Image = Properties.Resources.door_open;
                        gameTimer.Stop();
                        DialogResult d = MessageBox.Show("You WON, Try again anyway ?", "Win", MessageBoxButtons.YesNo);
                        
                        if (d == DialogResult.Yes)
                        {

                            level2.Visible = true;
                            this.Visible = false;
                            
                           
                            
                        }
                        if (d == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    if (Player.Bounds.IntersectsWith(Key.Bounds))
                    {
                        hasKey = true;
                        this.Controls.Remove(Key);
                    }

                    if (Player.Top + Player.Height > this.ClientSize.Height + 60)
                    {
                        gameTimer.Stop();
                        DialogResult d = MessageBox.Show("You died, Try again ?", "Loss", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            // newgame();

                        }
                        if (d == DialogResult.No)
                        {
                            this.Close();
                        }

                    }

                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Up && !jump)
            {
                Player.Top += jumpSpeed;
                jump = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jump)
            {
                jump = false;
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    
    }
}
