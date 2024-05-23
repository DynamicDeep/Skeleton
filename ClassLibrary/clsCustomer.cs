using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private readonly int _customerID;
        private string _customerName;
        private string _customerEmail;
        private string _customerPhone;
        private DateTime _customerDateOfBirth;
        private string _customerGender;
        private DateTime _dateOfSubscription;
        public string Gender;
        public DateTime registration;
        public string EmailAddress;
        public DateTime DateOfBirth;
        public int phoneNumber;

        public int CustomerID => _customerID;

        public string CustomerName
        {
            get => _customerName;
            set => _customerName = value;
        }

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
        public int InteractionId { get; set; }

        public clsCustomer(int customerID)
        {
            _customerID = customerID;
        }

        public clsCustomer()
        {
        }

        public bool Find(int customerId)
        {
            if (customerId == _customerID)
            {
                _customerName = "John Doe";
                _customerEmail = "john.doe@example.com";
                _customerPhone = "1234567890";
                _customerDateOfBirth = Convert.ToDateTime("01/01/1980");
                _customerGender = "Male";
                _dateOfSubscription = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}




