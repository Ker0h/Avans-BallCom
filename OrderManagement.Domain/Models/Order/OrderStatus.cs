namespace OrderManagement.Domain.Models.Order;

public enum OrderStatus
{
    Placed,
    Confirmed,
    BeingDelivered,
    Delivered,
    Cancelled
}