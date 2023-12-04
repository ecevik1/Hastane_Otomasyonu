using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_Hastane
{
     class DbManager
    {
        public SqlConnection baglanti()
        {
         
            SqlConnection connector = new SqlConnection("Data Source=Erenay;Initial Catalog=HastaneVeriTabani;Integrated Security=True");
            connector.Open();
            return connector;
            
        }

    }
}
