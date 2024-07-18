using System;

namespace array_dizi_tek_ve_cift_sayilar_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n degerini giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Dizi().Olustur(n);

            Dizi dizi = new Dizi();

            int[] tekSayilarDizisi = dizi.TekDiziOlustur(X);
            Dizi.Yazdir(tekSayilarDizisi);
            Console.WriteLine("Tek sayilarin sayisi:{0,5}", dizi.TekSayilarinSayisi(X));

            int[] ciftSayilarDizisi = dizi.CiftDiziOlustur(X);
            Dizi.Yazdir(ciftSayilarDizisi);
            Console.WriteLine("Çift sayilarin sayisi:{0,5}", dizi.CiftSayilarinSayisi(X));




        }
    }
}
