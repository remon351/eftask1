using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskef.models
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public ICollection<Sale> sales { get; set; }
        public string Description { get; set; }
    }
}
