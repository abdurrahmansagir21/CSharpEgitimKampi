using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Yapısı
            //girilen değerin istediğimiz değere eşit olup olmadığına bakalım
            //değişkenlerde kullandığımız = işareti atama operatörüdür.
            // == operatörü "eşit mi" anlamına gelir.
            //karar yapılarından sonra ; konulmaz
            // if = eğer
            //else = aksi halde
            //eğer koşul sağlanırsa şifre doğru yazsın. aksi halde şifre yanlış yazsın.

            //Console.Write("Şifre Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış.");
            //}


            // & veya && operatörü iki koşulun da sağlandığı durumu ifade eder.
            // || operatörü veya anlamına gelir.İki koşuldan herhangi biri doğruysa işlem gerçekleşir.
            // != operatörü eşit değildir anlamına gelir. Eğer değer eşit değilse işlem gerçekleşir.
            // == opertörü eşittir anlamına gelir.Değer eşitse işlem gerçekleşir.


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı veri.");
            //}

            //C# büyük-küçük harf duyarlıdır. kullanıcı Ankara yazarsa ekrana hatalı veri çıktısı gelir.

            //int number;
            //Console.Write("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}



            //int exam1, exam2, exam3, average;
            //string result = "";
            //Console.Write("İlk sınav notu: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sınav notu: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü sınav notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average >= 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            // | veya operatörüdür. şartlardan herhangi biri sağlanırsa sorgu gerçekleşir.
            //string city;
            //Console.Write("Lütfen şehir girişi yapınız ");

            //city = Console.ReadLine();
            //if (city == "adana" | city == "hatay" | city == "bursa" | city == "bilecik")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //eşit değildir != operatörü
            //Console.Write("lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz.");
            //}
            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //int number1, number2;
            //Console.Write("İlk sayıyı girin: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayıyı girin: ");
            //number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı girin: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Çift sayı");
            //}
            //else
            //{
            //    Console.WriteLine("Tek sayı");
            //}        
            #endregion

            #region Char Değişkenlerle Karar Yapıları
            //örnek
            //Console.Write("Takımınızın takım sembolünü girin: ");
            //char team = char.Parse(Console.ReadLine());
            //if(team =='g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team== 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("***** C# KAMPI RESTORAN *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string menuItems;
            //Console.Write("Detayını görmek istediğiniz menünün rakamını girin:  ");
            //menuItems = Console.ReadLine();

            //if (menuItems == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Ana Yemekler------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //}

            //if (menuItems == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Çorbalar------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //}

            //if (menuItems == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Pizzalar------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //}

            //if (menuItems == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------İçecekler------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine();
            //}

            //if (menuItems == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Tatlılar------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Künefe");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Kazandibi");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            Console.Write("Ay girişi yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Hatalı giriş."); break;
            }

            #endregion

            #region Switch Case Hesap Makinesi
            int number1, number2, result;
            char symbol;
            Console.Write("Birinci sayı: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayı: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi girin: ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+': result = number1 + number2; Console.WriteLine("Toplam: " + result); break;
                case '-': result = number1 - number2; Console.WriteLine("Fark: " + result); break;
                case '/': result = number1 / number2; Console.WriteLine("Bölüm: " + result); break;
                case '*': result = number1 * number2; Console.WriteLine("Çarpım: " + result); break;
                default: Console.WriteLine("Hatalı giriş"); break;
            }
            #endregion
            Console.Read();

        }
    }
}
