using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public DateTime CreatedAt { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public string Status { get; set; }
    }
}