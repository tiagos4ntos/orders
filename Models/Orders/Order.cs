using System.Collections.Generic;

namespace blog.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
    }
}