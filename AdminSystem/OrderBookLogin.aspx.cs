using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsOrderUser AnUser = new clsOrderUser();
        //create the variable to store the username and password
        string userName = txtUsername.Text;
        string password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        userName = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(userName, password);
        //if username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record the error 
            lblError.Text = "Enter a username";

        }
        // if found
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a password";
        }
        // if found
        else if (Found == true)
        {
            //redirect to the List Page
            Response.Redirect("[Jagruti]List.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }


    

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}