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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Pendahuluan pendahuluan = new Pendahuluan();
            pendahuluan.Show();
            this.Hide();
        }
    }
}
