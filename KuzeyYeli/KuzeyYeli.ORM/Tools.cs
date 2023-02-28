using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace KuzeyYeli.ORM
{
    internal class Tools
    {
		private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);

		public static SqlConnection Baglanti
		{
			get { return baglanti; }
			set { baglanti = value; }
		}

		public static bool ExecuteNonQuery (SqlCommand komut)
		{
            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();
            }
        }
        public static DataTable Listele(string procedureName)
        {
            SqlDataAdapter adb = new SqlDataAdapter(procedureName, Tools.Baglanti);
            adb.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adb.Fill(dt);
            return dt;
        }
	}
}
