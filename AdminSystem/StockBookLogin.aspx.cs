using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStockUser AnUser = new clsStockUser();
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(UserName, Password);
        if(txtUsername.Text == "")
        {
            lblMessage.Text = "Enter a username";
        }
        else if(txtPassword.Text == "")
        {
            lblMessage.Text = "Enter a Password";
        }
        else if (Found == true)
        {
            Response.Redirect("[Deep]List.aspx");
        }
        else if(Found == false)
        {
            lblMessage.Text = "Login Details are incorrect! please try again ";
        }
    }
}