using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace AccountProfile
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Account act = new Account();

            act.Id = "T303";
            act.Name = "Girish Baldota";
            act.Address = "Kothrud";
            act.Phone = "9028909925";
            act.Sex = "Male";
            act.Country = "India";


            Literal ltrlTemp = (Literal)this.FindControl("ucProfile1").FindControl("ltrlProfile");
            Hashtable tempHT= ParseXMLtoHT(SerializeObject(act));

            string output="<table border=\"1\">";
            foreach(string keys in tempHT.Keys)
            {
                output = output + "<tr><td>" + keys + "</td><td>" + tempHT[keys] + "</td></tr>";

            }
            output += "</table>";
            ltrlTemp.Text = output;


        }

        public String SerializeObject(Object pObject)
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(pObject.GetType());
              
               
                StringWriter stringWriter = new StringWriter();
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                {
                    serializer.Serialize(xmlWriter, pObject);
                }
                string xmlText = stringWriter.ToString();
                return xmlText;


            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }


        private String UTF8ByteArrayToString(Byte[] characters)
        {

            UTF8Encoding encoding = new UTF8Encoding();
            String constructedString = encoding.GetString(characters);
            return (constructedString);
        }


        private Hashtable ParseXMLtoHT(string strUrl)
        {
            try
            {
                Hashtable xmlContent = new Hashtable();
                XmlTextReader xmlReader = new XmlTextReader(new StringReader(strUrl));

                string key="";
                string value="";

                while (xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                           key=xmlReader.Name;
                            
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            value = xmlReader.Value;
                            xmlContent.Add(key, value);
                            break;
                       
                    }
                   
                }

                return xmlContent;

            }
            catch (XmlException e)
            {
                Console.WriteLine("error occured: " + e.Message);
                return null;
            }


        }
    }
}
    