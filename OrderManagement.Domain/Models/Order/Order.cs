namespace OrderManagement.Domain.Models.Order;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
    public OrderStatus Status { get; set; }
    public required List<OrderItem> OrderItems { get; set; }
    
    private Order() {} // For persistence

    public Order(Guid customerId, DateTime orderDate, decimal totalPrice, OrderStatus status)
    {
        
    }
}