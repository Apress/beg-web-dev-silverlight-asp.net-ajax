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

namespace Example1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateAnswer()
        {
            int nA = Convert.ToInt16(TextBox1.Text);
            int nB = Convert.ToInt16(TextBox2.Text);
            int nC = nA * nB;
            lblAnswer.Text = nC.ToString();

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateAnswer();

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            CalculateAnswer();
        }
    }
}
