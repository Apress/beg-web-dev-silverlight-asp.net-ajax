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

namespace Example2
{
    public partial class AddWIthUpdatePanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(txtA.Text);
            int b = Convert.ToInt16(txtB.Text);
            int c = a + b;
            lblAns.Text = c.ToString();
        }
    }
}
