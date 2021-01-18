using System;

namespace EnginDemirogDersleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { };
            product.Adi = "Elma";
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product);
        }
    }
}
