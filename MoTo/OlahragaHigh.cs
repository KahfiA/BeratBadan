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
    public partial class OlahragaHigh : Form
    {
        public OlahragaHigh()
        {
            InitializeComponent();
        }

        private void btKembaliOHigh_Click(object sender, EventArgs e)
        {
            Olahraga olahraga = new Olahraga();
            olahraga.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terimakasih terimakasih = new Terimakasih();
            terimakasih.Show();
            this.Hide();
        }
    }
}
