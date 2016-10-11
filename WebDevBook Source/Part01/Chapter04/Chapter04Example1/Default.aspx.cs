using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strParamZIP = "";
        if (Request.Params["ZIP"] == null)
            strParamZIP = "98011";
        else
            strParamZIP = Request.Params["ZIP"];

            
        string connectionString = WebConfigurationManager.ConnectionStrings["AW"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionString);
        SqlCommand sqlComm = new SqlCommand();
        sqlComm.Connection = sqlCon;
        sqlComm.CommandType = CommandType.Text;
        sqlComm.CommandText = "SELECT * FROM Person.Address WHERE (PostalCode = @strZIP)";
        sqlComm.Parameters.Add("@strZIP", strParamZIP);

        StringBuilder strReturn = new StringBuilder();
        sqlCon.Open();
        SqlDataReader sRead = sqlComm.ExecuteReader();
        while (sRead.Read())
        {
            strReturn.Append("<li>");
            strReturn.Append(sRead["AddressLine1"]);
            strReturn.Append("</li>");
        }
        lblVersion.Text = strReturn.ToString();
        
        sqlCon.Close();


    }
}
