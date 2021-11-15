using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace BIL372Proje
{
    public class DataAccess
    {
        public List<Kullanicilar> GetKullanicilar(string Name)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
            {
                var output = connection.Query<Kullanicilar>($"select * from Kullanicilar").ToList();
                return output;
            }
        }
    
    

    }
}
       
