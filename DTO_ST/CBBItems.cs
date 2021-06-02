using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    class CBBItems
    {
       public int value { get; set; }
       public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
