using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string sName = Request.Form[txtSearch.UniqueID];
        string sId = Request.Form[hfId.UniqueID];

        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Customer ID: " + sId + ", Customer Name: " + sName + "');", true);
    }
}