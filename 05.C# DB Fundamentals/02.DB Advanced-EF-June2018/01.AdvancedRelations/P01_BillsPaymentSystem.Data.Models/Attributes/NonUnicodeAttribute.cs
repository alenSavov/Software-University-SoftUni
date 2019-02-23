﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_BillsPaymentSystem.Data.Models.Attributes
{
    public class NonUnicodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string nullErrorMsg = "Value cannot be null!";

            if (value == null)
            {
                return new ValidationResult(nullErrorMsg);
            }

            string text = (string)value;

            string errorMsg = "Value cannot cantains unicode characters";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 255)
                {
                    return new ValidationResult(errorMsg);
                }
            }

            return ValidationResult.Success;
        }
    }
}
