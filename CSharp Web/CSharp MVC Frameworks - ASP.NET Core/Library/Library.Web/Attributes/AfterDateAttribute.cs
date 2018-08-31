namespace Library.Web.Attributes
{
    using System.ComponentModel.DataAnnotations;
    using System;

    public class AfterDate : ValidationAttribute
    {
        private readonly string otherDateName;

        public AfterDate(string otherDateName)
        {
            this.otherDateName = otherDateName;
            this.ErrorMessage = "Start date must be before the end date!";
        }

        public AfterDate(string otherDateName, string errorMessage) : base(errorMessage)
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var otherProperty = validationContext.ObjectInstance.GetType().GetProperty(this.otherDateName);
            var otherPropertyValue = (DateTime?)otherProperty.GetValue(validationContext.ObjectInstance, null);

            if(otherPropertyValue == null)
            {
                return ValidationResult.Success;
            }

            DateTime dtThis = Convert.ToDateTime(value);
            DateTime dtOther = Convert.ToDateTime(otherPropertyValue);

            if (dtThis <= dtOther)
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
