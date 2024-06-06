using System;
using ClassLibrary;

public partial class CustomerAdd : System.Web.UI.Page
{
    private CustomerManager customerManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        customerManager = new CustomerManager();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        DateTime regDate;
        DateTime dob;

        Customer customer = new Customer
        {
            CustomerName = txtCustomerName.Text,
            Emailaddress = txtEmailaddress.Text,
            PhoneNumber = txtPhoneNumber.Text,
            RegistrationDate = DateTime.TryParse(txtRegistrationDate.Text, out regDate) ? (DateTime?)regDate : null,
            Dateofbirth = DateTime.TryParse(txtDateofbirth.Text, out dob) ? (DateTime?)dob : null,
            Gender = txtGender.Text
        };

        customerManager.AddCustomer(customer);
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
