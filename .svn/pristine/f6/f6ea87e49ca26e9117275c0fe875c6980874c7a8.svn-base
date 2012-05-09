var c = 0;
var t;
var timer_is_on = 0;

function getImage() {

    this.doTimer();
    if (window.XMLHttpRequest) {
        xmlHttp = new XMLHttpRequest();

    }
    else {

        xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
    }

    xmlHttp.onreadystatechange = function () {

        if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {


            var imagepath = xmlHttp.responseText;
            document.getElementById("div2").innerHTML = imagepath;

            var img = document.getElementById('myImage');
            img.src = 'http://localhost:5710/ajaxDemo/images/img' + Math.floor(Math.random() * 11) + '.jpg';

        }
    }

    xmlHttp.open("GET", "GetImageName.aspx", true);
    xmlHttp.send();

}

function timedCount() {
    document.getElementById('txt').value = c;
    c = c + 1;
    t = setTimeout("timedCount()", 5000);

    getImage();
}

function doTimer() {
    if (!timer_is_on) {
        timer_is_on = 1;
        timedCount();
    }
}
