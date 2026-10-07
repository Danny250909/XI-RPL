using System;

namespace DataSiswa
{
    class Home
    {
        static void Main(string[] args)
        {
            Identitas idn = new Identitas();
            MataPelajaran mapel = new MataPelajaran();
            Absensi absen = new Absensi();
            Nilai nilai = new Nilai();

            Console.WriteLine("========== IDENTITAS SISWA ==========");
            idn.siswa();
            Console.WriteLine();

            Console.WriteLine("========== IDENTITAS ORANG TUA ==========");
            idn.orangtua();
            Console.WriteLine();

            Console.WriteLine("========== RIWAYAT SEKOLAH ==========");
            idn.sekolah();
            Console.WriteLine();

            Console.WriteLine("========== MATA PELAJARAN NON-PRODUKTIF ==========");
            mapel.NonProduktif();
            Console.WriteLine();

            Console.WriteLine("========== MATA PELAJARAN PRODUKTIF ==========");
            mapel.Produktif();
            Console.WriteLine();

            Console.WriteLine("========== ABSENSI PER BULAN ==========");
            absen.bulan();
            Console.WriteLine();

            Console.WriteLine("========== NILAI ==========");
            nilai.nilai();
        }

        class Identitas
        {
            public void siswa()
            {
                Console.WriteLine("Nama Siswa : Aditya Daniel");
                Console.WriteLine("Tempat Lahir : Surabaya");
                Console.WriteLine("Umur : 15 Tahun");
                Console.WriteLine("NISN : 974597960941");
                Console.WriteLine("NIS : 19671");
            }

            public void orangtua()
            {
                Console.WriteLine("Nama Wali : Daniel Christiawan");
                Console.WriteLine("Pekerjaan : Export Import Furniture");
                Console.WriteLine("Umur : 45 Tahun");
            }

            public void sekolah()
            {
                Console.WriteLine("Nama Sekolah TK : Mandiri");
                Console.WriteLine("Nama Sekolah SD : SDN Suko 1");
                Console.WriteLine("Nama Sekolah SMP : SMPN 7 Sidoarjo");
                Console.WriteLine("Nama Sekolah SMK : SMKN 4 Buduran");
            }
        }

        class MataPelajaran
        {
            public void NonProduktif()
            {
                Console.WriteLine("1. Bahasa Jepang");
                Console.WriteLine("2. Bahasa Inggris");
                Console.WriteLine("3. Bahasa Jerman");
                Console.WriteLine("4. Bahasa Indonesia");
                Console.WriteLine("4. Bahasa Jawa");
                Console.WriteLine("5. Matematika");
                Console.WriteLine("6. Pendidikan Agama");
                Console.WriteLine("7. Pendidikan Pancasila");
                Console.WriteLine("8. Sejarah Indonesia");
            }

            public void Produktif()
            {
                Console.WriteLine("1. Pemograman Web");
                Console.WriteLine("2. Database");
                Console.WriteLine("3. Kewirausahaan");
            }
        }

        class Absensi
        {
            public void bulan()
            {
                Console.WriteLine("Januari   : Sakit: 0, Ijin: 0, Alpha: 0");
                Console.WriteLine("Februari  : Sakit: 1, Ijin: 0, Alpha: 0");
                Console.WriteLine("Maret     : Sakit: 0, Ijin: 1, Alpha: 0");
                Console.WriteLine("April     : Sakit: 0, Ijin: 0, Alpha: 1");
                Console.WriteLine("Mei       : Sakit: 1, Ijin: 1, Alpha: 0");
                Console.WriteLine("Juni      : Sakit: 0, Ijin: 0, Alpha: 0");
                Console.WriteLine("Juli      : Sakit: 0, Ijin: 2, Alpha: 0");
                Console.WriteLine("Agustus   : Sakit: 1, Ijin: 0, Alpha: 1");
                Console.WriteLine("September : Sakit: 0, Ijin: 1, Alpha: 0");
                Console.WriteLine("Oktober   : Sakit: 0, Ijin: 0, Alpha: 0");
                Console.WriteLine("November  : Sakit: 1, Ijin: 1, Alpha: 0");
                Console.WriteLine("Desember  : Sakit: 0, Ijin: 0, Alpha: 1");
            }
        }

        class Nilai
        {
            public void nilai()
            {
                Console.WriteLine("Matematika : 90");
                Console.WriteLine("Pendidikan Agama : 92");
                Console.WriteLine("Bahasa Indonesia : 85");
                Console.WriteLine("Bahasa Inggris : 88");
                Console.WriteLine("Bahasa Idnoensia : 87");
                Console.WriteLine("Pendidikan Pancasila : 89");
                Console.WriteLine("Kewirausahaan : 90");
            }
        }
    }
}