using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskef.models
{
    internal class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sale> sales { get; set; }
    }
}
