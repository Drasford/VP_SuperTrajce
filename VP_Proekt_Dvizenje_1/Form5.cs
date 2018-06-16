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
    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pom = false;
            if (Ime.Text==null || Ime.Text=="")
            {
                DialogResult result = MessageBox.Show("You must enter a name!", "", MessageBoxButtons.OK);
                if (result == System.Windows.Forms.DialogResult.OK)
                {

                }
                pom = true;
            }
            if(Vozrast.Value < 18 )
            {
                DialogResult result = MessageBox.Show("You are underage you can't play this game!", "", MessageBoxButtons.OK);
                if (result == System.Windows.Forms.DialogResult.OK)
                {

                }
             
                
            }
            else if(Vozrast.Value > 18 && pom == false)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Form5 form5 = new Form5();
                form5.Hide();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
