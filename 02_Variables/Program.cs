using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double  Değişkenler
            double number;
            number = 4.95;
            Console.WriteLine(number);


            //örnek
            Console.WriteLine("**** Fiyat Listesi ****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " TL");
            Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + " TL");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.825;
            potatoGram = 4.594;
            tomatoGram = 3.432;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice +
                " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice +
                " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice +
                " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice +
                " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice +
                " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice
                + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");
            #endregion

            #region Char Değişkenler
            char symbol = 'a';
            Console.WriteLine(symbol);

            //char değişkenlerde a ile A farklıdır
            //char değişkenler '' (tek tırnak) arasında tanımlanır
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity,
                passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş : ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " Yolcu Ad Soyad: " +
                passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tamsayı Girişleri ve Dönüşümler
            //C# programlamada kullanıcıdan alınan, console ekranına girilen tüm değerleri başlangıçta string olarak kabul eder
            //Eğer kullanıcıdan alacağımız veri string türü değilse dönüşüm uygulamalıyız

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Alınan ayakkabı sayısı: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Alınan bilgisayar sayısı: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Alınan sandalye sayısı: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Alınan TV sayısı: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount +
                chairPrice * chairCount + tvPrice * tvCount;

            Console.WriteLine();
            Console.WriteLine("Ödenecek Toplam Tutar: " + totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //Klavyeden girilecek değerde basamaklar virgül ile ayrılmalıdır.

            double exam1, exam2, exam3, result;
            Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter (char) Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz (E-K): ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
