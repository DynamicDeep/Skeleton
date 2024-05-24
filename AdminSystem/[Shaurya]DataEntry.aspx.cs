using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Initialize any data or settings when the page first loads
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear all the textboxes
        txtStaffId.Text = string.Empty;
        txtStaffName.Text = string.Empty;
        txtStaffAddress.Text = string.Empty;
        txtStaffEmail.Text = string.Empty;
        txtStaffPhoneNumber.Text = string.Empty;
        txtStaffPosition.Text = string.Empty;

        // Clear any error messages
        lblError.Text = string.Empty;
        chkAgree.Checked = false;
    }

    protected void btnNoSubmit_Click(object sender, EventArgs e)
    {
        // This button does not submit the form, but might be used to show a message
        lblError.Text = "Form submission was cancelled.";
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();

        // Capture the StaffId
        aStaff.StaffId = int.Parse(txtStaffId.Text);

        // Capture the StaffName
        aStaff.StaffName = txtStaffName.Text;

        // Capture the StaffAddress
        aStaff.StaffAddress = txtStaffAddress.Text;

        // Capture the StaffEmail
        aStaff.StaffEmail = txtStaffEmail.Text;

        // Capture the StaffPhoneNumber
        aStaff.StaffPhoneNumber = int.Parse(txtStaffPhoneNumber.Text);

        // Capture the Staff Position
        aStaff.PositionId = int.Parse(txtStaffPosition.Text);

        // Store the staff object in the session
        Session["aStaff"] = aStaff;
        // Redirect to [Shaurya]Viewer.aspx
        Response.Redirect("[Shaurya]Viewer.aspx", true);
    }

    private bool ValidateForm()
    {
        // Clear previous error messages
        lblError.Text = string.Empty;

        // Check if all required fields are filled
        if (string.IsNullOrWhiteSpace(txtStaffId.Text))
        {
            lblError.Text = "Staff ID is required.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtStaffName.Text))
        {
            lblError.Text = "Staff Name is required.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtStaffAddress.Text))
        {
            lblError.Text = "Staff Address is required.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtStaffEmail.Text))
        {
            lblError.Text = "Staff Email is required.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtStaffPhoneNumber.Text))
        {
            lblError.Text = "Staff Phone Number is required.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtStaffPosition.Text))
        {
            lblError.Text = "Staff Position is required.";
            return false;
        }

        if (!chkAgree.Checked)
        {
            lblError.Text = "You must agree to the terms and conditions.";
            return false;
        }

        // Additional validation can be added here (e.g., email format, phone number format)

        // If we reached here, all validations passed
        return true;
    }
}
