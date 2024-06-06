using System;
using ClassLibrary;

public partial class CustomerFind : System.Web.UI.Page
{
    private CustomerManager customerManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        customerManager = new CustomerManager();
    }

    protected void btnFindCustomer_Click(object sender, EventArgs e)
    {
        int customerId;
        if (int.TryParse(txtCustomerId.Text, out customerId))
        {
            Customer customer = customerManager.GetCustomerById(customerId);
            if (customer != null)
            {
                lblResult.Text = string.Format(
                    "ID: {0}, Name: {1}, Email: {2}, Phone: {3}, Registration Date: {4}, DOB: {5}, Gender: {6}",
                    customer.CustomerID,
                    customer.CustomerName,
                    customer.Emailaddress,
                    customer.PhoneNumber,
                    customer.RegistrationDate.HasValue ? customer.RegistrationDate.Value.ToString("yyyy-MM-dd") : "N/A",
                    customer.Dateofbirth.HasValue ? customer.Dateofbirth.Value.ToString("yyyy-MM-dd") : "N/A",
                    customer.Gender
                );
            }
            else
            {
                lblResult.Text = "Customer not found.";
            }
        }
        else
        {
            lblResult.Text = "Invalid Customer ID.";
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
