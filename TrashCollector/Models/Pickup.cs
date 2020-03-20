using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Pickup
    {
        [Key]
        public int PickupId { get; set; }
        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; } //int?
        
        [Display(Name = "One Day Pickup")]
        public string OneDayPickup { get; set; } //int?
      
        [Display(Name = "Temp Suspend")]
        public bool TempSuspend { get; set; }
       
        [Display(Name = "Start Suspend")]
        public string StartSuspend { get; set; } //int?
       
        [Display(Name = "End Suspend")]
        public string EndSuspend { get; set; } //int?
     
    }
}
