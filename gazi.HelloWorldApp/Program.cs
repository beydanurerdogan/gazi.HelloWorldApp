namespace gazi.HelloWorldApp
{
    internal class Program
    {
        static int oyuncusayı = 50;
        static void Main(string[] args)
        {
            #region Değişken Tanımlamaları
            //Referans tipi (Referance type) - HEAP Bölgesi
            //string isim ="BEYDA"
            ////Değer tipi(Value Taype)-STACE
            //int sayı = 50;
            //byte number = 50;
            //byte a;
            //double d;
            //a = 30;
            //d = 40;
            //Console.WriteLine(sayı);
            //Console.WriteLine(number);
            //Console
            //byte a = 30,b;
            //b = 40;
            // const olan değişkenler sonradan değiştirilemez.
            //int number = 50;
            //Console.WriteLine(number);
            //number = 100;
            //Console.WriteLine(number); 
            #endregion

            #region String biçimlendirme
            //string isim = "Ahmet", soyad = "Mehmet";
            //Console.WriteLine("Merhaba " + isim + " " + soyad);
            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}");


            #endregion





            //TÜR Dönüşümleri (Type Casting)

            //byte sayı = 50;
            //int number = sayı; //Implicit Typ Casting
            // Küçük türden büyük türe yapılan dönüşümler otomatik olarak gerçekleştirilir.

            //checked
            //{
            //    int sayı = 20;
            //    byte number = (byte)sayı;//Explicit Type Casting 
            //    Console.WriteLine(number);
            //}
            //RİSK
            //Büyük türden -> Küçük türe
            //Veri kaybı ihtimali!

            Console.ReadKey();

        }
    }

}
//8bit = Byte
//1024byte = 1 Kilobyte(KB)
//1024KB = 1 Megabyte(MB)


// Namespace: İçinde classları bulunduran yapılardır.
// {}: Block Yapısı(Scope)
// Class: İçinde metodları bulunduran yapılardır.
// Metod: İş yapan kod bloklarıdır.
// Mein Metodu: Consol uygulamalarının giriş noktasıdır.
// Syntax: Kod yazım kuralları
// Derleme(Compile): C#->Buil->MS-IL(exe)->Runtime->Makina Dili(0 1)
// Ctrl+B: Derleme kısayolu
// Ctrl+K+D: Parantezleri düzeltir.
// Ctrl+K+C: Yorum satırı haline getirir.
// Ctrl+K+U: Yorum olan kodlarıeski haline çevirir.
// */ /*: Arasındaki kodlar yorum satırı olur.
// IntelliSense: Kod yazım yardımcısı.
// Solution: İçerisinde bir yada birden fazla proje bulunduran yapılardır.Projelerin disk üzerinde kayıtlı olduğu yer bilgisini tutar.
// .Net
// Microsoft tarafından geliştirilen bir yazılım grliştirme platformudur.(Framework)
// .Net Bileşenleri
// 1- Programlama dilleri C# -VB-F#
// 2- Editörler:Visual studio-Visual studio code
// 3- Kütüphaneler:Namespace
// 4- Runtime
// .Net ile Yapılabilecekler
// 1- Desktop Application (Console,windows,form app)
// 2- Web Aplication
// 3- Mobile Aplication (Android-IOS)
// 4- Game Development:Unity
// 5- IoT:Internet Of Things:Akıllı Cihazlar
// 6- AI: Yapay zeka
