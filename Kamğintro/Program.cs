using System;

namespace Kamğintro
{
    class Program
    {
        static void Main(string[] args)
        {
            String kategoriEtiketi = "Kategori";
            double DolarDun = 1.56;
            double DolarBugub = 2.65;
            if (DolarDun>DolarBugub)
            {
                Console.WriteLine("azalmış");
            }
            else if (DolarDun<DolarBugub)
            {
                Console.WriteLine("artmış");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("aderin oğlum");
            }
            else
            {
                Console.WriteLine("Salak tekrar gir");
            }
        }
    }
}
