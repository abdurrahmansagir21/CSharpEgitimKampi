using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //geriye değer döndürmeyen (void) metotlar
            //void customerList()
            //{
            //    Console.WriteLine("Ali Biçim");
            //    Console.WriteLine("Ayşe Çınar");
            //    Console.WriteLine("Mehmet Öztürk");
            //}
            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Stirng Parametreli Metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Ahmet");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Ahmet", "Çınar");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(100, 21, -12);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent:" + capital + " Bayrak rengi: " + flagColor;
            //    return cardInfo;
            //}

            //Console.Write("Ülke adı: ");
            //string x = Console.ReadLine();
            //Console.Write("Başkenti: ");
            //string y = Console.ReadLine();
            //Console.Write("Bayrak rengi: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(12, 220));
            //Console.WriteLine(Sum(3332, 0));
            //Console.WriteLine(Sum(2, 19));
            //Console.WriteLine(Sum(234, 88));
            //Console.WriteLine(Sum(46, 95));

            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + $" adlı öğrenci sınavı geçti. ortalama: {result}";
                }
                else
                {
                    return student+ $" adlı öğrenci başarısız oldu. ortalama: {result}";
                }
            }

            Console.WriteLine(ExamResult("Ali", 100, 10, 60));
            Console.WriteLine(ExamResult("Ayşe", 40, 20, 30));
            #endregion

            Console.Read();
        }
    }
}
