using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Gazi.KararYapilariApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //int s1 = 5;
            //int s2 = 10;

            //if (1!=1)
            //{
            //    Console.WriteLine("Gazi");
            //}
            //else
            //{
            //    Console.WriteLine("Üniversitesi");
            //}

            //Console.WriteLine("Birinci sayıyı giriniz:");
            //byte sayı1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz:");
            //byte sayı2 = byte.Parse(Console.ReadLine());

            //if (sayı1 > sayı2)
            //{
            //    Console.WriteLine("Birinci sayı büyüktür");

            //}
            //else if(sayı2 > sayı1)
            //{
            //    Console.WriteLine("İkinci sayı büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşeit");
            //}


            //Console.WriteLine("Dil seçiniz / Select Language:(TR,EN)");
            //string dil=Console.ReadLine().ToUpper();
            //string msg1= "1. sayıyı giriniz ", msg2=" 2.sayıyı giriniz", msg3= "İşlem seçiniz", msg4= "İşlemin sonucu", msg5= "Hatalı karakter girdiniz.";
            //if (dil == "EN")
            //{
            //    msg1 = "Enter the 1st number:";
            //    msg2 = " Enter the 2nd number:";
            //    msg3 = "please select transaction:";
            //    msg4 = "result of transaction:";
            //    msg5 = "İncorrect Operation selected!";
            //}
            //Console.WriteLine("1. sayıyı giriniz ");
            //double sayı1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı giriniz ");
            //double sayı2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("İşlem seçiniz (+,*,/,-)");
            //char islem = char.Parse(Console.ReadLine());
            //string msg = "İşlemin sonucu :";

            //if (dil == "TR" )
            //{
            //    if (islem == '+')
            //    {
            //        Console.WriteLine($"{msg}{sayı1 + sayı2}");

            //    }

            //    else if (islem == '-')
            //    {
            //        Console.WriteLine($"{msg}{sayı1 - sayı2}");
            //    }

            //    else if (islem == '/')
            //    {
            //        Console.WriteLine($"{msg}{sayı1 / sayı2}");
            //    }
            //    else if (islem == '*')
            //    {
            //        Console.WriteLine($"{msg}{sayı1 * sayı2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı karakter girdiniz.");
            //    }


            //    Console.ReadKey();
            //}


            // Console.WriteLine("Hava nasıl:(kötü/iyi)");
            // string durum = Console.ReadLine().ToLower();

            // if (durum == "kötü")
            // {
            //     Console.WriteLine("DIŞARI ÇIKMA");
            // }
            // else if(durum =="güzel")
            // {
            //     Console.WriteLine("DIŞARI ÇIK");

            // }
            // else 
            // {
            //     Console.WriteLine("Hatalı işlem yaptınız.");
            // }

            //Console.ReadKey(); 
            #endregion


            #region trycatch
            //try
            //{
            //    Console.WriteLine("Hava nasıl:(kötü/güzel)");
            //    string durum = Console.ReadLine().ToLower();

            //    if (durum == "kötü")
            //    {
            //        Console.WriteLine("DIŞARI ÇIKMA");

            //    }
            //    else if (durum == "güzel")
            //    {

            //        Console.WriteLine("Kaç derece?");
            //        sbyte derece = sbyte.Parse(Console.ReadLine());

            //        if (derece < 15)
            //        {
            //            Console.WriteLine("soğuk evde otur.");
            //        }
            //        else if (derece >= 15 && derece > 35)
            //        {
            //            Console.WriteLine("Hava güzel dışarı çık.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hava sıcak evde otur.");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı işlem yaptınız.");
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz?");
            //    byte sayı1 = byte.Parse(Console.ReadLine());

            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Sayı ile giriş yapınız.");
            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("0-255 arası değer giriniz.");
            //}

            //catch (Exception ex)
            //{

            //    Console.WriteLine("Bir hata oluştu.");
            //    Console.WriteLine($"Hata Detayları:\n Tarih Saat:{DateTime.Now}\n Hata Mesajı{ex.Message}\n Stack Trace:{ex.StackTrace}");
            //}

            // Exception handling 
            #endregion

            Console.WriteLine("Bir sayı giriniz");
            byte sayi = byte.Parse(Console.ReadLine());
            if (sayi == 1)
            {
                Console.WriteLine("Bir");

            }
            else if (sayi == 2)
            {
                Console.WriteLine("İki");

            }
            else if (sayi == 3)
            {
                Console.WriteLine("Üç");

            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    break;





            }

        }
    }
}
