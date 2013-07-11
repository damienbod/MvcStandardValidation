﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcEL6Validation.Validators;

namespace MvcStandardValidation.Models
{
    public class HomeDataModel
    {
        [Required]
        [Range(5,30)]
        public int ValInt1 { get; set; }

        public int? ValInt2 { get; set; }

        [CustomStringPattern]
        public string ValString1 { get; set; }

        [Required(ErrorMessage = "string2 is required")]
        public string ValString2 { get; set; }

        public double ValDouble1 { get; set; }

        public double? ValDouble2 { get; set; }

        public DateTime ValDateTime1 { get; set; }

        public DateTime? ValDateTime2 { get; set; }
    }
}