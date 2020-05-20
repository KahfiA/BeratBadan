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
    public partial class Kapan_HighImpact : Form
    {
        public Kapan_HighImpact()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btKembaliKapanHigh_Click(object sender, EventArgs e)
        {
            HighImpact highImpact = new HighImpact();
            highImpact.Show();
            this.Hide();
        }
    }
}
