<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title></title>
    <script src="Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $.getJSON("http://api.flickr.com/services/feeds/photos_public.gne?tags=&tagmode=any&format=json&jsoncallback=?",
        function (data) {
            $.each(data.items, function (i, item) {
                $("<img/>").attr("src", item.media.m).appendTo("#images");
                if (i == 4) return false;
            });
        });
    
    </script>
    <style type="text/css">img{ height: 100px; float: left; }</style>
</head>



<body>
    <form id="form1" runat="server">
    <div id= "images">
    
    </div>
    </form>
</body>
</html>




