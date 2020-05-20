using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo.Library
{
    public class Hitung
    {
        Data data = new Data();
        public void hitung(double BB, double TB, double BMI)
        {
            BMI = BB / (TB*TB);
        }

        public class total
        {
            protected double BMI { get; set; }
        }
    }

}
