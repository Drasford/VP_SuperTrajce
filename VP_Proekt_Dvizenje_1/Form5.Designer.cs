namespace VP_Proekt_Dvizenje_1
{
    partial class Form5
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
            this.Ime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vozrast = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Greska = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vozrast)).BeginInit();
            this.SuspendLayout();
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(132, 42);
            this.Ime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(148, 26);
            this.Ime.TabIndex = 1;
            this.Ime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Ime_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player Age:";
            // 
            // Vozrast
            // 
            this.Vozrast.Location = new System.Drawing.Point(132, 83);
            this.Vozrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Vozrast.Name = "Vozrast";
            this.Vozrast.Size = new System.Drawing.Size(150, 26);
            this.Vozrast.TabIndex = 4;
            this.Vozrast.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(824, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start the game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Greska
            // 
            this.Greska.AutoSize = true;
            this.Greska.Location = new System.Drawing.Point(291, 46);
            this.Greska.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Greska.Name = "Greska";
            this.Greska.Size = new System.Drawing.Size(0, 20);
            this.Greska.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(824, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "High Score";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Proekt_Dvizenje_1.Properties.Resources.super_trajkoo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 760);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Greska);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vozrast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ime);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vozrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Vozrast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Greska;
        private System.Windows.Forms.Button button2;
    }
}