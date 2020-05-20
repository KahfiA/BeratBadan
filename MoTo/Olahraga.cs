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
    public partial class Olahraga : Form
    {
        public Olahraga()
        {
            InitializeComponent();
        }

        private void btOH_Click(object sender, EventArgs e)
        {
            HighImpact highImpact = new HighImpact();
            highImpact.Show();
            this.Hide();
        }

        private void btOL_Click(object sender, EventArgs e)
        {
            LowImpact lowImpact = new LowImpact();
            lowImpact.Show();
        }

        private void btKembaliOr_Click(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.Show();
            this.Hide();
        }
    }
}
