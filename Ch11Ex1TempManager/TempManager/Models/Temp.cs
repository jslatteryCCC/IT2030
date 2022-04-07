using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A date must be entered for each record.")]
        [Remote("CheckDate", "Validation")]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "A low temperature must be entered for each record.")]
        [Range(-200, 200, ErrorMessage = "Temperature must be between -220 and +200.")]
        public double? Low { get; set; }

        [Required(ErrorMessage = "A high temperature must be entered for each record.")]
        [Range(-200, 200, ErrorMessage = "Temperature must be between -220 and +200.")]
        public double? High { get; set; }
    }
}
