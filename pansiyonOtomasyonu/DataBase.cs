using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pansiyonOtomasyonu
{
   public class DataBase
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3D832UA;Initial Catalog=pansiyon;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
