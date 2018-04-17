using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Models
{
    using Contracts;
    using System.Globalization;

    public class SimpleLayout : ILayout
    {
        const string DateFormat = "M/d/yyyy h/m/ss tt";

        public string GetLayout(IError error)
        {
            var dateString = error.Time.ToString(DateFormat, CultureInfo.InvariantCulture);

            return $"{dateString} - {error.Level} - {error.Message}";
        }
    }
}
