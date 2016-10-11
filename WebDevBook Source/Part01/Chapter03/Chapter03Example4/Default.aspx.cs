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
        foreach(Control ctrl in Page.Controls)
        {
            ListBox1.Items.Add(ctrl.GetType().ToString() + ":" + ctrl.ID);
        }

        theHead.Title = "Dynamically Created Title!";

        ListBox newListBox = new ListBox();
        newListBox.Items.Add(new ListItem("Item on my Dynamic List"));
        Page.Form.Controls.Add(newListBox);
        
        newListBox.SelectedIndexChanged += new EventHandler(newListBox_SelectedIndexChanged);
        string strTest1 = "";
        if (Request.Params["test1"] == null)
        {
            strTest1 = Request.Params["test1"];
        }
        else
        {
            strTest1 = "";
        }

        Response.Write("Some Output");
    }
    protected void newListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ListBox theBox = (ListBox)sender;
        String strTest = theBox.SelectedItem.Text;
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
