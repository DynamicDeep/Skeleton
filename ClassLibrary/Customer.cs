using System;

namespace ClassLibrary
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Emailaddress { get; set; }
        public string PhoneNumber { get; set; }  // Ensure PhoneNumber is string
        public DateTime? RegistrationDate { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Gender { get; set; }
    }
}
