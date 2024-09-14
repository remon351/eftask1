using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskef.models
{
    internal class Sale
    {

        public int Id { get; set; }
        public DateTime date { get; set; }
        public Product product { get; set; }
        public Customer customer { get; set; }
        public Store store { get; set; }
        public int Productid { get; set; }
        public int Customerid { get; set; }
        public int Storeid { get; set; }
    }
}
