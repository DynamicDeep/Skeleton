using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int Price { get; set; }
        public int CustomerId { get; set; }
        public double TotalCost { get; set; }
        public string OrderNotes { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}