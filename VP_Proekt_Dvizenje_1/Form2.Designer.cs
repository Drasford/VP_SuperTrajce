﻿namespace VP_Proekt_Dvizenje_1
{
    partial class Form2
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
            this.timerlevel2 = new System.Windows.Forms.Timer(this.components);
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.background_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timerlevel2
            // 
            this.timerlevel2.Enabled = true;
            this.timerlevel2.Tick += new System.EventHandler(this.timerlevel2_Tick);
            // 
            // Enemy
            // 
            this.Enemy.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources._1;
            this.Enemy.Location = new System.Drawing.Point(218, 385);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(37, 51);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy.TabIndex = 4;
            this.Enemy.TabStop = false;
            this.Enemy.Tag = "enemy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(330, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 57);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(67, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // background_2
            // 
            this.background_2.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.lvl2;
            this.background_2.Location = new System.Drawing.Point(-3, -1);
            this.background_2.Name = "background_2";
            this.background_2.Size = new System.Drawing.Size(2000, 779);
            this.background_2.TabIndex = 0;
            this.background_2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox3.Location = new System.Drawing.Point(36, 442);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 57);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VP_Proekt_Dvizenje_1.Properties.Resources.platform;
            this.pictureBox5.Location = new System.Drawing.Point(158, 442);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 57);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 629);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.background_2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerlevel2;
        private System.Windows.Forms.PictureBox background_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}