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
    public partial class Kapan_LowImpact : Form
    {
        public Kapan_LowImpact()
        {
            InitializeComponent();
        }

        private void btKembaliKapanLow_Click(object sender, EventArgs e)
        {
            LowImpact lowImpact = new LowImpact();
            lowImpact.Show();
            this.Hide();
        }
    }
}
