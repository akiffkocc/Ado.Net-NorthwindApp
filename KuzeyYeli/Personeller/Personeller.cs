using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personeller
{
    public class Personeller
    {
        public static DataTable Listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Excel File=Personeller.xlsx;");
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from [$Sayfa1]", baglanti);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            return dt;
        }
    }
}
