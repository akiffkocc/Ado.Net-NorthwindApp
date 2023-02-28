using KuzeyYeli.ORM.Entity;
using System.Data;
using System.Data.SqlClient;

namespace KuzeyYeli.ORM.Facade
{
    public class Products
    {
        public static DataTable Listele()
        {
            return Tools.Listele("UrunListele");
        }
        public static bool Ekle(Product entity)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@a", entity.ProductName);
            komut.Parameters.AddWithValue("@f", entity.UnitPrice);
            komut.Parameters.AddWithValue("@s", entity.UnitInStock);

           return Tools.ExecuteNonQuery(komut);
        }
        public static bool Sil(Product entity)
        {
            SqlCommand komut = new SqlCommand("UrunSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.ProductId);
            return Tools.ExecuteNonQuery (komut); 
        }
        public static bool Guncelle(Product entity)
        {
            SqlCommand komut = new SqlCommand("UrunGuncelle",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@a", entity.ProductName);
            komut.Parameters.AddWithValue("@f", entity.UnitPrice);
            komut.Parameters.AddWithValue("@s",entity.UnitInStock);
            komut.Parameters.AddWithValue("@id", entity.ProductId);

            return Tools.ExecuteNonQuery(komut);
        }
    }
}
