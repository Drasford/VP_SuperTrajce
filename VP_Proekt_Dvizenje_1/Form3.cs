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
    public partial class Form3 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jump = false;
        bool hasKey = false;
        bool hasthegirl = false;
        Form1 form1 = new Form1();
        Form2 form2 = new Form2();

        int jumpSpeed = 10;
        int force = 8;
        public int score { get; set; }

        int playSpeed = 8;
        int backLeft = 8;
        int max = 10;

        public Form3()
        {
            InitializeComponent();
           
            this.DoubleBuffered = true;
            progressBar2.Value = max;

            toolStripStatusLabel1.Text = string.Format("Coins: {0}", form1.score1 + form2.score2 + score);
            toolStripStatusLabel2.Text = string.Format("Keys: 0");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = string.Format("Coins: {0}", form1.score1 + form2.score2 + score);
            if (hasKey)
            {
                toolStripStatusLabel2.Text = string.Format("Keys: 1");
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
                    if (c is PictureBox && (String)c.Tag == "platform" || c is PictureBox && (String)c.Tag == "coin" || c is PictureBox && (String)c.Tag == "door" || c is PictureBox && (String)c.Tag == "key" || c is PictureBox && (String)c.Tag == "girl")
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
                    if (c is PictureBox && (String)c.Tag == "platform" || c is PictureBox && (String)c.Tag == "coin" || c is PictureBox && (String)c.Tag == "door" || c is PictureBox && (String)c.Tag == "key" || c is PictureBox && (String)c.Tag == "girl")
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
                        score++;

                    }

                }
                if (c is PictureBox && (String)c.Tag == "girl")
                {
                    if (Player.Bounds.IntersectsWith(c.Bounds))
                    {

                        hasthegirl = true;
                        this.Controls.Remove(c);
                        Player.Image = Properties.Resources.couple;

                    }

                }
                if (c is PictureBox && (String)c.Tag == "dragon")
                {
                    if (Player.Bounds.IntersectsWith(c.Bounds))
                    {
                        gameTimer.Stop();
                        gameover.Show();
                        int vkupenscore = form1.getScore1() + score + form2.getScore2();
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
                if (Player.Bounds.IntersectsWith(Door.Bounds) && hasKey && hasthegirl)
                {
                    Door.Image = Properties.Resources.door_open;
                    gameTimer.Stop();
                    victory.Show();
                    int vkupenscore = form1.getScore1() + score + form2.getScore2();
                    DialogResult result= MessageBox.Show(String.Format("Congratulations you won and you saved Trajanka!!! Your overall score is : {0}",vkupenscore));
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
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
                    gameover.Show();
                    int vkupenscore = form1.getScore1() + score + form2.getScore2();
              
                    DialogResult result = MessageBox.Show(String.Format("Your overall score is: {0}",vkupenscore),"GAME OVER",MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                        if(result==DialogResult.Retry)
                    {
                        newGame();
                    }

                }

            }

        }

        private void newGame()
        {
            
        }
        private void Form3_KeyDown_1(object sender, KeyEventArgs e)
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

        private void Form3_KeyUp_1(object sender, KeyEventArgs e)
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Dragon.Location = new Point(Dragon.Location.X + 5, Dragon.Location.Y + 5);
            if (Dragon.Location.X + Dragon.Width > this.Width)
            {
                timer1.Stop();
                timer2.Start();
            }
            if (Dragon.Location.Y + Dragon.Height > this.Height)
            {
                timer1.Stop();
                timer3.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Dragon.Location = new Point(Dragon.Location.X - 5, Dragon.Location.Y + 5);
            if (Dragon.Location.Y + Dragon.Height > this.Height)
            {
                timer2.Stop();
                timer4.Start();
            }
            if (Dragon.Location.X < 0)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Dragon.Location = new Point(Dragon.Location.X + 5, Dragon.Location.Y - 5);
            if (Dragon.Location.X + Dragon.Width > this.Width)
            {
                timer3.Stop();
                timer4.Start();
            }
            if (Dragon.Location.Y < 0)
            {
                timer3.Stop();
                timer1.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Dragon.Location = new Point(Dragon.Location.X - 5, Dragon.Location.Y - 5);
            if (Dragon.Location.X < 0)
            {
                timer4.Stop();
                timer3.Start();
            }
            if (Dragon.Location.Y < 0)
            {
                timer4.Stop();
                timer2.Start();
            }
        }

        private void Dragon_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0 && progressBar2.Enabled==true)
            {
                progressBar2.Value--;
            }
            if (progressBar2.Value == 0)
            {

                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && (String)c.Tag == "dragon")
                    {
                        this.Controls.Remove(c);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gameover.Hide();
            victory.Hide();
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            timer1.Enabled = true;
            progressBar2.Enabled = true;
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
