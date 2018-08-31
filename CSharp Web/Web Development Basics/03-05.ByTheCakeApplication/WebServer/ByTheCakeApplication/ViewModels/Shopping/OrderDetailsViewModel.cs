namespace WebServer.ByTheCakeApplication.ViewModels.Shopping
{
    using System;
    using System.Collections.Generic;

    public class OrderDetailsViewModel
    {
        public int Id { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }

        public DateTime CreatedOn { get; set; }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
