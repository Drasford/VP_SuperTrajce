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
        public Form2()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Start();
            
        }

        private void timerlevel2_Tick(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is PictureBox && c.Tag == "enemy")
                {
                    Enemy.Left = -1;
                }
            }
        }
    }
}
