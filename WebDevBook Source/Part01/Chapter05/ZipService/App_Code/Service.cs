using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public Addresses GetAddress(string strZIP)
    {
        AddressDataSetTableAdapters.AddressTableAdapter da =
          new AddressDataSetTableAdapters.AddressTableAdapter();
        AddressDataSet.AddressDataTable dt = da.GetData(strZIP);

        Addresses addrs = new Addresses();
        foreach (AddressDataSet.AddressRow row in dt.Rows)
        {
            // Create a new Address object
            Address addr = new Address();

            // Assign the new address information
            addr.AddressID = row.AddressID;
            addr.AddressLine1 = row.AddressLine1;
            addr.City = row.City;
            addr.PostalCode = row.PostalCode;

            // Add to the list
            addrs.Add(addr);
        } // foreach

        return addrs;
    }
    
}
