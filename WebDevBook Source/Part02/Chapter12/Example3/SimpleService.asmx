<%@ WebService Language="C#" Class="SimpleService" %>

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Script.Services;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class SimpleService  : System.Web.Services.WebService {

    [WebMethod]
    public int AddEm(int x, int y) {
        return x+y;
    }
    
}

