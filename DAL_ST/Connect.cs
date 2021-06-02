using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    class Connect
    {
        string constr; 
        public Connect()
        {
            constr = " Data Source = LAPTOP-IMN5TH1T\\SQLEXPRESS; Initial Catalog = PBL3; Integrated Security = true ";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(constr);
        }
    }
}