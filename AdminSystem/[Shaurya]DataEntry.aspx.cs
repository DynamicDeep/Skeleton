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
        clsStaff AStaff = new clsStaff();

        // Capture and parse StaffId
        int staffId;
        if (int.TryParse(txtStaffId.Text, out staffId))
        {
            AStaff.StaffId = staffId;
        }
        else
        {
            // Handle the case where StaffId is not a valid integer
            // Return or show an error message
            Response.Write("Invalid Staff ID.");
            return;
        }

        // Capture the StaffName
        string StaffName = txtStaffName.Text;

        // Capture the StaffAddress
        string StaffAddress = txtStaffAddress.Text;

        // Capture the StaffEmail
        string StaffEmail = txtStaffEmail.Text;

        // Capture the StaffPhoneNumber
        string StaffPhoneNumber = txtStaffPhoneNumber.Text;

        // Capture and parse PositionId
        int PositionId;
        if (int.TryParse(txtStaffPosition.Text, out PositionId))
        {
            // Variable to store any error message
            string Error = "";

            // Validate the data
            Error = AStaff.Valid(PositionId, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            if (Error == "")
            {
                // Assign values to AStaff object
                AStaff.PositionID = PositionId;
                AStaff.StaffName = StaffName;
                AStaff.StaffEmail = StaffEmail;
                AStaff.StaffAddress = StaffAddress;
                AStaff.StaffPhoneNumber = Convert.ToInt32(StaffPhoneNumber);

                // Store the staff object in the session
                Session["AStaff"] = AStaff;

                // Redirect to [Shaurya]Viewer.aspx
                Response.Redirect("[Shaurya]Viewer.aspx", true);
            }
            else
            {
                // Display validation errors
                Response.Write(Error);
            }
        }
        else
        {
            // Handle the case where PositionId is not a valid integer
            // Return or show an error message
            Response.Write("Invalid Position ID.");
        }
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance for class
        clsStaff AStaff = new clsStaff();
        //create a variable to store a primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffName.Text = AStaff.StaffName;
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStaffEmail.Text = AStaff.StaffEmail;
            txtStaffPhoneNumber.Text = AStaff.StaffPhoneNumber.ToString();
            txtStaffPosition.Text = AStaff.PositionID.ToString();
        }
    }

    protected void chkAgree_CheckedChanged(object sender, EventArgs e)
    {

    }
}
