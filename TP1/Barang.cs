using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Kelas Barang untuk list barangnya
namespace TP1
{
    class Barang
    {
        //Deklarasi variabel
        public string jenis_barang { get; set; }
        public string nama_barang { get; set; }
        public string harga_barang { get; set; }
        public Barang(string jenis_barang, string nama_barang, string harga_barnag)
        //memasukan value
        {
            this.jenis_barang = jenis_barang;
            this.nama_barang = nama_barang;
            this.harga_barang= harga_barang;
        }
        public void Input_Barang()
        {

        }
        public Barang()
        {

        }
    }
}
