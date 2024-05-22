using System;
using System.Text;
using System.Web.UI;
using ClassLibrary;

public partial class _1Viewer : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Customer"] != null)
        {
            clsCustomer customer = (clsCustomer)Session["Customer"];

            StringBuilder sb = new StringBuilder();
            sb.Append("<div class='info-group'><label>Customer ID:</label> ");
            sb.Append(customer.CustomerID);
            sb.Append("</div>");
            sb.Append("<div class='info-group'><label>Customer Name:</label> ");
            sb.Append(customer.CustomerName);
            sb.Append("</div>");
            sb.Append("<div class='info-group'><label>Email:</label> ");
            sb.Append(customer.CustomerEmail);
            sb.Append("</div>");
            sb.Append("<div class='info-group'><label>Phone:</label> ");
            sb.Append(customer.CustomerPhone);
            sb.Append("</div>");
            sb.Append("<div class='info-group'><label>Date of Subscription:</label> ");
            sb.Append(customer.DateOfSubscription.ToShortDateString());
            sb.Append("</div>");
            sb.Append("<div class='info-group'><label>Date of Birth:</label> ");
            sb.Append(customer.DateOfBirth.ToShortDateString());
            sb.Append("</div>");
            sb.Append("<div class='info-group'><label>Gender:</label> ");
            sb.Append(customer.Gender);
            sb.Append("</div>");

            customerInfo.InnerHtml = sb.ToString();
        }
        else
        {
            customerInfo.InnerHtml = "No customer information available.";
        }
    }
}
