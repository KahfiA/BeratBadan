using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo.Library
{
    public class Hasil
    {
        string hasil;
        public bool kurang, normal, lebih, obesitas;
        public string hasilgol(GolonganBMI golonganBMI)
        {
            if (golonganBMI.jika1 == true)
            {
                hasil = "Berat badanmu kurang";
                kurang = true;
                return hasil;
            }
            else if (golonganBMI.jika2 == true)
            {
                hasil = "Berat badanmu normal";
                normal = true;
                return hasil;
            }
            else if (golonganBMI.jika3 == true)
            {
                hasil = "Baerat badanmu lebih";
                lebih = true;
                return hasil;
            }
            else
            {
                hasil = "Yah Obesitas, Semangat";
                obesitas = true;
                return hasil;
            }
        }
    
    }
}