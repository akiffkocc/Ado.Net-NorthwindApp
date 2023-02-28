using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using KuzeyYeli.ORM.Entity;

namespace KuzeyYeli.ORM.Facade
{
    public  class Categories
    {
        public static DataTable Listele()
        {
            return Tools.Listele("KategoriListele");
        }
        public static bool Ekle(Category entity)
        {
            SqlCommand komut = new SqlCommand("KategoriEkle",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@a", entity.CategoryName);
            komut.Parameters.AddWithValue("@t", entity.Description);
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool Guncelle(Category entity)
        {
            SqlCommand komut = new SqlCommand("KategoriGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@a", entity.CategoryName);
            komut.Parameters.AddWithValue("@t", entity.Description);
            komut.Parameters.AddWithValue("@id", entity.CategoryId);
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool Sil(Category entity)
        {
            SqlCommand komut = new SqlCommand("KategoriSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.CategoryId);
            return Tools.ExecuteNonQuery (komut);
        }
    }
}
