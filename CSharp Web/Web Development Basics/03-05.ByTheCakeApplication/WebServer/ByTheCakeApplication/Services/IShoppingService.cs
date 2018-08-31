namespace WebServer.ByTheCakeApplication.Services
{
    using System.Collections.Generic;
    using ViewModels.Shopping;

    public interface IShoppingService
    {
        void CreateOrder(int userId, IEnumerable<int> productIds);

        IEnumerable<OrderListingViewModel> OrdersByUser(int userId);

        OrderDetailsViewModel GetOrderDetails(int id);
    }
}
