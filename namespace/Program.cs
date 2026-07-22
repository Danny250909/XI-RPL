using System;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Menu().Tampilkan();
        }
    }

    class Menu
    {
        public void Tampilkan()
        {
            bool keluar = false;
            do
            {
                Console.WriteLine("\n1.Kalkulator 2.BangunDatar 3.BangunRuang 4.Zodiak 5.Keluar");
                Console.Write("Pilihan: ");
                string pilihan = Console.ReadLine();

                if (pilihan == "1") new Kalkulator().Hitung();
                else if (pilihan == "2") new BangunDatar().Persegi();
                else if (pilihan == "3") new BangunRuang().Kubus();
                else if (pilihan == "4") new Zodiak().Tentukan();
                else if (pilihan == "5") keluar = true;
                else Console.WriteLine("Pilihan tidak dikenali.");

            } while (!keluar);
        }
    }

    class Kalkulator
    {
        public void Hitung()
        {
            int a = 12, b = 13;
            Console.WriteLine("tambah = " + (a + b));
            Console.WriteLine("kurang = " + (a - b));
            Console.WriteLine("kali = " + (a * b));
            Console.WriteLine("bagi = " + ((double)a / b));
        }
    }

    class BangunDatar
    {
        public void Persegi()
        {
            double sisi = 5;
            Console.WriteLine("luas = " + (sisi * sisi));
            Console.WriteLine("keliling = " + (4 * sisi));
        }
    }

    class BangunRuang
    {
        public void Kubus()
        {
            double sisi = 5;
            Console.WriteLine("volume = " + (sisi * sisi * sisi));
            Console.WriteLine("luas permukaan = " + (6 * sisi * sisi));
        }
    }

    class Zodiak
    {
        public void Tentukan()
        {
            Console.Write("Tanggal: ");
            int tgl = int.Parse(Console.ReadLine());
            Console.Write("Bulan: ");
            int bln = int.Parse(Console.ReadLine());

            string[] nama = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini",
                               "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagitarius" };
            int[] batas = { 19, 18, 20, 19, 20, 20, 22, 22, 22, 22, 21, 21 };

            int index = tgl > batas[bln - 1] ? bln % 12 : bln - 1;
            Console.WriteLine("Zodiak kamu = " + nama[index]);
        }
    }
}