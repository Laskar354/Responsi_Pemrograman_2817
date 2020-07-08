using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProdak
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek prodak
        static List<Prodak> daftarProdak = new List<Prodak>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi Pemrograman (UAS)";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProdak();
                        break;

                    case 2:
                        HapusProdak();
                        break;

                    case 3:
                        TampilProdak();
                        Console.WriteLine("\nTekan enter untuk kembali ke menu");
                        Console.ReadKey();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Prodak");
            Console.WriteLine("2. Hapus Prodak");
            Console.WriteLine("3. Tampilkan Prodak");
            Console.WriteLine("4. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProdak()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan prodak ke dalam collection

            Console.WriteLine("Tambah Data Prodak");
            Console.Write("Kode Prodak\t: ");
            double _kode = double.Parse(Console.ReadLine());
            Console.Write("Nama Prodak\t: ");
            string _nama = Console.ReadLine();
            Console.Write("Harga Beli\t: ");
            double _beli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual\t: ");
            double _jual = double.Parse(Console.ReadLine());

            _prodak(_kode,_nama,_beli,_jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProdak()
        {
            Console.Clear();
            TampilProdak();
            Console.WriteLine("\n");
            Console.Write("Masukan Kode Prodak : ");
            double _pilKode = double.Parse(Console.ReadLine());
            bool chek = false;
            for(int i =0; i < daftarProdak.Count; i++)
            {
                if(daftarProdak[i].Kode == _pilKode)
                {
                    var hapus = daftarProdak.Single(r => r.Kode == _pilKode);
                    Console.WriteLine("Data berhasil ditemukan...");
                    Console.WriteLine("Kode\t\t: " + hapus.Kode);
                    Console.WriteLine("Nama\t\t: " + hapus.Nama);
                    Console.WriteLine("Harga Jual\t: " + hapus.Jual);
                    Console.WriteLine("Harga Beli\t: " + hapus.Beli);

                    //daftarProdak.Remove(hapus);
                    //chek = true;
                    Console.Write("Yakin ingin menghapus data??[y/n] : ");
                    char lanjut = char.Parse(Console.ReadLine());
                    if (lanjut == 'y' || lanjut == 'Y')
                    {
                        daftarProdak.Remove(hapus);
                        Console.WriteLine("Data berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data");
                    }
                    chek = true;
                }
                if(!chek)
                {
                    Console.WriteLine("Maaf, Kode tidak ditemukan");
                }
            }
            // PERINTAH: lengkapi kode untuk menghapus prodak dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProdak()
        {
            Console.Clear();

            int nomorUrut = 1;
            foreach(Produk prodak in daftarProdak)
            {
                Console.WriteLine("NO.{0}" + " " + "Kode.{1}" + "\t" + "Nama : {2}" + "\t"+"Hagra Jual : {3}"+"\t"+"Harga Beli : {4}",
                     nomorUrut,prodak.Kode,prodak.Nama,prodak.Jual,prodak.Beli);
                nomorUrut++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar prodak yang ada di dalam collection
        }

        static void _prodak(double _kode, string _nama, double _beli,double _jual)
        {
            daftarProdak.Add(new Prodak {Kode = _kode,Nama = _nama,Jual = _jual,Beli = _beli });
        }
    }
}
