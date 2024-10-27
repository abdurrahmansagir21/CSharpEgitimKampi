using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud -- create, read, update, delete
            Console.WriteLine("***** Menü Sipariş İşlem Sayfası *****");
            Console.WriteLine("---------------------------------------\n");


            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into Tbl_Category(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //Console.Write("Eklemek istediğiniz ürünün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek istediğiniz ürünün fiyatı: ");
            //productPrice = Decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS; initial catalog=EgitimKampiDb;" +
            //    " integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into Tbl_Product(ProductName,ProductPrice,ProductStatus) values(@p1,@p2,@p3)",
            //    connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün başarıyla eklendi.");
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS; initial catalog=EgitimKampiDb;" +
            //   " integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From Tbl_Product",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();            
            #endregion

            #region Ürün Silme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS; initial catalog=EgitimKampiDb;" +
            //    " integrated security=true;");

            //Console.Write("Silinecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete From Tbl_Product Where ProductId=@prtId", connection);
            //cmd.Parameters.AddWithValue("@prtId", productId);
            //cmd.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Başarıyla silindi");
            #endregion

            #region Ürün Güncelleme İşlemi
            SqlConnection connection = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS; initial catalog=EgitimKampiDb;" +
                " integrated security=true;");

            Console.Write("Güncellenecek ürün Id girin: ");
            int productid = int.Parse(Console.ReadLine());

            Console.Write("yeni ürün adı girin: ");
            string productname = Console.ReadLine();

            Console.Write("yeni ürün fiyatı girin: ");
            decimal productprice = decimal.Parse(Console.ReadLine());



            connection.Open();
            SqlCommand command = new SqlCommand("Update Tbl_Product Set ProductName=@pname,ProductPrice=@pprice where ProductId=@pid", connection);
            command.Parameters.AddWithValue("@pname", productname);
            command.Parameters.AddWithValue("@pprice", productprice);
            command.Parameters.AddWithValue("@pid", productid);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme başarılı.");
            #endregion

            Console.Read();

        }
    }
}
