using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeView
    {
        public Employee Employee { get; set; }
        public List<Customer> Customer { get; set; }
    }
}
