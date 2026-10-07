using System;

namespace jadwal
{
    class Home
    {
        static void Main(string[] args)
        {
            Senin sen = new Senin();
            Selasa sel = new Selasa();
            Rabu rab = new Rabu();

            sen.sesi1();
            sen.sesi2();
            sen.sesi3();

            sel.sesi1();
            sel.sesi2();
            sel.sesi3();

            rab.sesi1();
            rab.sesi2();
            rab.sesi3();

            Kamis.sesi1();
            Kamis.sesi2();
            Kamis.sesi3();

            Jumat.sesi1();
            Jumat.sesi2();
        }

        class Senin
        {
            public void sesi1()
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("                SENIN                     ");
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine("  SESI 1");
                Console.WriteLine("  0. Upacara                               (07.00 - 07.35)");
                Console.WriteLine("  1. Bahasa Jepang                         (07.35 - 08.45)");
                Console.WriteLine("  2. Bahasa Inggris                        (08.45 - 09.55)");
                Console.WriteLine("  Istirahat Pertama                        (09.55 - 10.10)");
            }

            public void sesi2()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 2");
                Console.WriteLine("  3. Matematika                            (10.10 - 11.40)");
                Console.WriteLine("  Ishoma / Makan MBG                       (11.40 - 12.30)");
            }

            public void sesi3()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 3");
                Console.WriteLine("  4. Pengembangan Perangkat Lunak dan Game (12.30 - 14.30)");
                Console.WriteLine("  Pulang");
                Console.WriteLine();
            }
        }

        class Selasa
        {
            public void sesi1()
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("                SELASA                    ");
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine("  SESI 1");
                Console.WriteLine("  1. PKWU / KIK                            (07.00 - 07.35)");
                Console.WriteLine("  2. Pendidikan Jasmani dan Kesehatan      (08.10 - 09.20)");
                Console.WriteLine("  Istirahat Pertama                        (09.20 - 09.35)");
            }

            public void sesi2()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 2");
                Console.WriteLine("  4. Bahasa Indonesia                      (09.35 - 11.05)");
                Console.WriteLine("  Ishoma / Makan MBG                       (11.05 - 12.00)");
            }

            public void sesi3()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 3");
                Console.WriteLine("  5. Pengembangan Perangkat Lunak dan Game (12.30 - 14.00)");
                Console.WriteLine("  Pulang");
                Console.WriteLine();
            }
        }

        class Rabu
        {
            public void sesi1()
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("                RABU                      ");
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine("  SESI 1");
                Console.WriteLine("  1. Pengembangan Perangkat Lunak dan Game (07.00 - 09.20)");
                Console.WriteLine("  Istirahat Pertama                        (09.20 - 09.35)");
            }

            public void sesi2()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 2");
                Console.WriteLine("  2. Pengembangan Perangkat Lunak dan Game (09.35 - 11.35)");
                Console.WriteLine("  Ishoma / Makan MBG                       (11.35 - 12.30)");
            }

            public void sesi3()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 3");
                Console.WriteLine("  3. Pengembangan Perangkat Lunak dan Game (12.30 - 13.30)");
                Console.WriteLine("  4. Bimbingan Konseling                   (13.30 - 14.00)");
                Console.WriteLine("  Pulang");
                Console.WriteLine();
            }
        }

        class Kamis
        {
            public static void sesi1()
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("                KAMIS                     ");
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine("  SESI 1");
                Console.WriteLine("  1. Bahasa Jerman                         (07.00 - 08.10)");
                Console.WriteLine("  2. Bahasa Jawa                           (08.10 - 09.20)");
                Console.WriteLine("  Istirahat Pertama                        (09.20 - 09.35)");
            }

            public static void sesi2()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 2");
                Console.WriteLine("  3. PKWU / KIK                            (09.35 - 11.35)");
                Console.WriteLine("  Ishoma / Makan MBG                       (11.35 - 12.30)");
            }

            public static void sesi3()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 3");
                Console.WriteLine("  4. Pendidikan Agama dan Budi Pekerti     (12.30 - 13.30)");
                Console.WriteLine("  Pulang");
                Console.WriteLine();
            }
        }

        class Jumat
        {
            public static void sesi1()
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("                JUMAT                     ");
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine("  SESI 1");
                Console.WriteLine("  0. Jumat Sehat / Jumat Bersih / Istighosah (06.30 - 08.00)");
                Console.WriteLine("  1. Bahasa Inggris                          (08.00 - 09.00)");
                Console.WriteLine("  2. Sejarah Indonesia                       (09.00 - 10.00)");
                Console.WriteLine("  Istirahat Pertama                          (10.00 - 10.15)");
            }

            public static void sesi2()
            {
                Console.WriteLine();
                Console.WriteLine("  SESI 2");
                Console.WriteLine("  3. Pendidikan Pancasila                    (10.15 - 11.15)");
                Console.WriteLine("  Ishoma / Makan MBG");
                Console.WriteLine("  Pulang");
                Console.WriteLine();
            }
        }
    }
}