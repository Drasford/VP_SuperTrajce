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
    public partial class Form2 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jump = false;
        bool hasKey = false;

        int jumpSpeed = 10;
        int force = 8;
       public int score2 { get; set; }

        int playSpeed = 8;
        int backLeft = 8;

        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
           // gameTimer.Start();
            this.DoubleBuffered = true;
          //  int vkupenscore = form1.score1;
          //  toolStripStatusLabel1.Text = string.Format("Coins: {0}", vkupenscore);
            toolStripStatusLabel2.Text = string.Format("Keys: 0");
         

        }
        public int getScore2()
        {
            return score2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
            if(pictureBox1.Location.X + pictureBox1.Width > this.Width)
            {
                timer1.Stop();
                timer2.Start();
            }
            if (pictureBox1.Location.Y + pictureBox1.Height > this.Height)
            {
                timer1.Stop();
                timer3.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 5);
            if (pictureBox1.Location.Y + pictureBox1.Height > this.Height)
            {
                timer2.Stop();
                timer4.Start();
            }
            if (pictureBox1.Location.X < 0)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
            if (pictureBox1.Location.X + pictureBox1.Width > this.Width)
            {
                timer3.Stop();
                timer4.Start();
            }
            if (pictureBox1.Location.Y < 0)
            {
                timer3.Stop();
                timer1.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
            if (pictureBox1.Location.X < 0)
            {
                timer4.Stop();
                timer3.Start();
            }
            if (pictureBox1.Location.Y < 0)
            {
                timer4.Stop();
                timer2.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y + 5);
            if (pictureBox2.Location.X + pictureBox2.Width > this.Width)
            {
                timer5.Stop();
                timer6.Start();
            }
            if (pictureBox2.Location.Y + pictureBox2.Height > this.Height)
            {
                timer5.Stop();
                timer7.Start();
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y + 5);
            if (pictureBox2.Location.Y + pictureBox2.Height > this.Height)
            {
                timer6.Stop();
                timer8.Start();
            }
            if (pictureBox2.Location.X < 0)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y - 5);
            if (pictureBox2.Location.X + pictureBox2.Width > this.Width)
            {
                timer7.Stop();
                timer8.Start();
            }
            if (pictureBox2.Location.Y < 0)
            {
                timer7.Stop();
                timer5.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y - 5);
            if (pictureBox2.Location.X < 0)
            {
                timer8.Stop();
                timer7.Start();
            }
            if (pictureBox2.Location.Y < 0)
            {
                timer8.Stop();
                timer6.Start();
            }

        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = string.Format("Coins: {0}", score2);
            if (hasKey)
            {
                toolStripStatusLabel2.Text = string.Format("Key: 1");
            }
          

            Player.Top += jumpSpeed;
            Player.Refresh();
            if (jump && force < 0)
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
                    if (c is PictureBox && (String)c.Tag == "platform" || c is PictureBox && (String)c.Tag == "coin" || c is PictureBox && (String)c.Tag == "door" || c is PictureBox && (String)c.Tag == "key")
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

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (String)c.Tag == "platform")
                {
                    if (Player.Bounds.IntersectsWith(c.Bounds) && !jump)
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
                        score2++;

                    }

                }
                if (c is PictureBox && (String)c.Tag == "pecurka")
                {
                    if (Player.Bounds.IntersectsWith(c.Bounds))
                    {
                        this.Controls.Remove(c);
                        gameover.Show();
                        int vkupenscore = form1.score1;
                        DialogResult result = MessageBox.Show(String.Format("Your overall score is: {0}", vkupenscore), "GAME OVER", MessageBoxButtons.RetryCancel);
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
                if (Player.Bounds.IntersectsWith(Door.Bounds) && hasKey)
                {
                    Door.Image = Properties.Resources.door_open;
                    gameTimer.Stop();
                    Form3 nextForm = new Form3();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                if (Player.Bounds.IntersectsWith(Key.Bounds))
                {
                    hasKey = true;
                    this.Controls.Remove(Key);
                }

                if (Player.Top + Player.Height > this.ClientSize.Height + 60)
                {
                   
                    gameTimer.Stop();
                    gameover.Show();
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    timer6.Stop();
                    timer7.Stop();
                    timer8.Stop();
                    int vkupenscore = form1.score1 + score2;
                    DialogResult result = MessageBox.Show(String.Format("Your overall score is: {0}", vkupenscore), "GAME OVER", MessageBoxButtons.RetryCancel);
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
        private void Form2_KeyDown(object sender, KeyEventArgs e)
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
                jump = true;
            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
           

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gameover.Hide();
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyUp_1(object sender, KeyEventArgs e)
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

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            timer1.Enabled = true;
            timer5.Enabled = true;
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
    }


