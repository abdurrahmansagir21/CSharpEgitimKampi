using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 yıldız çizimi
            //for(int i =1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız çizimi
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region 10 satır ve her satırda 10 yıldız çizimi
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik Üçgen
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Dik Üçgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Yarım Elmas
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 5; k >= 0; k--)
            //{
            //    for (int x = 0; x <= k; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi
            ////üst kısım
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //soldan 4 karakter boşluk
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //boşluk sonrası yıldız 
            //    for (int k = 1; k <= 2 * i - 1; k++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////alt kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--) 
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluk
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit
            int m = 5;
            for (int i = m; i >= 1; i--)
            {
                //boşluk
                for (int j = m - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.Read();
        }
    }
}
