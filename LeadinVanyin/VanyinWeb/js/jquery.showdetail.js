(function ($) {

    $.extend({

        ClickShow: function (options) {
            var opts = $.extend({}, defaults, options);

            $(document.body).css("overflow", "hidden");

            var keylist = opts.templatekey.split("|")
            var strkey = "";
            if (keylist.length > 1) {

                $.each(keylist, function (i, k) {
                    strkey += "<span>" + keylist[i] + "</span>";
                });
            } else {
                strkey = opts.templatekey;

            }

            var toollist = opts.toolsremark.split("|")
            var strtool = "";
            if (toollist.length > 1) {

                $.each(toollist, function (i, k) {
                    strtool += "<span>" + toollist[i] + "</span>";
                });
            } else {
                strtool = opts.toolsremark;
            }

            var strContent = "<div class=\"showbox\"><div class=\"showcontent\"><ul class=\"showcontenttop\"><li class=\"templatename\">" + opts.templatename + "</li><li class=\"templatekey\">" + strkey + "</li></ul><div class=\"detailcontent\">" + opts.detailcontent + "</div></div><ul class=\"showremark\"><li class=\"selectdesign\"><a href='" + opts.hidTemId + "'>选择此款</a><input type=\"hidden\" id=\"hidTemId\"> </li><li class=\"remark templatedesign\"><p class=\"title\">设计说明</p><div class=\"text\">" + opts.designremark + "</div></li><li class=\"remark templateprint\"><p class=\"title\">印刷建议</p><div class=\"text\">" + opts.printremark + "</div></li><li class=\"remark templateTools\"><p class=\"title\">设计软件</p><div class=\"text\">" + strtool + "</div></li></ul></div>";

            $("body").prepend("<div class=\"showdetail\"></div>");

            $(".showdetail").stop().animate({
                "opacity": "1"
            }, 300, function () {

                $(this).append(strContent);
                $(this).find(".showbox").stop().animate({
                    "opacity": "1"
                }, function () {

                    detailScroll();
                })

            })

        }
    })

    var defaults = {
        "templatename": "",
        "templatekey": "",
        "detailcontent": "",
        "hidTemId": "",
        "designremark": "",
        "printremark": "",
        "toolsremark": ""
    };

})(jQuery)

$(function () {
    showdetail();
    window.onresize = showdetail;
    detailScroll();


    $("body").on("click", ".showdetail", function () {

        $(".showbox").stop().animate({
            "opacity": "0"
        }, 500, function () {
            $(".showdetail").stop().animate({
                "opacity": "0"
            }, 300, function () {
                $(".showdetail").remove();
                $(document.body).css("overflow", "auto");
            })

        })

    })
    $("body").on("click", ".showcontent", function (event) {
        event.stopPropagation();
    })
    $("body").on("click", ".showremark", function (event) {
        event.stopPropagation();
    })

})

var detailScroll = function () {
    $(".showdetail").scroll(function () {

        var sdscrolltop = $(".showdetail").scrollTop();
        $(".showremark").stop().animate({
            "margin-top": sdscrolltop + "px"
        }, 300);
    })
}


var selectdesign = function () {


}

var showdetail = function () {

    $(".showdetail").height($(window).height());

}