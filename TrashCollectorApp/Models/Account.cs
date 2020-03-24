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

        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }

        [Display(Name = "One Day Pickup")]
        public string OneDayPickup { get; set; }

        [Display(Name = "Suspend Pickup")]
        public bool SuspendPickup { get; set; }

        [Display(Name = "Start Pickup Date")]
        public string StartPickupDate { get; set; }

        [Display(Name = "End Pickup Date")]
        public string EndPickupDate { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal Balance { get; set; }

        [Display(Name = "Pickup Charge")]
        [Column(TypeName = "decimal(4,2)")]
        public decimal PickupCharge { get; set; }


        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")] //Check to see if can format to remove the hour/min
        //@item.CreatedDate.Date.ToShortDateString()

    }
}
