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
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string test = System.DateTime.Now.ToString();
        AddressData.Service myData = new AddressData.Service();
        XmlNode myXML = myData.GetAddresses("90210");
        DataSet dst = new DataSet();
        XmlNodeReader r = new XmlNodeReader(myXML);
        dst.ReadXml(r);
        GridView1.DataSource = dst;
        GridView1.DataBind();
    }
}
