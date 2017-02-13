
function ShowMessage(message,timeOut) {
    var _mhtml = "<div id='showmessage' class='showmessage'><p>" + message + "</p></div>";

    $("body").append(_mhtml);
    $("#showmessage").fadeIn(1000);
    setTimeout(function () {
        $("#showmessage").remove();
    }, timeOut)
}

function ShowMessageUrl(message, url,timeOut) {
    var _mhtml = "<div id='showmessage' class='showmessage'><p>" + message + "</p></div>";
    $("body").append(_mhtml);
    $("#showmessage").fadeIn(1000);
    setTimeout(function () {
        $("#showmessage").remove();
        if (url != "") {
            location.href = url;
        }
    }, timeOut)
}


function loginUrl(message, url, timeOut) {
    var _mhtml = "<div id='showmessage' class='showmessage'><p>" + message + "</p></div>";
    $("body").append(_mhtml);
    $("#showmessage").fadeIn(1000);
    setTimeout(function () {
        $("#showmessage").remove();
        if (url != "") {
            parent.location.href = url;
        }
    }, timeOut)
}
