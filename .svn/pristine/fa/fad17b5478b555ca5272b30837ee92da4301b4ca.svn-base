using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace AccountProfile
{
    public partial class Defauslt2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String xmlText = "";

            Account acc = new Account();
            acc.Address = "dsdsds";
            acc.Country = "india";
            acc.Id = "12312";
            acc.Name = "pravin";
            acc.Phone = "2323232";
            acc.Sex = "male";

            XmlSerializer ser = new XmlSerializer(acc.GetType());
 
            StringWriter stringWriter = new StringWriter();

            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
            {
                ser.Serialize(xmlWriter, acc);
               
            }

            xmlText = stringWriter.ToString();
            
            UCTest1.SetText(xmlText);
            
        }
    }
}