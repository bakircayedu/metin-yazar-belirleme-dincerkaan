using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VeriYapilariProje
{
    public class Kelime
    {
        public int Frekans { get; set; }


        public string Kelimee;


        public Kelime(string Kelimee, int usage)
        {
            this.Kelimee = Kelimee;
            this.Frekans = usage;  
        }


    }
}
