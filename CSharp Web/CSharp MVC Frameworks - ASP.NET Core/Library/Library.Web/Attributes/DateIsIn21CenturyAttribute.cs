namespace Library.Web.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DateIsIn21CenturyAttribute : ValidationAttribute
    {
        public DateIsIn21CenturyAttribute() : base("Start date must be after 1 January 2000")
        {
        }

        public DateIsIn21CenturyAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override bool IsValid(object value)
        {
            return (DateTime)value >= new DateTime(2000, 1, 1);
        }
    }
}
