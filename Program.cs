using System.Security.Cryptography.X509Certificates;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taş Kağıt Makas Oyununa Hoş Geldiniz.");
            Console.WriteLine("v1 - Skorsuz oyun");
            Console.WriteLine("v1 - Skorlu oyun");
            string secimv1 = Console.ReadLine();

            if (secimv1 == "1")
            {
                Console.Clear();

                Console.WriteLine("Aşağıdaki opsiyonlardan birini seçiniz: ");

                string[] opsiyonlar = ["Taş", "Kağıt", "Makas"];
                Random random = new Random();
                int bilgisayarSecimi = random.Next(0, opsiyonlar.Length);

                for (int i = 0; i < opsiyonlar.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + opsiyonlar[i]);
                }

                int oyuncuSecimi = int.Parse(Console.ReadLine()) - 1;

                string sonuc;

                if (oyuncuSecimi == bilgisayarSecimi)
                {
                    sonuc = "Berabere";

                }
                else if ((oyuncuSecimi == 0 && bilgisayarSecimi == 2) || (oyuncuSecimi == 1 && bilgisayarSecimi == 0) || (oyuncuSecimi == 2 && bilgisayarSecimi == 1))
                {
                    sonuc = "Kazandın!";
                }
                else
                {
                    sonuc = "Kaybettin!";
                }

                Console.WriteLine("Oyuncu seçimi: " + opsiyonlar[oyuncuSecimi]);
                Console.WriteLine("Bilgisayar seçimi: " + opsiyonlar[bilgisayarSecimi]);
                Console.WriteLine("Sonuç: " + sonuc);
            }

            if (secimv1 == "2")
            {
                Console.Clear();        

                string[] secenekler = ["Taş", "Kağıt", "Makas"];
                Random random = new Random();
                int bilgisayarSecimi = random.Next(3);
                string oyunSonu = "";

                int oyuncuSkor = 0; 
                int bilgisayarSkor = 0;

                bool bittiMi = true;

                while (bittiMi)
                {
                    Console.WriteLine("Oyunun sonuna ulaşmak için ekrana çıkış yazmanız gerekmektedir.");

                    for (int i = 0; i < secenekler.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "- " + secenekler[i]);
                    }

                    string secim = Console.ReadLine();

                    string sonuc;

                    if (secim == "çıkış")
                    {
                        bittiMi = false;
                        oyunSonu += "Oyun bitti";
                        break;
                    }
                    if ((int.Parse(secim) - 1) == bilgisayarSecimi)
                    {
                        sonuc = "berabere";
                    }
                    else if ((secim == "1" && bilgisayarSecimi == 2) || (secim == "2" && bilgisayarSecimi == 0) || (secim == "3" && bilgisayarSecimi == 1))
                    {
                        sonuc = "kazandın!";
                        oyuncuSkor += 1;
                    }
                    else
                    {
                        sonuc = "kaybettin!";
                        bilgisayarSkor += 1;
                    }
                    Console.Clear();
                    Console.WriteLine("oyuncu seçimi: " + secenekler[int.Parse(secim) - 1]);
                    Console.WriteLine("bilgisayar seçimi: " + secenekler[bilgisayarSecimi]);
                    Console.WriteLine("sonuc: " + sonuc);
                    Console.WriteLine($"Toplam Skor Sen: {oyuncuSkor} Bilgisayar: {bilgisayarSkor}");

                }

                Console.WriteLine(oyunSonu);
            }
        }
    }
}
