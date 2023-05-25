using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "karabey";
            kurs1.Egitmen = "sen";
            kurs1.izlenmeOrani = 89;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "marabey";
            kurs2.Egitmen = "ren";
            kurs2.izlenmeOrani = 84;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "sarabey";
            kurs3.Egitmen = "fen";
            kurs3.izlenmeOrani = 44;

            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            

            foreach (Kurs surs in Kurslar)
            {
                Console.WriteLine(surs.Egitmen + "  " + surs.KursAdi + " ve");

            }
            // Console.WriteLine(kurs1.Egitmen + "  " + kurs1.KursAdi);


        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    } 