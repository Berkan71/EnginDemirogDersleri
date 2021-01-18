using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogDersleri
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi.."+ product.Adi);
        }
    }
}
