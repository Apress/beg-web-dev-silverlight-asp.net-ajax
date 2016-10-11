using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Script.Services;


namespace Example2
{
    /// <summary>
    /// Summary description for AddService
    /// </summary>
    /// 
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class AddService : System.Web.Services.WebService
    {

        [WebMethod]
        public double AddEm(double x, double y)
        {
            return x+y;
        }
    }

}
