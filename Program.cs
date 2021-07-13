using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
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

            // PERINTAH: lengkapi kode untuk menampilkan menu
            {
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Mahasiswa");
                Console.WriteLine("2. Hapus Mahasiswa");
                Console.WriteLine("3. Tampilkan Mahasiswa");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
            }
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            string NIM;
            string NAME;
            string JenisKelamin;
            string Ipk;

            Console.Write("NIM: ");
            nim = Console.ReadLine();
            Console.Write("Nama: ");
            nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]: ");
            jenisKelamin = Console.ReadLine();
            if (jenisKelamin.Equals("L", StringComparison.InvariantCultureIgnoreCase))
            {
                jenisKelamin = "Laki - Laki";
            }
            else
            {
                jenisKelamin = "Perempuan";
            }
            Console.Write("IPK: ");
            ipk = Console.ReadLine();

            daftarMahasiswa.Add(new Mahasiswa(nim, nama, jenisKelamin, ipk));

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            {
                Console.Clear();

                string caricari;

                Console.WriteLine("Hapus data mahasiswa \n");

                Console.Write("NIM: ");
                cari = Console.ReadLine();

                int idx = 0; //Cari dlu index datamahasiswanya

                if (idx == -1)
                {
                    Console.WriteLine("NIM Tidak ditemukan");
                }
                else
                {
                    daftarMahasiswa.RemoveAt(idx);
                    Console.WriteLine("Data mahasiswa berhasil dihapus");
                }


                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

                // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
                {
                    Console.Clear();
                    Console.WriteLine("Data Mahasiswa\n");

                    int i = 1;
                    foreach (Mahasiswa mhs in daftarMahasiswa)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", i, mhs.Nim, mhs.NamaMahasiswa, mhs.JenisKelamin, mhs.IPK);
                        i++;
                    }

                    Console.WriteLine("\nTekan enter untuk kembali ke menu");
                    Console.ReadKey();
                }

                Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
