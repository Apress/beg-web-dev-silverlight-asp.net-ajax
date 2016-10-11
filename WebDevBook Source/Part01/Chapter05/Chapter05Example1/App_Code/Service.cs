using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.IO;
using System.Xml;
using System.Text;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public XmlDocument GetAddresses(string strZIP)
    {
        string strReturn = "";
        AddressDataTableAdapters.AddressTableAdapter da =
            new AddressDataTableAdapters.AddressTableAdapter();
        AddressData.AddressDataTable dt = da.GetData(strZIP);
        strReturn = FormatDTasXML(dt);
        XmlDocument xmlReturn = new XmlDocument();
        xmlReturn.LoadXml(strReturn);
        return xmlReturn;
    }

    private string FormatDTasXML(AddressData.AddressDataTable dt)
    {
        MemoryStream memStream = null;
        XmlTextWriter xmlWriter = null;
        try
        {
            memStream = new MemoryStream();
            xmlWriter = new XmlTextWriter(memStream, Encoding.Unicode);
            dt.WriteXml(xmlWriter);
            int count = (int)memStream.Length;
            byte[] arr = new byte[count];
            memStream.Seek(0, SeekOrigin.Begin);
            memStream.Read(arr, 0, count);
            UnicodeEncoding utf = new UnicodeEncoding();
            return utf.GetString(arr).Trim();
            
        }
        catch
        {
            return String.Empty;
        }
        finally
        {
            if (xmlWriter != null) 
                xmlWriter.Close();
        }

    }
    
}
