using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class CustomerManager
    {
        private clsDataConnection connection;

        public CustomerManager()
        {
            connection = new clsDataConnection();
        }

        public void AddCustomer(Customer customer)
        {
            var addConnection = new clsDataConnection();
            addConnection.AddParameter("@CustomerName", customer.CustomerName);
            addConnection.AddParameter("@Emailaddress", customer.Emailaddress);
            addConnection.AddParameter("@PhoneNumber", customer.PhoneNumber);
            addConnection.AddParameter("@RegistrationDate", customer.RegistrationDate);
            addConnection.AddParameter("@Dateofbirth", customer.Dateofbirth);
            addConnection.AddParameter("@Gender", customer.Gender);
            addConnection.Execute("spAddCustomer");
        }

        public void UpdateCustomer(Customer customer)
        {
            var updateConnection = new clsDataConnection();
            updateConnection.AddParameter("@CustomerID", customer.CustomerID);
            updateConnection.AddParameter("@CustomerName", customer.CustomerName);
            updateConnection.AddParameter("@Emailaddress", customer.Emailaddress);
            updateConnection.AddParameter("@PhoneNumber", customer.PhoneNumber);
            updateConnection.AddParameter("@RegistrationDate", customer.RegistrationDate);
            updateConnection.AddParameter("@Dateofbirth", customer.Dateofbirth);
            updateConnection.AddParameter("@Gender", customer.Gender);
            updateConnection.Execute("spUpdateCustomer");
        }

        public void DeleteCustomer(int customerId)
        {
            var deleteConnection = new clsDataConnection();
            deleteConnection.AddParameter("@CustomerID", customerId);
            deleteConnection.Execute("spDeleteCustomer");
        }

        public DataTable GetAllCustomers()
        {
            connection.Execute("spGetAllCustomers");
            return connection.DataTable;
        }

        public Customer GetCustomerById(int customerId)
        {
            var getConnection = new clsDataConnection();
            getConnection.AddParameter("@CustomerID", customerId);
            getConnection.Execute("spGetCustomerById");
            var dt = getConnection.DataTable;

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new Customer
                {
                    CustomerID = Convert.ToInt32(row["CustomerID"]),
                    CustomerName = row["CustomerName"].ToString(),
                    Emailaddress = row["Emailaddress"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    RegistrationDate = row["RegistrationDate"] != DBNull.Value ? (DateTime?)row["RegistrationDate"] : null,
                    Dateofbirth = row["Dateofbirth"] != DBNull.Value ? (DateTime?)row["Dateofbirth"] : null,
                    Gender = row["Gender"].ToString()
                };
            }
            return null;
        }

        public DataTable FilterCustomers(string customerName, string email, string phoneNumber, string gender)
        {
            var filterConnection = new clsDataConnection();
            filterConnection.AddParameter("@CustomerName", customerName);
            filterConnection.AddParameter("@Emailaddress", email);
            filterConnection.AddParameter("@PhoneNumber", phoneNumber);
            filterConnection.AddParameter("@Gender", gender);
            filterConnection.Execute("spFilterCustomers");
            return filterConnection.DataTable;
        }
    }
}
