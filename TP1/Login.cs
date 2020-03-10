using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Kelas login
namespace TP1
{
    class Login
    {  
        //deklarasi login
        public string username { get; set; }
        public string password { get; set; }
        public Login(string username, string password)
        {
            //memasukkan value
            this.username = username;
            this.password = password;
        }
        public Login()
        {

        }
    }
}
