namespace VP_Proekt_Dvizenje_1
{
    partial class Form1
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
            this.Key = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Background = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Key
            // 
            this.Key.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Key.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.key;
            this.Key.Location = new System.Drawing.Point(1440, 214);
            this.Key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(90, 47);
            this.Key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Key.TabIndex = 11;
            this.Key.TabStop = false;
            this.Key.Tag = "key";
            // 
            // Coin2
            // 
            this.Coin2.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Coin2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.Coin2.Location = new System.Drawing.Point(1090, 371);
            this.Coin2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(76, 77);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 10;
            this.Coin2.TabStop = false;
            this.Coin2.Tag = "coin";
            // 
            // Coin1
            // 
            this.Coin1.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Coin1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.Coin1.Location = new System.Drawing.Point(386, 238);
            this.Coin1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(76, 77);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 9;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "coin";
            // 
            // Player
            // 
            this.Player.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(126, 580);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(53, 54);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 8;
            this.Player.TabStop = false;
            // 
            // Door
            // 
            this.Door.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.door_closed;
            this.Door.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.door_closed;
            this.Door.Location = new System.Drawing.Point(48, 42);
            this.Door.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(60, 90);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Door.TabIndex = 7;
            this.Door.TabStop = false;
            this.Door.Tag = "door";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox5.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox5.Location = new System.Drawing.Point(333, 325);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(194, 78);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox4.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox4.Location = new System.Drawing.Point(48, 172);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(194, 78);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox3.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox3.Location = new System.Drawing.Point(639, 471);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 78);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(1407, 295);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 78);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 471);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 78);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // Platform
            // 
            this.Platform.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.Platform.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.Platform.Location = new System.Drawing.Point(0, 658);
            this.Platform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(832, 77);
            this.Platform.TabIndex = 1;
            this.Platform.TabStop = false;
            this.Platform.Tag = "platform";
            // 
            // gameover
            // 
            this.gameover.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.gameoverr;
            this.gameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameover.Location = new System.Drawing.Point(0, 42);
            this.gameover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(1074, 752);
            this.gameover.TabIndex = 32;
            this.gameover.TabStop = false;
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
            this.menuStrip2.Size = new System.Drawing.Size(927, 35);
            this.menuStrip2.TabIndex = 34;
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
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox6.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox6.Location = new System.Drawing.Point(1857, 658);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(788, 77);
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 741);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(927, 30);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Background
            // 
            this.Background.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Background.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Background.Location = new System.Drawing.Point(0, 42);
            this.Background.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(3750, 738);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.pictureBox7.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.pictureBox7.Location = new System.Drawing.Point(2235, 525);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(76, 77);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox8.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox8.Location = new System.Drawing.Point(1662, 485);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(194, 78);
            this.pictureBox8.TabIndex = 47;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox9.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox9.Location = new System.Drawing.Point(2654, 198);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(105, 534);
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "END";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 771);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox9);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Key;
        private System.Windows.Forms.PictureBox gameover;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
    }
}

