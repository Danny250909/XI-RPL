using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool jalan = true;
        while (jalan)
        {
            Console.Clear();
            Console.WriteLine("PROGRAM PEMBELAJARAN C# (Ringkas & Presentatif)");
            Console.WriteLine();
            Console.WriteLine("1. BAB 1  - Pengenalan Pemrograman");
            Console.WriteLine("2. BAB 2  - Algoritma");
            Console.WriteLine("3. BAB 3  - Flowchart");
            Console.WriteLine("4. BAB 4  - Pseudocode");
            Console.WriteLine("5. BAB 5  - Variabel dan Teks");
            Console.WriteLine("6. BAB 6  - Struktur Program C#");
            Console.WriteLine("7. BAB 7  - Variabel dan Tipe Data C#");
            Console.WriteLine("8. BAB 8  - Operator");
            Console.WriteLine("9. BAB 9  - Input");
            Console.WriteLine("10. BAB 10 - Percabangan");
            Console.WriteLine("11. BAB 11 - Perulangan");
            Console.WriteLine("12. BAB 12 - Array dan List");
            Console.WriteLine("13. BAB 13 - Method");
            Console.WriteLine("14. BAB 14 - Class dan Object");
            Console.WriteLine("0. Keluar");
            Console.WriteLine();
            Console.Write("Pilih Bab: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    TampilkanBab(
                        "BAB 1 - PENGENALAN PEMROGRAMAN",
                        "Hardware adalah perangkat keras (contoh: Keyboard, Mouse, CPU).\n" +
                        "Software adalah perangkat lunak (contoh: Windows, Word, Chrome).\n\n" +
                        "Lima bahasa pemrograman: C#, Java, Python, C++, JavaScript.",
                        "1. Sebutkan 3 contoh hardware!\n" +
                        "2. Sebutkan 3 contoh software!\n" +
                        "3. Apa perbedaan hardware dan software?",
                        () => {
                            Console.Write("Masukkan nama: ");
                            string nama = Console.ReadLine();
                            Console.WriteLine($"Hello, {nama}! Selamat datang di C#.");
                        }
                    );
                    break;

                case "2":
                    TampilkanBab(
                        "BAB 2 - ALGORITMA",
                        "Algoritma adalah urutan langkah logis untuk menyelesaikan masalah.\n" +
                        "Contoh algoritma login:\n" +
                        "1. Mulai\n2. Masukkan username & password\n3. Cek kecocokan\n" +
                        "4. Jika cocok → berhasil, jika tidak → gagal\n5. Selesai",
                        "1. Tulis algoritma membuat teh!\n" +
                        "2. Tulis algoritma tarik tunai di ATM!\n" +
                        "3. Tulis algoritma luas segitiga!",
                        () => {
                            Console.WriteLine("Mini Project: Algoritma menghitung luas persegi panjang");
                            Console.WriteLine("1. Masukkan panjang\n2. Masukkan lebar\n3. Luas = panjang × lebar\n4. Tampilkan luas");
                        }
                    );
                    break;

                case "3":
                    TampilkanBab(
                        "BAB 3 - FLOWCHART",
                        "Flowchart adalah diagram alir yang menggambarkan langkah-langkah program.\n" +
                        "Simbol dasar:\n" +
                        "• Terminator (oval) = mulai/selesai\n" +
                        "• Proses (persegi panjang) = aksi\n" +
                        "• Decision (belah ketupat) = percabangan\n" +
                        "• Input/Output (jajar genjang)\n" +
                        "• Alur (panah)\n\n" +
                        "Contoh flowchart login: mulai → input username & password → cek → jika benar → login berhasil → selesai.",
                        "1. Gambarkan flowchart untuk menghitung luas persegi panjang!\n" +
                        "2. Gambarkan flowchart untuk menentukan bilangan genap/ganjil!\n" +
                        "3. Gambarkan flowchart untuk menampilkan angka 1-10!",
                        () => {
                            Console.WriteLine("Mini Project: Flowchart membuat teh");
                            Console.WriteLine("1. Mulai\n2. Siapkan gelas & teh\n3. Panaskan air\n4. Tuangkan air panas\n5. Tambahkan gula\n6. Aduk\n7. Selesai");
                        }
                    );
                    break;

                case "4":
                    TampilkanBab(
                        "BAB 4 - PSEUDOCODE",
                        "Pseudocode adalah deskripsi algoritma menggunakan bahasa semi-formal.\n" +
                        "Contoh pseudocode login:\n" +
                        "MULAI\n" +
                        "  INPUT username, password\n" +
                        "  IF username == 'admin' AND password == '12345' THEN\n" +
                        "    TAMPILKAN 'Login berhasil'\n" +
                        "  ELSE\n" +
                        "    TAMPILKAN 'Login gagal'\n" +
                        "  ENDIF\n" +
                        "SELESAI",
                        "1. Tulis pseudocode untuk menghitung rata-rata tiga nilai!\n" +
                        "2. Tulis pseudocode untuk menentukan bilangan positif/negatif!\n" +
                        "3. Tulis pseudocode untuk mencetak bilangan genap 1-20!",
                        () => {
                            Console.WriteLine("Mini Project: Pseudocode menghitung luas lingkaran");
                            Console.WriteLine("MULAI\n  INPUT jari-jari\n  luas = 3.14 * jari-jari * jari-jari\n  TAMPILKAN luas\nSELESAI");
                        }
                    );
                    break;

                case "5":
                    TampilkanBab(
                        "BAB 5 - VARIABEL DAN TEKS",
                        "Variabel string digunakan untuk menyimpan teks.\n" +
                        "Contoh:\n" +
                        "string nama = \"Andi\";\n" +
                        "Console.WriteLine($\"Halo {nama}\");",
                        "1. Deklarasikan variabel untuk alamat!\n" +
                        "2. Deklarasikan variabel untuk jumlah saudara!\n" +
                        "3. Tampilkan keduanya!",
                        () => {
                            Console.Write("Masukkan nama: ");
                            string nama = Console.ReadLine();
                            Console.Write("Masukkan umur: ");
                            int umur = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Halo {nama}, umur {umur} tahun.");
                        }
                    );
                    break;

                case "6":
                    TampilkanBab(
                        "BAB 6 - STRUKTUR PROGRAM C#",
                        "Struktur dasar C#:\n" +
                        "using System;\n" +
                        "class Program {\n" +
                        "    static void Main() {\n" +
                        "        // kode\n" +
                        "    }\n" +
                        "}\n\n" +
                        "• using System: mengakses namespace System\n" +
                        "• Main(): titik awal eksekusi\n" +
                        "• Write() vs WriteLine(): Write tanpa baris baru, WriteLine dengan baris baru",
                        "1. Apa fungsi using System?\n" +
                        "2. Apa fungsi Main()?\n" +
                        "3. Jelaskan perbedaan Write() dan WriteLine()!",
                        () => {
                            Console.WriteLine("Mini Project: tampilkan struktur program C#");
                            Console.WriteLine("using System;\nclass Program {\n    static void Main() {\n        Console.WriteLine(\"Halo Dunia\");\n    }\n}");
                        }
                    );
                    break;

                case "7":
                    TampilkanBab(
                        "BAB 7 - VARIABEL DAN TIPE DATA C#",
                        "Tipe data dasar:\n" +
                        "• int = bilangan bulat (contoh: 17)\n" +
                        "• double = desimal (contoh: 3.75)\n" +
                        "• char = satu karakter (contoh: 'A')\n" +
                        "• string = teks (contoh: \"Andi\")\n" +
                        "• bool = true/false\n\n" +
                        "Contoh deklarasi:\n" +
                        "int umur = 17;\n" +
                        "double ipk = 3.75;\n" +
                        "char grade = 'A';\n" +
                        "string nama = \"Andi\";\n" +
                        "bool lulus = true;",
                        "1. Deklarasikan variabel untuk berat badan (double)!\n" +
                        "2. Deklarasikan variabel untuk jenis kelamin (char)!\n" +
                        "3. Deklarasikan variabel untuk status pernikahan (bool)!",
                        () => {
                            Console.Write("Masukkan nama: ");
                            string nama = Console.ReadLine();
                            Console.Write("Masukkan umur: ");
                            int umur = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Tipe data nama = string, umur = int");
                            Console.WriteLine($"Nilai: {nama}, {umur}");
                        }
                    );
                    break;

                case "8":
                    TampilkanBab(
                        "BAB 8 - OPERATOR",
                        "Operator aritmatika: +, -, *, /, %\n" +
                        "Operator perbandingan: ==, !=, <, >, <=, >=\n" +
                        "Operator logika: && (AND), || (OR), ! (NOT)",
                        "1. Buat program luas persegi panjang!\n" +
                        "2. Buat program rata-rata tiga nilai!\n" +
                        "3. Buat program cek bilangan genap/ganjil!",
                        () => {
                            Console.Write("Harga barang: ");
                            double harga = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Jumlah: ");
                            int jumlah = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Total = {harga * jumlah}");
                        }
                    );
                    break;

                case "9":
                    TampilkanBab(
                        "BAB 9 - INPUT",
                        "Input dari pengguna menggunakan Console.ReadLine().\n" +
                        "Contoh:\n" +
                        "Console.Write(\"Nama: \");\n" +
                        "string nama = Console.ReadLine();\n\n" +
                        "Untuk angka: Convert.ToInt32(Console.ReadLine())",
                        "1. Beda Write() dan WriteLine()?\n" +
                        "2. Buat program input nama dan sapaan!\n" +
                        "3. Hitung umur dari tahun lahir!",
                        () => {
                            Console.Write("Angka pertama: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Angka kedua: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Jumlah = {a + b}");
                        }
                    );
                    break;

                case "10":
                    TampilkanBab(
                        "BAB 10 - PERCABANGAN",
                        "Percabangan digunakan untuk pengambilan keputusan.\n" +
                        "if (kondisi) { ... } else { ... }\n" +
                        "Contoh:\n" +
                        "if (nilai >= 75) lulus; else tidak lulus;",
                        "1. Buat program cek bilangan ganjil/genap!\n" +
                        "2. Buat program diskon belanja!\n" +
                        "3. Buat program kategori nilai!",
                        () => {
                            Console.Write("Masukkan umur: ");
                            int umur = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(umur >= 17 ? "Boleh buat KTP" : "Belum boleh");
                        }
                    );
                    break;

                case "11":
                    TampilkanBab(
                        "BAB 11 - PERULANGAN",
                        "Perulangan untuk menjalankan blok kode berulang.\n" +
                        "for (int i = 0; i < n; i++) { ... }\n" +
                        "while (kondisi) { ... }\n\n" +
                        "Contoh: for (int i=1; i<=10; i++) Console.Write(i + \" \");",
                        "1. Cetak angka 1-100!\n" +
                        "2. Hitung faktorial!\n" +
                        "3. Buat pola bintang!",
                        () => {
                            Console.Write("Jumlah siswa: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= n; i++)
                            {
                                Console.Write($"Nama siswa ke-{i}: ");
                                Console.ReadLine();
                            }
                            Console.WriteLine("Input selesai.");
                        }
                    );
                    break;

                case "12":
                    TampilkanBab(
                        "BAB 12 - ARRAY DAN LIST",
                        "Array: kumpulan data dengan tipe sama dan ukuran tetap.\n" +
                        "int[] angka = {1,2,3};\n" +
                        "List: kumpulan data dinamis.\n" +
                        "List<string> nama = new List<string>();\n" +
                        "Akses elemen: angka[0]",
                        "1. Cari nilai terbesar dalam array!\n" +
                        "2. Hitung jumlah bilangan genap!\n" +
                        "3. Buat daftar nama dengan List!",
                        () => {
                            int[] nilai = { 75, 80, 90, 85, 70 };
                            double rata = 0;
                            foreach (int n in nilai) rata += n;
                            rata /= nilai.Length;
                            Console.WriteLine($"Rata-rata = {rata}");
                        }
                    );
                    break;

                case "13":
                    TampilkanBab(
                        "BAB 13 - METHOD",
                        "Method adalah blok kode yang dapat dipanggil.\n" +
                        "Contoh:\n" +
                        "static int Tambah(int a, int b) { return a + b; }",
                        "1. Buat method luas persegi panjang!\n" +
                        "2. Buat method faktorial!\n" +
                        "3. Buat method pangkat!",
                        () => {
                            Console.WriteLine($"Rata-rata 80,90,85 = {HitungRata(80, 90, 85)}");
                        }
                    );
                    break;

                case "14":
                    TampilkanBab(
                        "BAB 14 - CLASS DAN OBJECT",
                        "Class adalah blueprint, object adalah instance dari class.\n" +
                        "Contoh:\n" +
                        "class Siswa { public string Nama; }\n" +
                        "Siswa s = new Siswa();",
                        "1. Buat class Buku!\n" +
                        "2. Buat class Mahasiswa!\n" +
                        "3. Buat constructor dua parameter!",
                        () => {
                            Mobil m = new Mobil();
                            m.Merk = "Toyota";
                            m.Jalan();
                        }
                    );
                    break;

                case "0":
                    jalan = false;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // Method bantu untuk menampilkan submenu dan konten
    static void TampilkanBab(string judul, string studiKasus, string latihan, Action miniProject)
    {
        bool kembali = false;
        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine(judul);
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Mini Project");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"{judul} - STUDI KASUS\n");
                    Console.WriteLine(studiKasus);
                    Pause();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"{judul} - LATIHAN\n");
                    Console.WriteLine(latihan);
                    Pause();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine($"{judul} - MINI PROJECT\n");
                    miniProject();
                    Pause();
                    break;
                case "0":
                    kembali = true;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static double HitungRata(int a, int b, int c) => (a + b + c) / 3.0;

    static void Pause()
    {
        Console.WriteLine("\nTekan ENTER untuk kembali...");
        Console.ReadLine();
    }
}

// Class untuk Bab 14
class Mobil
{
    public string Merk { get; set; }
    public void Jalan() => Console.WriteLine($"{Merk} sedang berjalan.");
}