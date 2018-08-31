namespace GameStore.Application.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class ShoppingCart
    {
        public const string SessionKey = "%^Current_Shopping_Cart^%";

        public List<int> ProductIds { get; private set; } = new List<int>();

        public void RemoveProducts()
        {
            this.ProductIds = new List<int>();
        }
    }
}
