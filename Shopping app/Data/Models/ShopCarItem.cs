using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Data.Models
{
    public class ShopCarItem
    {
        public int id { get; set; }
        public int CarID { get; set; }

        public int price { get; set; }

        public string ShopCartId { get; set; }

        public virtual Car car { get; set; }
    }
}
