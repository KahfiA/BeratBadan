using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo.Library
{
    public class GolonganBMI : HitungBMI
    {
        public bool jika1, jika2, jika3, jika4;
        public void gologan(double BMI)
        {
            if(BMI < 18.50)
            {
                jika1 = true;
            }
            else if(BMI >= 18.50 && BMI < 23.00)
            {
                jika2 = true;
            }
            else if(BMI >= 23.00 && BMI < 30.00)
            {
                jika3 = true;
            }
            else
            {
                jika4 = true;
            }
        }
    }
}