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
    public partial class Form2 : Form
    {

        public Form2()
        {
           
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;

            for(int i=0; i<5; i++)
            {
                Barang brg = new Barang();
                Label label = addlabel(i,brg);
                flowLayoutPanel1.Controls.Add(label);
            }
        }
        Label addlabel(int i, Barang brg) {
            string[] nama = new string[5];
            nama[0] = "Ayam Bakar";
            nama[1] = "Ducati";
            nama[2] = "Topi Mogeeeh";
            nama[3] = "Onichici";
            nama[4] = "MSI";

            int[] harga = new int[5];
            harga[0] = 10000;
            harga[1] = 500000;
            harga[2] = 200;
            harga[3] = 30000;
            harga[4] = 23133;

            string[] tipe = new string[5];
            tipe[0] = "Makanan";
            tipe[1] = "Motor";
            tipe[2] = "Benda";
            tipe[3] = "Film ehem";
            tipe[4] = "Elektronik";


            Label label = new Label();
            label.Name = "label" + i;
            label.Text = nama[i];
            label.ForeColor = Color.Black;
            label.Font = new Font("Serif", 18, FontStyle.Bold);
            label.Width = 170;
            label.Height = 80;
            label.Location = new Point(20, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(5);

            return label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
            menu.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://Bukalapak.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
