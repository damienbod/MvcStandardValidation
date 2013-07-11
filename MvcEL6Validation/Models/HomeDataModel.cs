using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEL6Validation.Validators;

namespace MvcStandardValidation.Models
{
    public class Enums
    {
        public enum ApplicationStatus
        {
            Pending = 0,
            Submitted = 1,
            Disapproved = 2,
            Approved = 3
        }
    }


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

        [Range(10.0, 100.0)]
        public double? ValDouble2 { get; set; }

        public DateTime ValDateTime1 { get; set; }

        public DateTime? ValDateTime2 { get; set; }

        public SelectList ApplicationStatus { get; set; }

        [Required]
        public int SelectedApplicationStatus { get; set; }

        [RequiredIf("SelectedApplicationStatus",
            (int)Enums.ApplicationStatus.Submitted,
            (int)Enums.ApplicationStatus.Approved,
            (int)Enums.ApplicationStatus.Disapproved, ErrorMessage = "The Application Submission Date is required")]
        public DateTime? ApplicationSubmitted { get; set; } 
    }
}