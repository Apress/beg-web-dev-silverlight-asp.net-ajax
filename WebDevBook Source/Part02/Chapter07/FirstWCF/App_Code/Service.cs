using System;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Text;
// A WCF service consists of a contract (defined below as IMyService, DataContract1), 
// a class which implements that interface (see MyService), 
// and configuration entries that specify behaviors associated with 
// that implementation (see <system.serviceModel> in web.config)

[ServiceContract()]
public interface IAddressService
{
    [OperationContract]
    string GetAddresses(string strZIP);
    
}

public class AddressService : IAddressService
{
    public string GetAddresses(string strZIP) 
    {

        string strReturn = "";
        AddressDataTableAdapters.AddressTableAdapter da =
            new AddressDataTableAdapters.AddressTableAdapter();
        AddressData.AddressDataTable dt = da.GetData(strZIP);
        strReturn = FormatDTasXML(dt);
        
        return strReturn;
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

