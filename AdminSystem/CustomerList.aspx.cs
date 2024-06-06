using System;
using System.Data;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerList : System.Web.UI.Page
{
    private CustomerManager customerManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        customerManager = new CustomerManager();
        if (!IsPostBack)
        {
            LoadCustomers();
        }
    }

    private void LoadCustomers()
    {
        gvCustomers.DataSource = customerManager.GetAllCustomers();
        gvCustomers.DataBind();
    }

    protected void gvCustomers_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvCustomers.EditIndex = e.NewEditIndex;
        LoadCustomers();
    }

    protected void gvCustomers_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = gvCustomers.Rows[e.RowIndex];
        int customerId = Convert.ToInt32(gvCustomers.DataKeys[e.RowIndex].Value);
        string customerName = (row.Cells[1].Controls[0] as TextBox).Text;
        string email = (row.Cells[2].Controls[0] as TextBox).Text;
        string phoneNumber = (row.Cells[3].Controls[0] as TextBox).Text;

        DateTime registrationDate;
        if (!DateTime.TryParse((row.Cells[4].Controls[0] as TextBox).Text, out registrationDate))
        {
            registrationDate = DateTime.MinValue;
        }

        DateTime dateOfBirth;
        if (!DateTime.TryParse((row.Cells[5].Controls[0] as TextBox).Text, out dateOfBirth))
        {
            dateOfBirth = DateTime.MinValue;
        }

        string gender = (row.Cells[6].Controls[0] as TextBox).Text;

        Customer customer = new Customer
        {
            CustomerID = customerId,
            CustomerName = customerName,
            Emailaddress = email,
            PhoneNumber = phoneNumber,
            RegistrationDate = registrationDate,
            Dateofbirth = dateOfBirth,
            Gender = gender
        };

        customerManager.UpdateCustomer(customer);
        gvCustomers.EditIndex = -1;
        LoadCustomers();
    }

    protected void gvCustomers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvCustomers.EditIndex = -1;
        LoadCustomers();
    }

    protected void gvCustomers_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int customerId = Convert.ToInt32(gvCustomers.DataKeys[e.RowIndex].Value);
        customerManager.DeleteCustomer(customerId);
        LoadCustomers();
    }

    protected void btnAddCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerAdd.aspx");
    }
    protected void btnFindCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerFind.aspx");
    }
   
    protected void btnFilterCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerFilter.aspx");
    }


}
