using System;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd =new Random();
           int random= rnd.Next(0,20);
           baslik:

           Console.WriteLine("------------SAYI TAHMİN OYUNUMUZA HOŞGELDİNİZ------------");
            yeniden:
           Console.WriteLine("Tahmininizi giriniz: (Lütfen (0-20) arası bir tahmin yapınız.)");
           int tahmin=Convert.ToInt32(Console.ReadLine());
           int hak=0;
         

           if (tahmin>random)
           {
            hak++;
            Console.WriteLine("Lütfen daha küçük bir tahmin yapınız...");
            goto yeniden;


           }
           else if(tahmin<random)
           {
             hak++;
            Console.WriteLine("Lütfen daha büyük bir tahmin yapınız...");
            goto yeniden;
           }

           else
           {
             hak++;
            Console.WriteLine("---------*TEBRİKLER DOĞRU TAHMİN YAPTINIZ*-------------");

           }
           if(hak==3)
           {
            Console.WriteLine("TAHMİN HAKKINIZ DOLDU LÜTFEN TEKRAR BAŞLAMAK İÇİN 'S' TUŞUNA BASINIZ: ");
            char secenek=Convert.ToChar(Console.ReadLine());
            if(secenek == 's' )
            {

        goto baslik;

            }
           }
         





        }
    }
}
