using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class MultiplyAJAXServer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int nX = 0;
        int nY = 0;
        try
        {
            nX = Convert.ToInt16(Request.Params["nx"]);
            nY = Convert.ToInt16(Request.Params["ny"]);
        }
        catch (Exception ex)
        {
            nX = 0;
            nY = 0;
        }
        int nAns = nX * nY;
        Response.Write(nAns);
    }
}
