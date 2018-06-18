namespace VP_Proekt_Dvizenje_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.victory = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.PictureBox();
            this.Dragon = new System.Windows.Forms.PictureBox();
            this.Girl = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Key = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 2);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 35);
            this.progressBar1.TabIndex = 29;
            // 
            // victory
            // 
            this.victory.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.victory;
            this.victory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.victory.Location = new System.Drawing.Point(0, 46);
            this.victory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(1046, 709);
            this.victory.TabIndex = 31;
            this.victory.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.gameoverr;
            this.gameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameover.Location = new System.Drawing.Point(0, 46);
            this.gameover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(1074, 752);
            this.gameover.TabIndex = 30;
            this.gameover.TabStop = false;
            // 
            // Dragon
            // 
            this.Dragon.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.dragon;
            this.Dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dragon.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.dragon;
            this.Dragon.Location = new System.Drawing.Point(1017, 118);
            this.Dragon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dragon.Name = "Dragon";
            this.Dragon.Size = new System.Drawing.Size(230, 252);
            this.Dragon.TabIndex = 28;
            this.Dragon.TabStop = false;
            this.Dragon.Tag = "dragon";
            this.Dragon.Click += new System.EventHandler(this.Dragon_Click);
            // 
            // Girl
            // 
            this.Girl.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.girlc;
            this.Girl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Girl.Location = new System.Drawing.Point(824, 118);
            this.Girl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Girl.Name = "Girl";
            this.Girl.Size = new System.Drawing.Size(92, 109);
            this.Girl.TabIndex = 27;
            this.Girl.TabStop = false;
            this.Girl.Tag = "girl";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox3.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox3.Location = new System.Drawing.Point(735, 222);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 78);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.pictureBox2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.pictureBox2.Location = new System.Drawing.Point(1707, 526);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox1.Location = new System.Drawing.Point(1605, 617);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 78);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox9.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox9.Location = new System.Drawing.Point(384, 349);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(194, 78);
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox8.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox8.Location = new System.Drawing.Point(1342, 292);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(194, 78);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox7.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox7.Location = new System.Drawing.Point(824, 445);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(194, 78);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox6.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox6.Location = new System.Drawing.Point(1104, 617);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(194, 78);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // Key
            // 
            this.Key.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Key.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.key;
            this.Key.Location = new System.Drawing.Point(114, 182);
            this.Key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(90, 47);
            this.Key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Key.TabIndex = 19;
            this.Key.TabStop = false;
            this.Key.Tag = "key";
            // 
            // Coin2
            // 
            this.Coin2.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Coin2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.Coin2.Location = new System.Drawing.Point(1104, 423);
            this.Coin2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(76, 77);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 18;
            this.Coin2.TabStop = false;
            this.Coin2.Tag = "coin";
            // 
            // Coin1
            // 
            this.Coin1.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Coin1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.Coin1.Location = new System.Drawing.Point(369, 249);
            this.Coin1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(76, 77);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 15;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "coin";
            // 
            // Door
            // 
            this.Door.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.door_closed;
            this.Door.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.door_closed;
            this.Door.Location = new System.Drawing.Point(1446, 162);
            this.Door.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(60, 90);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Door.TabIndex = 14;
            this.Door.TabStop = false;
            this.Door.Tag = "door";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick2;
            this.pictureBox4.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick3;
            this.pictureBox4.Location = new System.Drawing.Point(114, 263);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(194, 78);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // Platform
            // 
            this.Platform.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick;
            this.Platform.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.pinkbrick1;
            this.Platform.Location = new System.Drawing.Point(-3, 618);
            this.Platform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(832, 77);
            this.Platform.TabIndex = 10;
            this.Platform.TabStop = false;
            this.Platform.Tag = "platform";
            // 
            // Player
            // 
            this.Player.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.player1;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(114, 526);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 9;
            this.Player.TabStop = false;
            // 
            // Background
            // 
            this.Background.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.hearts;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.hearts;
            this.Background.Location = new System.Drawing.Point(-92, 46);
            this.Background.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(3000, 732);
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem,
            this.sTARTToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1042, 35);
            this.menuStrip2.TabIndex = 36;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(824, 2);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar2.Maximum = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(150, 35);
            this.progressBar2.TabIndex = 37;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1042, 30);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Dragon);
            this.Controls.Add(this.Girl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Background);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.victory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Key;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Girl;
        private System.Windows.Forms.PictureBox Dragon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox gameover;
        private System.Windows.Forms.PictureBox victory;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
    }
}