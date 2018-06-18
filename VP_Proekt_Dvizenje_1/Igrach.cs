using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt_Dvizenje_1
{
   public class Igrach
    {
        public string Ime { get; set; }
        public int Poeni { get; set; }
        public override string ToString()
        {
            return string.Format("{0}-{1}", Ime, Poeni);
        }


      
    }
    
}
