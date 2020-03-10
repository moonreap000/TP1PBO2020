using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class proses login
namespace TP1
{
    class Proses
    {
        public int Compare_login(Login login)
        {   
        //vairbale deklarasi dari kelas login
            string input_username = login.username;
            string input_password = login.password;
            int hasil;
            
            //syarat jika password sama atau tidak
            if (string.Compare(input_password, "pbo123") == 0)
            {
                hasil = 1;
            }
            else
            {
                hasil = 0;
            }
            //return hasil smam atau tidak
            return hasil;
        }
    }
}
