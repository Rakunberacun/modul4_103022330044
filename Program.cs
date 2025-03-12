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
                Console.WriteLine("2. FanLaptop");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HandleKodeProduk();
                        break;
                    case "2":
                        HandleFanLaptop();
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
            Console.WriteLine($"Kode produk untuk {produk} adalah {kode}");
        }
        static void HandleFanLaptop()
        {
            FanLaptop laptop = new FanLaptop();
            laptop.ShowState();
            bool menuFan = true;
            while (menuFan)
            {
                Console.WriteLine("Masukkan perintah (mode down/mode up/turbo/done): ");
                string command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "mode down":
                        laptop.modeDown();
                        break;
                    case "mode up":
                        laptop.modeUp();
                        break;
                    case "turbo":
                        laptop.turboShortcut();
                        break;
                    case "done":
                        menuFan = false;
                        break;
                    default:
                        Console.WriteLine("Perintah tidak valid Silahkan coba lagi");
                        break;
                }
                laptop.ShowState();
            }
        }
    }
}