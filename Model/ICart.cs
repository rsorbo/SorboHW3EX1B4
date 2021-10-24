using System.Collections.Generic;

namespace HW3EX1B4.Model
{
    public interface ICart
    {
        string CustomerEmail { get; set; }
        IEnumerable<OrderItem> Items { get; set; }
        decimal TotalAmount { get; set; }
    }
}