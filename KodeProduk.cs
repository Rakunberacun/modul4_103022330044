using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modul4_103022330044
{ 
    public class KodeProduk
    {
	    
            public string GetKodeProduk(string produk)
            {
                Dictionary<string, string> kodeProduk = new Dictionary<string, string>
                    {
                        { "Laptop", "E100" },
                        { "Smartphone", "E101" },
                        { "Tablet", "E102" },
                        { "Headset", "E103" },
                        { "Keyboard", "E104" },
                        { "Mouse", "E105" },
                        { "Printer", "E106" },
                        { "Monitor", "E107" },
                        { "Smartwatch", "E108" },
                        { "Kamera", "E109" }
                    };
                return kodeProduk.ContainsKey(produk) ? kodeProduk[produk] : "Kode Produk tidak ditemukan";
            }
        
    }
}