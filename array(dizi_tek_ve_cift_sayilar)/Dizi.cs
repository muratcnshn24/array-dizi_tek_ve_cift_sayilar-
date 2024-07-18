using System;
using System.Collections.Generic;
using System.Text;

namespace array_dizi_tek_ve_cift_sayilar_
{
    class Dizi
    {
        ///<sammary>
        /// tek boyutlu dizi oluşturmak için kullanılan fonksiyondur.
        ///</sammary>
        ///<param name="Limit"> dizinin uzunluğunu belirtir </param>
        ///<returns> belirtilen uzunlukta rastgele sayıyılardan oluşmuş diziyi döner  </returns>
        public int[] Olustur(int Limit)
        {
            int[] sayilar = new int[Limit];
            Console.WriteLine("");
            for (int i = 0; i < Limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.WriteLine("{0,3}", sayilar[i]);
            }
            Console.WriteLine(""); // dizi karakterleri yan yana yazılsın diye alt ve üste bu kısmı yazıp diziyi  araya aldım
            return sayilar;

        }

        ///<sammary>
        ///  Parametre olarak aldığı dizideki en büyük elemanı döner.
        ///</sammary>
        ///<param name="Dizi"> Dizi </param>
        ///<returns></returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb) eb = dizi[i];

            }
            return eb;
        }

        ///<sammary>
        ///  Parametre olarak aldığı dizideki en küçük elemanı döner.
        ///</sammary>
        ///<param name="Dizi"> Dizi </param>
        ///<returns></returns>
        public static int EnKucuk(int[] dizi)                  //statik yaparsan nesne üretmene gerek kalmaz
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek) ek = dizi[i];

            }
            return ek;
        }
        ///<sammary>
        /// ParametrE olarak aldığı dizinin aritmetik ortalamasını hesaplar ve döner.
        ///</sammary>
        ///<param name="X">Dizi</param>
        ///<returns>Aritmetik Ortalama</returns>

        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length; i++)
            {
                toplam += X[i];
            }
            return toplam / X.Length;
        }


        ///<sammary>
        ///  Parametre olarak aldığı dizinin standar sapmasini hesaplar.
        ///</sammary>
        ///<param name="X"> Dizi </param>
        ///<returns>Standart Sapma</returns>

        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);
            double t = 0, f = 0;

            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2);             //Pow üst alma fonksiyonudur.



            }
            return Math.Sqrt(t / (X.Length - 1)); // Sqrt karakök fonksiyonu.
        }



        ///<sammary>
        ///  Bir dizideki tek sayıların tek sayısını döner.
        ///</sammary>
        ///<param name="X"> X </param>
        ///<returns>Sonuç: Tek sayıların sayısını</returns>
        public int TekSayilarinSayisi(int[] X)
        {
            int tekSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                    tekSayilarinSayisi++; // tek sayilarin sayisini 1 artırabiliriz

            }

            return tekSayilarinSayisi;
        }


        ///<sammary>
        ///  Bir dizideki çift sayıların tek sayısını döner.
        ///</sammary>
        ///<param name="X"> X </param>
        ///<returns>Sonuç: Çift sayıların sayısını</returns>
        public int CiftSayilarinSayisi(int[] X)
        {
            int ciftSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                    ciftSayilarinSayisi++; // cift sayilarin sayisini 1 artırabiliriz

            }

            return ciftSayilarinSayisi;
        }

        ///<sammary>
        ///  Bir dizideki tek sayıların yeni bir dizi olusturur.
        ///</sammary>
        ///<param name="X"> Dizi </param>
        ///<returns>Tek Sayılardan oluşan Diziyi temsil eder.</returns>
        public int[] TekDiziOlustur(int[] X)
        {
      
            int[] tekDizi = new int[TekSayilarinSayisi(X)];     // [] bu dizi demek.
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i]%2==1)
                {
                    tekDizi[y] = X[i];
                    y++;    //y değerini bir artır demek
                }
          
            }
            return tekDizi;
           
        }

        ///<sammary>
        ///  Bir dizideki Çift sayıların yeni bir dizi olusturur.
        ///</sammary>
        ///<param name="X"> Dizi </param>
        ///<returns>Çift Sayılardan oluşan Diziyi temsil eder.</returns>
        public int[] CiftDiziOlustur(int[] X)
        {

            int[] ciftDizi = new int[CiftSayilarinSayisi(X)];     // [] bu dizi demek.
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;    //y değerini bir artır demek
                }

            }
            return ciftDizi;

        }
        /// <summary>
        /// Parametre olarak aldığı diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)   //X.length dizinin uzunluğu kadar.
            {
                Console.Write("{0,3}",X[i]);
            }
            Console.WriteLine("");
        }
            
    }
}
