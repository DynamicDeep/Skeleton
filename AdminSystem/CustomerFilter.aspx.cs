using System;
using System.Data;
using ClassLibrary;

public partial class CustomerFilter : System.Web.UI.Page
{
    private CustomerManager customerManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        customerManager = new CustomerManager();
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        string customerName = txtCustomerName.Text;
        string email = txtEmailaddress.Text;
        string phoneNumber = txtPhoneNumber.Text;
        string gender = txtGender.Text;

        DataTable dt = customerManager.FilterCustomers(customerName, email, phoneNumber, gender);
        gvFilteredCustomers.DataSource = dt;
        gvFilteredCustomers.DataBind();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
