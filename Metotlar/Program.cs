using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.Adi = "elma";
            Product1.Fiyati = 15;
            Product1.Aciklama = "amasya elması";

            Product Product2 = new Product();
            Product2.Adi= "karpuz";
            Product2.Fiyati = 80;
            Product2.Aciklama = "iyi karpuz bende";

            Product[] Products = new Product[] { Product1, Product2 };
            foreach (Product product in Products) 
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Id);
                Console.WriteLine("------");  
             
            }
            Console.WriteLine("-------------Metodlar-----------");

            // instance Clasa örnek ekleme
            // hızlıca console.writeline yazmak için CW     TAB+TAB
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Product1);
            sepetManager.Ekle(Product2);


        }
    }
}



// Do not repeat your self- DRY Clean Code- Best Practice