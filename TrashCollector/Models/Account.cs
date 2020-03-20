using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Account
    {
<<<<<<< HEAD
        public int AccountId { get; set; }
        public int Balance { get; set; }
=======
        [Key]
        public int AccountId { get; set; }
        public decimal Balance { get; set; }

>>>>>>> eb5413e08e1886fbe0b7f3b72a86df44676c3447
    }
}
