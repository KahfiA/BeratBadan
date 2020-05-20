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
    public partial class Diet : Form
    {
        public Diet()
        {
            InitializeComponent();
        }

        private void btTurunBerat_Click(object sender, EventArgs e)
        {
            TurunBerat turunBerat = new TurunBerat();
            turunBerat.Show();
            this.Hide();
        }

        private void btStabilBerat_Click(object sender, EventArgs e)
        {
            StabilBerat stabil = new StabilBerat();
            stabil.Show();
            this.Hide();
        }

        private void btNaikBerat_Click(object sender, EventArgs e)
        {
            NaikBerat naik = new NaikBerat();
            naik.Show();
            this.Hide();
        }

        private void btKembaliVideoLow_Click(object sender, EventArgs e)
        {
            HitungBerat hitung = new HitungBerat();
            hitung.Show();
            this.Hide();
        }

        private void btHitungBerat_Click(object sender, EventArgs e)
        {
            Olahraga olahraga = new Olahraga();
            olahraga.Show();
            this.Hide();
        }
    }
}
