using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomerView
    {
        public Customer Customer { get; set; }
        public Pickup Pickup { get; set; }
        public Account Account { get; set; }
    }
}
