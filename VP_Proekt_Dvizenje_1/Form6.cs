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
    public partial class Form6 : Form
    {
        public List<Igrach> igrachi = new List<Igrach>();
        Igrach igrac = new Igrach();
        public Form6()
        {
            InitializeComponent();
            // igraci = new List<Igrach>;
           // Form5 form5= new Form5()
           // igrac.Ime= form5



        }

        private void Form6_Load(object sender, EventArgs e)
        {
            igrachi.Add(igrac);
        }

        private void HS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
