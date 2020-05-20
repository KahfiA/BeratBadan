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
    public partial class HighImpact : Form
    {
        public HighImpact()
        {
            InitializeComponent();
        }

        private void btKapanHigh_Click(object sender, EventArgs e)
        {
            Kapan_HighImpact kapan_High = new Kapan_HighImpact();
            kapan_High.Show();
            this.Hide();
        }

        private void btVideoHighImpact_Click(object sender, EventArgs e)
        {
            OlahragaHigh olahragaHigh = new OlahragaHigh();
            olahragaHigh.Show();
            this.Hide();
        }

        private void btKembaliHigh_Click(object sender, EventArgs e)
        {
            Olahraga olahraga = new Olahraga();
            olahraga.Show();
            this.Hide();
        }
    }
}
