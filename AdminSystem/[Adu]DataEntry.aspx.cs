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
            // Parse the customer ID from the input
            int customerId = int.Parse(txtCustomerId.Text);

            // Create an instance of clsCustomer with the parsed customer ID
            clsCustomer customer = new clsCustomer(customerId)
            {
                CustomerName = txtCustomerName.Text,
                CustomerEmail = txtCustomerEmail.Text,
                CustomerPhone = txtCustomerPhone.Text,
                CustomerDateOfBirth = DateTime.Parse(txtCustomerDOB.Text),
                CustomerGender = radioCustomerGender.SelectedValue,
                DateOfSubscription = DateTime.Parse(txtCustomerSubscriptionDate.Text) // Ensure this field exists and is populated
            };

            // Store the customer in the session object
            Session["Customer"] = customer;
            // Navigate to the viewer page
            Response.Redirect("CustomerViewer.aspx"); // Ensure the URL is correct
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
