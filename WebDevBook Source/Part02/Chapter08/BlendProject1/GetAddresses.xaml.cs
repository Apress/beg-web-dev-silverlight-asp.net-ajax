using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Xml;

namespace BlendProject1
{
	public partial class GetAddresses
	{
		public GetAddresses()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}
        public void Handle_Click(Object obj, RoutedEventArgs e)
        {

            string strZIP = tZIP.Text;
            AddressService.Service d = new AddressService.Service();
            XmlNode xNode = d.GetAddresses(strZIP);
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement xDocEl = xmlDoc.CreateElement("DocumentElement");
            xDocEl.InnerXml = xNode.InnerXml;
            xmlDoc.AppendChild(xDocEl);
            LayoutRoot.DataContext = xNode.InnerXml;
            
        }
	}
}