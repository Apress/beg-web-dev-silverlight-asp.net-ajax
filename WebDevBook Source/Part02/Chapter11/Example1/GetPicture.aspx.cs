using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.SqlClient;

public partial class GetPicture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int picID;
        if (Request.Params["PicID"] != null)
            picID = Convert.ToInt16(Request.Params["PicID"]);
        else
            picID = 100;

        string connectionString = WebConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        string sql = "Select * from Production.ProductPhoto where ProductPhotoID=@ID";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.Add("@ID", picID);
        con.Open();
        SqlDataReader sqlRead = cmd.ExecuteReader();

        if (sqlRead.Read())
        {
            MemoryStream mems = new MemoryStream();
            BinaryWriter binw = new BinaryWriter(mems);
            byte[] bits = (byte[])sqlRead["LargePhoto"];
            binw.Write(bits);
            Bitmap b = new Bitmap(mems);
            sqlRead.Close();
            con.Close();
            Response.ContentType = "image/jpeg";
            //Response.Write(b);
            b.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
        else
        {
            Response.Write("No image found");
        }
    }
}
