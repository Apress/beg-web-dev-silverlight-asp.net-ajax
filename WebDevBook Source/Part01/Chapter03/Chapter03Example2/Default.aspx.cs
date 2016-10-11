using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strFirst = txtFirst.Text;
        string strSecond = txtSecond.Text;
        string strOperation = Request.Form["optOperation"];
        if (strFirst == "")
            strFirst = "0";
        if (strSecond == "")
            strSecond = "0";

        int nF = Convert.ToInt16(strFirst);
        int nS = Convert.ToInt16(strSecond);
        int nR = 0;
        if (strOperation == "Add")
            nR = nF + nS;
        else
            nR = nF - nS;

        litResult.Text = nR.ToString();
    }
}
