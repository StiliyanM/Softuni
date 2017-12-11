using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Import
{
    [XmlType("Order")]
    public class OrdersDto
    {
        public string Customer { get; set; }

        public string Employee { get; set; }

        public string DateTime { get; set; }

        [Required]
        public string Type { get; set; } = "ForHere";

        public List<OrderItemDto> Items { get; set; }

    }
}
