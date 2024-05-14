using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int phoneNumber;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime registration { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int InteractionId { get; set; }
    }
}