using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_BookShopManagement.DTO
{
    class Account
    {
        public int ID_User { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ID_Position { get; set; }
    }
}
