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
    public partial class NaikBerat : Form
    {
        public NaikBerat()
        {
            InitializeComponent();
        }

        private void lanjutNaik_Click(object sender, EventArgs e)
        {
            Terimakasih terimakasih = new Terimakasih();
            terimakasih.Show();
            this.Close();
        }

        private void btKembaliNaik_Click(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.Show();
            this.Close();
        }
    }
}
