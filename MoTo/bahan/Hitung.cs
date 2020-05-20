using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo
{
    public class Hitung : Data
    {
        public double hitungbmi(double BB, double TB)
        {
            BMI = (BB / (TB * TB));
            return BMI;
        }
    }
}