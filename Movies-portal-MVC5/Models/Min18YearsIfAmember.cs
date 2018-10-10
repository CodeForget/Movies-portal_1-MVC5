using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies_portal_MVC5.Models
{
    public class Min18YearsIfAmember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId==MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Bithday == null)
                return new ValidationResult("Birth Date Is Required.");
            var age = DateTime.Now.Year - customer.Bithday.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer Should be 18 Years Old");

              
        }
    }
}