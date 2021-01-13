using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyAutomation
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-3DCNI3I\SQLEXPRESS;Initial Catalog=TicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
