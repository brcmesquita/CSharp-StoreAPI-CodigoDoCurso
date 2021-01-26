using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public Products Product { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
    }
}