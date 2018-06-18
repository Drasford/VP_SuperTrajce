namespace VP_Proekt_Dvizenje_1
{
    partial class Form6
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
            this.HS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HS
            // 
            this.HS.Location = new System.Drawing.Point(58, 70);
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(447, 207);
            this.HS.TabIndex = 0;
            this.HS.Text = "";
            this.HS.TextChanged += new System.EventHandler(this.HS_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 324);
            this.Controls.Add(this.HS);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HS;
    }
}