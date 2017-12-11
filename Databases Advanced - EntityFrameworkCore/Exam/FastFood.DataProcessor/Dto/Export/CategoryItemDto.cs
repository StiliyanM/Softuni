using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Export
{
    [XmlType("MostPopularItem")]
    public class CategoryItemDto
    {
        public string Name { get; set; }

        public decimal TotalMade { get; set; }

        public int TimesSold { get; set; }
    }
}