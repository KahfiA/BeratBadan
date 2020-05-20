using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo.Library
{
    public abstract class HitungBMI : Data
    {
        public void hitung(double BB, double TB, double BMI)
        {
            BMI = BB / (TB*TB);
        }

        public abstract class total : HitungBMI
        {
            protected double BMI { get; set; }
        }
    }

}
