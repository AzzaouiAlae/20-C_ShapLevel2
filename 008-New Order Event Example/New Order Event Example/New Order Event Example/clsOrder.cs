using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Order_Event_Example
{
    public class NewOrderEventArgs(int orderID, decimal totalPrice, string productName) : EventArgs
    {
        public int OrderID { get; } = orderID;
        public decimal TotalPrice { get; } = totalPrice;
        public string ProductName { get; } = productName;
        
    }
    public class ClsOrder
    {
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }

        static public event EventHandler<NewOrderEventArgs>? OrderChanged;

        public ClsOrder(int orderID, decimal totalPrice, string productName) 
        {
            OrderID = orderID;
            TotalPrice = totalPrice;
            ProductName = productName;
                    
            OrderChanged?.Invoke(this, new NewOrderEventArgs(OrderID, TotalPrice, ProductName));            
        }
    }
}
