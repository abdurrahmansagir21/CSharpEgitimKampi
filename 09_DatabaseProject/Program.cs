using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net C# dilinde SQL yapılarını kullanmamızı sağlayan kütüphane
            Console.WriteLine("***** C# Veri Tabanlı Ürün*Kategori Bilgi Sistemi *****\n\n");

            string tableNumber;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS; initial Catalog" +
                " =EgitimKampiDb; integrated security=true;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Tbl_Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            connection.Close();
            Console.Read();
        }
    }
}
