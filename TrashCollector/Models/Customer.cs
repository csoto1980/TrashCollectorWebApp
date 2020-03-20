using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
<<<<<<< HEAD:TrashCollector/Models/Customer.cs
=======
        [Key]
>>>>>>> eb5413e08e1886fbe0b7f3b72a86df44676c3447:TrashCollectorProject1/Models/Customer.cs
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [ForeignKey("Account")]
<<<<<<< HEAD:TrashCollector/Models/Customer.cs
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [ForeignKey("Pickup")]
        public int PickupId { get; set; }
=======
        public string AccountId { get; set; }
        public Account Account { get; set; }

        [ForeignKey("Pickup")]
        public string PickupId { get; set; }
>>>>>>> eb5413e08e1886fbe0b7f3b72a86df44676c3447:TrashCollectorProject1/Models/Customer.cs
        public Pickup Pickup { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
