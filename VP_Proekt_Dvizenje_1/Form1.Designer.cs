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
            this.Background = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
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
            this.Key.Location = new System.Drawing.Point(993, 168);
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
            this.Coin2.Location = new System.Drawing.Point(744, 250);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(51, 50);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 10;
            this.Coin2.TabStop = false;
            this.Coin2.Tag = "coin";
            // 
            // Coin1
            // 
            this.Coin1.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Coin1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.coin;
            this.Coin1.Location = new System.Drawing.Point(257, 155);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(51, 50);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 9;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "coin";
            // 
            // Player
            // 
            this.Player.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(84, 377);
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
            this.Door.Location = new System.Drawing.Point(32, 23);
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
            this.pictureBox5.Location = new System.Drawing.Point(222, 211);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(129, 51);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox4.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox4.Location = new System.Drawing.Point(32, 112);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 51);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox3.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox3.Location = new System.Drawing.Point(426, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 51);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(975, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 51);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(711, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // Platform
            // 
            this.Platform.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.Platform.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.Platform.Location = new System.Drawing.Point(0, 428);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(555, 50);
            this.Platform.TabIndex = 1;
            this.Platform.TabStop = false;
            this.Platform.Tag = "platform";
            // 
            // Background
            // 
            this.Background.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.background;
            this.Background.Location = new System.Drawing.Point(0, -2);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(2000, 480);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 474);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Key;
    }
}

