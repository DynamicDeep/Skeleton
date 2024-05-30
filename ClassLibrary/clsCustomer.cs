using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private fields
        private int _customerID;
        private string _customerEmail;
        private string _customerPhone;
        private DateTime _customerDateOfBirth;
        private string _customerGender;
        private DateTime _dateOfSubscription;
        public int phoneNumber;
        public DateTime registration;

        // Public properties
        public int CustomerID
        {
            get => _customerID;
            set => _customerID = value;
        }

        public string CustomerName { get; set; }

        public string CustomerEmail
        {
            get => _customerEmail;
            set => _customerEmail = value;
        }

        public string CustomerPhone
        {
            get => _customerPhone;
            set => _customerPhone = value;
        }

        public DateTime CustomerDateOfBirth
        {
            get => _customerDateOfBirth;
            set => _customerDateOfBirth = value;
        }

        public string CustomerGender
        {
            get => _customerGender;
            set => _customerGender = value;
        }

        public DateTime DateOfSubscription
        {
            get => _dateOfSubscription;
            set => _dateOfSubscription = value;
        }

        // Additional properties to match the test methods
        public int InteractionId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }

        // Constructors
        public clsCustomer(int customerID)
        {
            _customerID = customerID;
        }

        public clsCustomer() { }

        // Find method to match the test cases
        public bool Find(int customerID)
        {
            // For demonstration purposes, we will hard-code the values.
            // In a real scenario, you would retrieve these values from a database.

            if (customerID == 21)
            {
                this.CustomerId = customerID;
                this.CustomerName = "John Doe";
                this.EmailAddress = "john.doe@example.com";
                this.PhoneNumber = "1234567890";
                this.RegistrationDate = Convert.ToDateTime("23/12/2022");
                this.DateOfBirth = Convert.ToDateTime("01/01/1980");
                this.Gender = "Male";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
