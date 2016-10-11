using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Script.Services;


/// <summary>
/// Summary description for DataService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class DataService : System.Web.Services.WebService {

    public DataService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string GetCountryForRegion(string strRegion)
    {
        string strReturn = "";
        string connectionString = WebConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionString);
        SqlCommand sqlComm = new SqlCommand();
        sqlComm.Connection = sqlCon;
        sqlComm.CommandType = CommandType.Text;
        sqlComm.CommandText = "SELECT * FROM Person.CountryRegion WHERE (CountryRegionCode = @strCRC)";
        sqlComm.Parameters.Add("@strCRC", strRegion);

        sqlCon.Open();
        SqlDataReader sRead = sqlComm.ExecuteReader();
        while (sRead.Read())
        {
            strReturn = sRead["Name"].ToString();
        }
        sqlCon.Close();
        return strReturn;

    }
}

