using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;


namespace dpdrole.Models
{
    public class Models
    {
        // vehicle price
        // deposit amount(minimum 15%)
        // delivery date
        // year(s) finance: 1, 2 or 3
        // arrangement first month add an £88 arrangement fee
        // completion last month add a £20 completion fee

        [Required]
        [Display(Name = "Vehicle price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Deposit amount (minimum 15%)")]
        public int Deposit { get; set; }

        [Required]
        [Display(Name = "Delivery date")]
        public DateTime? DeliveryDate { get; set; }

        [Required]
        [Display(Name = "Years finance")]
        public int Years { get; set; }

        [Required]
        [Display(Name = "Arrangement fee (Added to the first month)")]
        public int Arrangement { get; set; }

        [Required]
        [Display(Name = "Completion fee (Added to the last month)")]
        public int Completion { get; set; }
    }
}