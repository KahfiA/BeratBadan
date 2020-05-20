﻿using System;
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
    public partial class StabilBerat : Form
    {
        public StabilBerat()
        {
            InitializeComponent();
        }

        private void lanjutStabil_Click(object sender, EventArgs e)
        {
            Terimakasih terimakasih = new Terimakasih();
            terimakasih.Show();
            this.Hide();
        }

        private void btKembaliStabil_Click(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.Show();
            this.Hide();
        }
    }
}