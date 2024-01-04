using System.ComponentModel.Design;
using System.Data;
using System.Threading.Channels;

namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere yazılsın:");
            //byte tekrar=byte.Parse(Console.ReadLine());

            //for (int i = 0; i < tekrar; i++) 
            //{
            //    Console.WriteLine($"{i+1}.{isim}");
            //}



            //Console.WriteLine("Aralığın birinci sayısını giriniz:");
            //int sayı1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Aralığın ikinci sayısını giriniz:");
            //int sayı2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sayılar tek mi olsun çift mi:");
            //string cevap =Console.ReadLine().ToLower();


            //if (sayı1 > sayı2)
            //{
            //    int temp = sayı1;
            //    sayı1 = sayı2;
            //    sayı2 = temp;

            //}
            //int sonuc = 0;


            //for (int i = sayı1; i <= sayı2; i++)
            //{
            //    //    if (i % 2 == 0 && cevap == "çift")
            //    //    {
            //    //        Console.WriteLine(i);
            //    //        sonuc += i;
            //    //    }
            //    //    else if (i % 2 == 1 && cevap == "tek")
            //    //    {

            //    //        Console.WriteLine(i);
            //    //        sonuc += i;
            //    //    }

            //    if (i % 2 == (  cevap == "tek"?1:0))
            //    {
            //        Console.WriteLine(i);
            //        sonuc += i;
            //    }

            //}

            //Console.WriteLine($"Sayıların toplamı{sonuc}");

            //Console.WriteLine("Taban degeri giriniz:");
            //int tab=int.Parse(Console.ReadLine());
            //Console.WriteLine("üs  degeri giriniz:");
            //int us = int.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 0; i < us; i++)
            //{
            //    sonuc = sonuc * tab;
            //}
            //Console.WriteLine(sonuc);


            //Console.WriteLine("Bir sayı giriniz");
            //int sayi=int.Parse(Console.ReadLine());

            //int sayac = 0;

            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("asal değil");
            //}
            //else if (sayi<2)
            //{
            //    Console.WriteLine("En küçük asal sayı 2 dir");
            //}

            //else
            //{
            //    for (int i = 2; i <= (sayi / 2); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac == 0 ? "Asal sayıdır" : "Asal sayı değildir");
            //}

            //for (; ; )//sonsuz döngü
            //{
            //    Console.WriteLine("Kullanıcı adınızı giriniz");
            //    string user= Console.ReadLine();
            //    Console.WriteLine("şifrenizi giriniz");
            //    string pass= Console.ReadLine();

            //    if (pass =="123" && user =="admin") 
            //    {
            //        Console.WriteLine("Giriş başarılı");
            //        break;
            //    }
            //}

            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi=int.Parse(Console.ReadLine());
            //    toplam += 0;
            //    sayac++;
            //    if (sayi>max) 
            //    {
            //       max= sayi;
            //    }


            //    Console.WriteLine("Devam etmek istiyormusunuz:E/H ");
            //    string cevap = Console.ReadLine();

            //    if (cevap == "h")
            //    {
            //        break;
            //    }
            //    else if (cevap == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("hatalı giriş yaptınız!");
            //    }


            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max}\n Sayıların toplamı: {toplam}\n Sayıların aritmetik ortalaması:{toplam/sayac}");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++) 
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write($"*\t ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Enter row caunt:");
            //int row=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column caunt:");
            //int column = int.Parse(Console.ReadLine());

            //for (int i = 0; i < row; i++) 
            //{
            //    for (int j = 0; j <column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //   Console.WriteLine();
            //}

            //bool control = false;
            //for (int a = 1; a <=9 ; a++)
            //{
            //    for (int b = 0; b <=9 ; b++)
            //    {
            //        for (int c = 0; c <=9 ; c++)
            //        {
            //            for (int d = 0; d <=9 ; d++)
            //            {
            //                if (1000*a+100*b+10*c+d==4*(1000 * d + 100 * c + 10 * b + a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    control = true;
            //                    break;
            //                }
            //             }
            //            if (control==true)
            //            {
            //                break;
            //            }
            //        }
            //        if (control == true)
            //        {
            //            break;
            //        }
            //    }
            //    if (control == true)
            //    {
            //        break;
            //    }
            //}

            //for (int a = 1; a <=50 ; a++) 
            //{
            //    for (int  b= 1; b <50 ; b++)
            //    {
            //        for (int c = 1; c <50; c++)
            //        {
            //            if (a*a+b*b==c*c)
            //            {
            //                Console.WriteLine($"{a}-{b}-{c}");
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Enter starting number:");
            //int start=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number:");
            //int end=int.Parse(Console.ReadLine());



            //for(int i=start; i<=end; i++)
            //{
            //    int count = 0;
            //   for(int j=2; j<=(i/2); j++) 
            //   {
            //        if (i%j==0)                    
            //        {
            //            count++;
            //            break;
            //        }                  
            //   }
            //    Console.WriteLine(count == 0 ? $"{i}-Is prime" : $"{i}-Is not prime");

            //}
            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += 0;
            //    sayac++;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }


            //    Console.WriteLine("Devam etmek istiyormusunuz:E/H ");
            //    string cevap = Console.ReadLine();

            //    if (cevap == "h")
            //    {
            //        break;
            //    }
            //    else if (cevap == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("hatalı giriş yaptınız!");
            //    }


            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max}\n Sayıların toplamı: {toplam}\n Sayıların aritmetik ortalaması:{toplam / sayac}");


            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //string cevap;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += 0;
            //    sayac++;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }


            //    Console.WriteLine("Devam etmek istiyormusunuz:E/H ");
            //     cevap = Console.ReadLine();

            //} while (cevap=="e");
            //Console.WriteLine($"Girilen en büyük sayı:{max}\n Sayıların toplamı: {toplam}\n Sayıların aritmetik ortalaması:{toplam / sayac}");

            //for (int i = 0; i <10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Random rnd = new Random();
            //        int number = rnd.Next(33, 127);
            //        Console.Write((char)number);
            //    }
            //    Console.WriteLine();
            //}


            //Random rnd = new Random();
            //int number=rnd.Next(0,10);

            //while(true)
            //{
            //    Console.WriteLine("Guess the number:");
            //    int tahmin=int.Parse(Console.ReadLine());
            //    if (tahmin==number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try again:");
            //    }
            //}


            //Console.WriteLine("Menüden bir aralık seçiniz."); 
            //Console.WriteLine();
            //Console.WriteLine("1. aralık 1-50 puan=30");
            //Console.WriteLine("2. aralık 51-100 puan=60");
            //Console.WriteLine("3. aralık 101-150 puan=100");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Seçiminiz:...");
            //string menu=Console.ReadLine();

            //Random rnd = new Random();
            //int cnumber = 0;

            //if (menu=="1")
            //{
            //   cnumber= rnd.Next(1, 50);

            //    Console.WriteLine("Seçiminiz 1-50.");
            //    Console.WriteLine();
            //    Console.WriteLine("lütfen bir sayı tutunuz ve hazır olduğunuzda giriş yaparak deneyiniz:...");

            //}
            //else if (menu=="2")
            //{
            //    cnumber = rnd.Next(51, 100);
            //    Console.WriteLine("Lütfen 51-100 arasında bir sayı giriniz");
            //}
            //else if (menu=="3")
            //{
            //    cnumber = rnd.Next(101, 150);
            //    Console.WriteLine("Lütfen 101-150 arasında bir sayı giriniz");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen geçerli bir sayı seçiniz.");
            //}

            //int counter_limit = 0;
            //bool go=true;
            //while (go)
            //{
            //    counter_limit++;
            //    if (counter_limit > 3) 
            //    {
            //        Console.WriteLine("Hakkınız doldu. Tekrar deneyiniz.");
            //        break;
            //    }
            //    Console.WriteLine("Tuttuğunuz sayı...?");
            //    int userinput = int.Parse(Console.ReadLine());
            //    if (userinput == cnumber) 
            //    {
            //        go = false;
            //        Console.WriteLine("Tebrikler  :)");
            //    }



            //}
            Console.WriteLine("Bir aralık seçiniz:\n1. 1-10 arası \n2. 10-30 arası \n3. 30-100 arası");
            int aralik = int.Parse(Console.ReadLine());

            if (aralik == 1)
            {
                Console.WriteLine("You have 5 rights to guess!");
                
                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                //Console.WriteLine(number);
                int counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Guess the number:");
                    int tahmin = int.Parse(Console.ReadLine());
                    counter++;
                    if (tahmin == number)
                    {
                        Console.WriteLine("You won!");
                        break;    
                    }                    
                    else if (counter<5) 
                    {
                        Console.WriteLine("Try again:");
                    }

                    else if (counter == 5)
                    {
                        Console.WriteLine("Your right has expired!");
                        break;
                    }

                }


            }
            if (aralik == 2)
            {
                Console.WriteLine("You have 7 rights to guess!");

                Random rnd = new Random();
                int number = rnd.Next(10,30);
                Console.WriteLine(number);
                int counter = 0;
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Guess the number:");
                    int tahmin = int.Parse(Console.ReadLine());
                    counter++;
                    if (tahmin == number)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                    else if (counter < 7)
                    {
                        Console.WriteLine("Try again:");
                    }

                    else if (counter == 7)
                    {
                        Console.WriteLine("Your right has expired!");
                        break;
                    }

                }


            }
            if (aralik == 3)
            {
                Console.WriteLine("You have 10 rights to guess!");

                Random rnd = new Random();
                int number = rnd.Next(30,100);
                Console.WriteLine(number);
                int counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Guess the number:");
                    int tahmin = int.Parse(Console.ReadLine());
                    counter++;
                    if (tahmin == number)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                    else if (counter < 10)
                    {
                        Console.WriteLine("Try again:");
                    }

                    else if (counter == 10)
                    {
                        Console.WriteLine("Your right has expired!");
                        break;
                    }

                }


            }




            //Ascii  

            //ödev
            //seviye(hak sayısı verin)
            //puan

        }
    }
}