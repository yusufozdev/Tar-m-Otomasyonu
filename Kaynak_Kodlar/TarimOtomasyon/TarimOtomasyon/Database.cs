using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace TarimOtomasyon
{
    class Database
    {
        public static SqlConnection Baglanti()
        {

            string baglantiSatiri = ConfigurationManager.ConnectionStrings["toVeritabani"].ConnectionString;
            

            return new SqlConnection(baglantiSatiri);
        }
    }
}
