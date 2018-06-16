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
       

        public int score1 { get; set; }

        int playSpeed = 8;
        int backLeft = 8;

        public Form1()
        {
            InitializeComponent();
           // gameTimer.Start();
            this.DoubleBuffered = true;
            toolStripStatusLabel1.Text = string.Format("Coins: {0}", score1);
            toolStripStatusLabel2.Text = string.Format("Key: 0");
        }
        public int getScore1()
        {
            return score1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = string.Format("Coins: {0}", score1);
            if (hasKey)
            {
                toolStripStatusLabel2.Text = string.Format("Key: 1");
            }
         

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

            if(goright && Background.Left > -1950)
            {
                Background.Left -= backLeft;

                foreach(Control c in this.Controls)
                {
                    if(c is PictureBox && (String)c.Tag == "platform" || c is PictureBox && (String)c.Tag == "coin" || c is PictureBox && (String)c.Tag =="door" || c is PictureBox && (String)c.Tag == "key")
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
                    if (c is PictureBox && (String)c.Tag == "platform" || c is PictureBox && (String)c.Tag == "coin" || c is PictureBox && (String)c.Tag == "door" || c is PictureBox && (String)c.Tag == "key")
                    {
                        c.Left += backLeft;
                    }
                }
            }
            foreach(Control c in this.Controls)
            {
                if(c is PictureBox && (String)c.Tag == "END")
                {
                    if(Player.Bounds.IntersectsWith(c.Bounds) && !jump)
                    {
                        force = 0;
                        Player.Left = c.Left - Player.Width;
                        jumpSpeed = 0;
                    }
                }
            }

            foreach(Control c in this.Controls)
            {
                if( c is PictureBox && (String)c.Tag == "platform")
                {
                    if(Player.Bounds.IntersectsWith(c.Bounds) && !jump)
                    {
                        force = 8;
                        Player.Top = c.Top - Player.Height;
                        jumpSpeed = 0;

                    }
                    
                }
               
                if (c is PictureBox && (String)c.Tag == "coin")
                {
                    if (Player.Bounds.IntersectsWith(c.Bounds))
                    {
                        this.Controls.Remove(c);
                        score1++;

                    }

                }
                if (Player.Bounds.IntersectsWith(Door.Bounds) && hasKey)
                {
                    Door.Image = Properties.Resources.door_open;
                    gameTimer.Stop();
                  
                        Form2 nextForm = new Form2();
                        this.Hide();
                        nextForm.ShowDialog();
                        this.Close();

                    
                  
                }
                if (Player.Bounds.IntersectsWith(Key.Bounds))
                {
                    hasKey = true;
                    this.Controls.Remove(Key);
                }

                if(Player.Top + Player.Height  > this.ClientSize.Height + 60)
                {
                    gameTimer.Stop();
                    gameover.Show();

                    DialogResult result = MessageBox.Show(String.Format("Your overall score is: {0}", score1), "GAME OVER", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                        if (result == DialogResult.Retry)
                    {
                        // newGame();
                    }


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
            if(e.KeyCode == Keys.S)
            {
                gameTimer.Start();
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

        private void Background_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameover.Hide();

        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
                form4.Show();
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
