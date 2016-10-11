using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Address
/// </summary>
public class Address
{
	public string AddressLine1 = String.Empty;
    public string City = String.Empty;
    public string PostalCode = String.Empty;
    public int AddressID = -1;
}

public class Addresses : List<Address>
{
}
