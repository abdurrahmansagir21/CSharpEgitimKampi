using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // 4 parametre alır. foreach(1,2,3,4)
            // 1: değişken türü
            // 2: değişken adı
            // 3: in komutu
            // 4: liste, koleksiyon veya dizinin adı

            //string[] cities = { "adana", "bursa", "hatay", "bilecik" };
            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 23, 45, 65, 222, 52343, 11 };
            //Array.Sort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 12, 234, 43, 123, 45, 77, 65, 98, 67, 78, 0 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 12, 1000, 234, 43, 123, 45, 77, 65, 98, 67, 78, 0 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total+= i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,8,
            //};

            //foreach (int i in numbers) { Console.WriteLine(i); }

            //string word = "Merhaba";
            //foreach(char x in word)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması\n\n\n\n");
            Console.WriteLine("--------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması {studentExamAvg[i]}");

                //geçip kalma durumu
                if (studentExamAvg[i] <= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                Console.WriteLine("---------------------------------------");

            }
            #endregion

            Console.Read();
        }
    }
}