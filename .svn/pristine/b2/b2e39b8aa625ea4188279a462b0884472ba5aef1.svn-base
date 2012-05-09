using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace AccountProfile
{
    public partial class UCTest : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetText(string xmlText)
        {
            // parse xmlText and set to literal control . . .

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlText);

            string name = "";

            XmlNodeList list = doc.GetElementsByTagName("Name");

            foreach (XmlNode item in list)
            {
                name = item.InnerText;
            }

        }
    }
}