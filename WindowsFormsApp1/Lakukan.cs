using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo.Library
{
    class Lakukan
    {
        string lakukan;
        public string lakukansaran(GolonganBMI golonganBMI)
        {
            if (golonganBMI.jika1 == true)
            {
                lakukan = "Ayo naikkan berat badanmu !!!";
                return lakukan;
            }
            else if (golonganBMI.jika2 == true)
            {
                lakukan = "Good Job !!! Pertahankan yaaa";
                return lakukan;
            }
            else if (golonganBMI.jika3 == true)
            {
                lakukan = "Lebih dikit nih ayo turunkan beratmu, Semangattt";
                return lakukan;
            }
            else
            {
                lakukan = "Ayo ayo kamu pasti bisa nurunin beratmu !!! Semangatt";
                return lakukan;
            }
        }
    }
}
