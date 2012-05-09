using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace AccountProfile
{
    [Serializable]
    [XmlRoot("Profile")]
    public class Account
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}


  
