using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEvent
{
    public class OrderCreatedEventArgs(int OrderID, decimal TotalPrice, string ProductName) : EventArgs
    {
        public int OrderID { get; } = OrderID;
        public decimal TotalPrice { get; } = TotalPrice;
        public string ProductName { get; } = ProductName;
    }
    public class ClsOrder
    {
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }

        static public event EventHandler<OrderCreatedEventArgs>? OnOrderCreated;

        public ClsOrder(int orderID, decimal totalPrice, string productName)
        {
            OrderID = orderID;
            TotalPrice = totalPrice;
            ProductName = productName;

            OnOrderCreated?.Invoke(this, new OrderCreatedEventArgs(orderID, totalPrice, productName));
        }
    }
}
