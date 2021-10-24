using System;
using System.Collections.Generic;

namespace HW3EX1B4.Model
{
    public class Cart : ICart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }

        public string CustomerEmail { get; set; }
    }
}