using System;
using ConsoleApp1;
using modul4_103022330044;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pilih menu:");
                Console.WriteLine("1. KodeProduk");
                Console.WriteLine("2. x");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HandleKodeProduk();
                        break;
                    case "2":
                        //HandleDoorMachine();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }

        static void HandleKodeProduk()
        {
            KodeProduk kodeProduk = new KodeProduk();
            Console.Write("Masukkan nama produk: ");
            string produk = Console.ReadLine();
            string kode = kodeProduk.GetKodeProduk(produk);
            Console.WriteLine($"Kode pos untuk {produk} adalah {kode}");
        }
        
    }
}