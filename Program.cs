using System;
using System.Collections.Generic;

namespace jmmodul4_2311104068
{
    public class KodeBuah
    {
        private Dictionary<string, string> kodeBuah = new Dictionary<string, string>
        {
            { "Apel", "A00" },
            { "Aprikot", "B00" },
            { "Alpukat", "C00" },
            { "Pisang", "D00" },
            { "Paprika", "E00" },
            { "Blackberry", "F00" },
            { "Ceri", "H00" },
            { "Kelapa", "I00" },
            { "Jagung", "J00" }
        };

        public string GetKodeBuah(string namaBuah)
        {
            if (kodeBuah.ContainsKey(namaBuah))
            {
                return kodeBuah[namaBuah];
            }
            else
            {
                return "Kode buah tidak ditemukan";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            KodeBuah kodeBuah = new KodeBuah();

            // Contoh input dan output
            Console.Write("Masukkan nama buah: ");
            string namaBuah = Console.ReadLine();

            string kode = kodeBuah.GetKodeBuah(namaBuah);
            Console.WriteLine($"Kode buah untuk {namaBuah}: {kode}");
        }
    }
}
