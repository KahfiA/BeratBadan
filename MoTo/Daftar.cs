using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace MoTo
{
    public partial class Daftar : Form
    {
        Table table;
        public Daftar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string jeniskelamin = "";
        private void Daftar_Akun()
        {
            if (tbUsername.Text != "" && tbPassword.Text != "" && tbNama.Text != "" && tbNoHp.Text != "" && tbEmail.Text != "")
            {
                if (rbPria.Checked)
                    jeniskelamin = "Pria";
                else if (rbWanita.Checked)
                    jeniskelamin = "Wanita";

                using (var db = new MoToDatabase())
                {

                    table = new Table
                    {
                        Username = tbUsername.Text,
                        Password = tbPassword.Text,
                        Nama_Lengkap = tbNama.Text,
                        No_Hp = tbNoHp.Text,
                        Email = tbEmail.Text,
                        Jenis_Kelamin = jeniskelamin
                    };
                    db.Tables.Add(table);
                    db.SaveChanges();
                    MessageBox.Show("Akun telah terbuat");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Isi data dengan benar");
            }
        }

        private void btKembaliDaftar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btdaftar_Click(object sender, EventArgs e)
        {
            Daftar_Akun();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void rbPria_CheckedChanged(object sender, EventArgs e)
        {
            rbPria.Enabled = rbPria.Checked;
        }

        private void rbWanita_CheckedChanged(object sender, EventArgs e)
        {
            rbWanita.Enabled = rbWanita.Checked;
        }

        public void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

