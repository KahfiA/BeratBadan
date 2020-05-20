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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //untuk check apakah akun telah terdaftar
        private bool ValidateUser(string username, string password)
        {
            MoToDatabase db = new MoToDatabase();
            var query = from Table in db.Tables where Table.Username == username && Table.Password == password select Table;
            if (query.Any())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Akunmu belum terdaftar");
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Daftar daftar = new Daftar();
            daftar.Show();
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            Akun akun = new Akun();
            if (tbusername.Text != "" && tbpass.Text != "")
            {
                if (ValidateUser(tbusername.Text, tbpass.Text))
                {
                    HitungBerat hitungBerat = new HitungBerat();
                    hitungBerat.Show();
                    this.Close();
                }
                else if (akun.Validasi(tbusername.Text, tbpass.Text))
                {
                    HitungBerat hitungBerat = new HitungBerat();
                    hitungBerat.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau password salah");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}