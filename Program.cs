using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizepuanhesaplamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //değerlerimizi tanımlıyoruz
            int vize1, vize2, final, vizelersonhali, anatoplam, finalsonhali;
            //kullanıcıdan verilerimizi alıyoruz
            Console.WriteLine("Vize1 notunuzu giriniz");
            vize1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize2 notunuzu giriniz");
            vize2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            //Vizeler toplam puanımızın %40ını,Final ise %60ını oluşturur.
            vizelersonhali = (vize1 + vize2) * 40 / 100;
            finalsonhali = final * 60 / 100;
            anatoplam = vizelersonhali + finalsonhali;
            //durumlarımıza şart koyuyoruz
            if (anatoplam >= 50)
            {
                Console.WriteLine("\n" + anatoplam + " puan ile geçtiniz");
            }
            else if (anatoplam < 50)
            {
                Console.WriteLine("\n" + anatoplam + " puan ile geçemediniz");
            }

            Console.ReadLine(); //kodumuz kapanmasın diye kullanıyoruz
        }
    }
}
