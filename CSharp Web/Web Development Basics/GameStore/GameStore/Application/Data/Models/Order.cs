namespace GameStore.Application.Data.Models
{
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<OrderGame> Games { get; set; } = new List<OrderGame>();
    }
}
