using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTo
{
    class Akun
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Validasi(string username, string password)
        {
            if (username == "moto" && password == "moto")
            return true;
            else
            return false;
        }
    }
}
