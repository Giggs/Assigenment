using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetImageName : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random rand = new Random();
        string randFileName = "http://localhost:5710/ajaxDemo/images/" + "img" + rand.Next(4) + ".jpg"; Response.Write(randFileName);
    }
}