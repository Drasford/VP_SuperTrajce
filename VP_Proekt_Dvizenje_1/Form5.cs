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
      public List<Igrach> igrachi = new List<Igrach>();
      public Igrach igrac;

        public Form5()
        {
            InitializeComponent();
          
    }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pom = false;
            if(Ime.Text!="")
            {
                igrachi.Add(igrac);
            }
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
            else if(Vozrast.Value >= 18 && pom == false)
            {
                Form1 form1 = new Form1();
                form1.Show();
                
                this.Hide();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            igrachi = igrachi.OrderByDescending(x => x.Poeni).ToList();
            StringBuilder pecatenje = new StringBuilder();
            foreach (Igrach i in igrachi)
            {
                pecatenje.Append(i.ToString() + "\n");
            }
            string pom = pecatenje.ToString();
            MessageBox.Show(pom);
        }

        private void Ime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            igrac = new Igrach();
            igrac.Ime = Ime.Text;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
