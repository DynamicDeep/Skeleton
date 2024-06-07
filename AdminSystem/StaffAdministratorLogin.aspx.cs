using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffAdministratorLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffUser AnUser = new clsStaffUser();
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(UserName, Password);
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password";
        }
        else if (Found == true)
        {
            Response.Redirect("[Shaurya]List.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are incorrect! please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}