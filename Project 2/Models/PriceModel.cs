using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_2.Models {
    public class PriceModel {
        [Required(ErrorMessage = "Please enter a valid subtotal.")]
        [Range(1, 1000000, ErrorMessage = "Please enter a number between 1 and 1 million.")]
        public double? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percentage.")]
        [Range(1, 100, ErrorMessage = "Please enter a number between 1 and 100.")]
        public double? DiscountPercent { get; set; }
        public double DiscountAmount { get; set; } = 0;
        public double Total { get; set; } = 0;
        public double DiscountAmountCalculator(double sub, double percent) => DiscountAmount = (sub * percent) / 100;
        public double TotalCalculator(double s, double da) => Total = s - da;

    }
}
