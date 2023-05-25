using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {"kurs1", "kursnedirlannnnn", "kurs3", "kurs4", "kursson"
            };

             for (int i = 0; i <kurslar.Length; i++)
              {
                Console.WriteLine(kurslar[i]);
              }
            Console.WriteLine("başkadizi");

            foreach (string kura in kurslar)
            {
                Console.WriteLine(kura);
            }
        }
    }
}
