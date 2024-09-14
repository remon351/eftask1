using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskef.models
{
    internal class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string CreaditCardNumber { get; set; }
        public ICollection<Sale> sales { get; set; }
    }
}
