using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime DateOfSubscription { get; set; }
        public DateTime DateOfBirth { get; set; }  // Ensure this property exists
        public string Gender { get; set; }  // Ensure this property exists

        public string Valid(int orderId, int customerId, int totalCost, string address, string deliveryDate)
        {
            throw new NotImplementedException();
        }
    }
}
