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

public partial class MultiplyNumbers : System.Web.UI.Page
{

    protected void btnMult_Click(object sender, EventArgs e)
    {
        int nX = Convert.ToInt16(TextBox1.Text);
        int nY = Convert.ToInt16(TextBox2.Text);
        int nAns = nX * nY;
        lblAnswer.Text = nAns.ToString();
    }

}
