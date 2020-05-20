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
    public partial class LowImpact : Form
    {
        public LowImpact()
        {
            InitializeComponent();
        }

        private void btVideoLowImpact_Click(object sender, EventArgs e)
        {
            OlahragaLow olahragaLow = new OlahragaLow();
            olahragaLow.Show();
            this.Hide();
        }

        private void btKapanLow_Click(object sender, EventArgs e)
        {
            Kapan_LowImpact kapan_LowImpact = new Kapan_LowImpact();
            kapan_LowImpact.Show();
            this.Hide();
        }

        private void btKembaliLow_Click(object sender, EventArgs e)
        {
            Olahraga olahraga = new Olahraga();
            olahraga.Show();
            this.Hide();
        }
    }
}
