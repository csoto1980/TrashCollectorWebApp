using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorApp.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Weekly Pickup Day")]
        public DayOfWeek PickupDay { get; set; }

        [Display(Name = "One Day Pickup")]
        public DayOfWeek OneDayPickup { get; set; }

        [Display(Name = "Suspend Pickup")]
        public bool SuspendPickup { get; set; }

        [Display(Name = "Start Pickup Date")]
        public DateTime StartPickupDate { get; set; }

        [Display(Name = "End Pickup Date")]
        public DateTime EndPickupDate { get; set; }

        [Display(Name = "Pickup Charge")]

        public double PickupCharge { get; set; }

        public double Balance { get; set; }

        [Display(Name = "Pickup Complete")]
        public bool PickupComplete { get; set; }

    }
}
