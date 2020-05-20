using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoTo
{
    public partial class HitungBerat : Form
    {
        Table1 table1;
        public bool btcekbmiclicked;
        public HitungBerat()
        {
            InitializeComponent();
        }

        private void btKembaliHitungBb_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void HitungBerat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbBMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbHitungBb_Click(object sender, EventArgs e)
        {

        }

        private void btCekBMI_Click(object sender, EventArgs e)
        {
            if (tbBB.Text == "" && tbTB.Text == "")
            {
                Hitung hitung = new Hitung();
            }
            else
            {
                Hitung hitung = new Hitung();
                tbBMI.Text = Convert.ToString(" " + hitung.hitungbmi(Convert.ToDouble(tbBB.Text), Convert.ToDouble(tbTB.Text)));

                GolonganBMI golonganBMI = new GolonganBMI();
                golonganBMI.golBMI(Convert.ToDouble(tbBMI.Text));

                Hasil hasil = new Hasil();
                tbGolBMI.Text = hasil.hasilgol(golonganBMI);

                Lakukan lakukan = new Lakukan();
                tblakukan.Text = lakukan.lakukansaran(golonganBMI);

                btcekbmiclicked = true;
            }
        }

        private void Daftar_BMI()
        {
            if (tbBB.Text != "" && tbTB.Text != "")
            {
                using (var db = new MoToDatabase())
                {
                    table1 = new Table1
                    {
                        BB = tbBB.Text,
                        TB = tbTB.Text,
                        BMI = tbBMI.Text,
                    };
                    db.Table1.Add(table1);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void btLanjut_Click(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.Show();
            this.Hide();
        }
    }
}
