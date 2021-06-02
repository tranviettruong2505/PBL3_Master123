using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_BookShopManagement.DTO
{
    class StaffView
    {
        public int ID_Staff { get; set; }
        public string Name_Staff { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public int ID_User { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NamePosition { get; set; }
    }
}
