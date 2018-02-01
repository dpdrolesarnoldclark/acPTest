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
        [MaxLength(5)]
        [Range(0, 99999)]
        [Display(Name = "Vehicle price")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter only numeric number")]
        public int Price { get; set; }

        [Required]
        [MaxLength(5)]
        [Range(0, 99999)]
        [Display(Name = "Deposit amount (minimum 15%)")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter only numeric number")]
        public int Deposit { get; set; }

        [Required]
        [Display(Name = "Delivery date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? DeliveryDate { get; set; }

        [Required]
        [Range(1, 3)]
        [Display(Name = "Years of financing")]
        public int Years { get; set; }

        [Required]
        [MaxLength(3)]
        [Range(0, 999)]
        [Display(Name = "Arrangement fee (Added to the first month)")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter only numeric number")]
        public int Arrangement { get; set; }

        [Required]
        [MaxLength(3)]
        [Range(0, 999)]
        [Display(Name = "Completion fee (Added to the last month)")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Enter only numeric number")]
        public int Completion { get; set; }
    }
}