using System;
using System.ComponentModel.DataAnnotations;


namespace MvcEL6Validation.Validators
{
    [System.AttributeUsage(System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public sealed class CustomStringPatternAttribute : RegularExpressionAttribute
    {
        const string RegEx = "[0][0-9a-z]{5,20}";

        public CustomStringPatternAttribute()
            : base(RegEx)
        {
        }
    }
}

