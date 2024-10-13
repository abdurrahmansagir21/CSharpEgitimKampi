using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "İstanbul";
            //cities[2] = "Hatay";
            //cities[3] = "Bursa";
            //cities[4] = "Malatya";
            //Console.WriteLine(cities[5]);

            //int [] numbers = new int[10];
            //numbers[0] = 23;
            //numbers[1] = 2123;
            //numbers[2] = 32;
            //numbers[3] = 954;
            //numbers[7] = 303;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "prag", "roma", "paris", "atina", "ankara" };
            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "yeşil", "beyaz", "siyah" };
            ////colors.Length = 5 < olduğu için 5 dahil değil.
            ////0, 1, 2, 3, 4
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 123, 43, 45, 21, 9, 34, 56, 78, 92, 333 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 23, 47, 124, 543, 1111, 424, 1, 40, 73 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region Dizi Metotları
            //string[] people = { "ali", "veli", "ahmet", "ayşe", "eren" };
            //Console.WriteLine(people.Length);

            //int[] numb = { 21, 2, 33, 44, 15, 56, 79, 87, 91 };
            //Array.Sort(numb);
            //for (int i = 0; i < numb.Length; i++) 
            //{
            //    Console.WriteLine(numb[i]);
            //}

            //int[] numbers = { 1, 2, 21, 35, 234, 22, 442 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "ahmet", "merve", "deha" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numb = {21,43,4567,43567,32,465,22,52,56,1,2,-876 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numb.Max());
            //Console.WriteLine("Dizinin en küçük elemanı: " + numb.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"{i + 1}. şehri girin: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("------------");
            //for (int j = 0; j < cities
            //    .Length; j++)
            //{
            //    Console.WriteLine(cities[j]);
            //}

            //int[] numb = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numb.Length; i++)
            //{
            //    sum += numb[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 22, 3, 14, 5, 11, 12, 4, 13, 43, 33, 44 };
            Array.Sort(numbers);
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("------------");
            Console.WriteLine("Tek Sayılar");
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 != 0)
                {
                    Console.WriteLine(numbers[j]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
