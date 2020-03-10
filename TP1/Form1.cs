
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TP1
{
    public partial class Form1 : Form
    {
        Proses proses = new Proses();
        Login login = new Login();
        Form2 menu = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click_1(object sender, EventArgs e)
        {
            
            login.username = Convert.ToString(tb_username.Text);
            login.password = Convert.ToString(tb_password.Text);

            int hasil = proses.Compare_login(login);

            if (hasil == 0)
            {
                string message = "Password yang anda masukan salah";
                string title = "ERROR: 101";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);

                tb_password.Text = String.Empty;
            }
            else
            {
                this.Hide();
                menu.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
