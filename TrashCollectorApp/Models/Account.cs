using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorApp.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }

        public double Balance { get; set; }

        [Display(Name = "One Day Pickup")]
        public string OneDayPickup { get; set; }

        [Display(Name = "Suspend Pickup")]
        public bool SuspendPickup { get; set; }

        [Display(Name = "Start Pickup Date")]
        public string StartPickupDate { get; set; }

        [Display(Name = "End Pickup Date")]
        public string EndPickupDate { get; set; }

    }
}
