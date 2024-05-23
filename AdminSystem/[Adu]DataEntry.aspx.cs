using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            // Create a new instance of clsCustomer
            clsCustomer customer = new clsCustomer();
            // Capture the customer details
            customer.CustomerID = Convert.ToInt32(txtCustomerId.Text);
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerEmail = txtCustomerEmail.Text;
            customer.CustomerPhone = txtCustomerPhone.Text;  // Changed to string to match clsCustomer
            customer.DateOfSubscription = Convert.ToDateTime(txtCustomerSubscriptionDate.Text);
            customer.DateOfBirth = Convert.ToDateTime(txtCustomerDOB.Text);
            customer.Gender = radioCustomerGender.SelectedValue;  // Changed to string to match clsCustomer

            // Store the customer in the session object
            Session["Customer"] = customer;
            // Navigate to the viewer page
            Response.Redirect("[Adu]Viewer.aspx");
        }
        catch (FormatException ex)
        {
            // Handle format exceptions
            ErrorMessage.Text = "Invalid input format: " + ex.Message;
        }
        catch (Exception ex)
        {
            // Handle any other potential exceptions
            ErrorMessage.Text = "Error: " + ex.Message;
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear all the textboxes and reset the radio button list
        txtCustomerId.Text = "";
        txtCustomerName.Text = "";
        txtCustomerEmail.Text = "";
        txtCustomerPhone.Text = "";
        txtCustomerSubscriptionDate.Text = "";
        txtCustomerDOB.Text = "";
        radioCustomerGender.ClearSelection();
    }
}
