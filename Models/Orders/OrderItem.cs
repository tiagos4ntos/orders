namespace blog.Models.Orders
{
    public class OrderItem
    {   
        public int Id { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
    }
}