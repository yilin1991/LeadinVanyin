


(function () {

    $.fn.extend({
        BindMember: function (options) {
            var opts = $.extend({}, defaults, options);

            $(this).click(function () {
                if ($(opts.Account).val().trim() != "") {

                    if ($(opts.Pwd).val().trim() != "") {

                        if ($(opts.ImgYzm).val().trim() != "") {
                            $.ajax({
                                type: "POST",
                                url: "Tools/BindMember.ashx",
                                data: { account: $(opts.Account).val().trim(), pwd: $(opts.Pwd).val().trim(), imgyzm: $(opts.ImgYzm).val().trim() },
                                dataType: "json",
                                success: function (data) {
                                    if (data.state) {
                                        ShowMessageUrl("绑定成功", "Print.aspx", 1500);
                                    }
                                    else {
                                        ShowMessage(data.message, 1500);
                                    }
                                }
                            });

                        }
                        else {
                            ShowMessage("请输入右边图片上的验证码", 1000);
                        }
                    }
                    else {
                        ShowMessage("请填您的密码", 1000);
                    }
                }
                else {

                    ShowMessage("请输入您的帐号", 1000);
                }

            })




        }
    })


    $.extend({

        Loginload: function () {
            var bh = $(window).height() - $("#header").height() - $("#footer").height();

            var ch = $(".loginbody").height();

            if (bh - ch >= 40) {
                $(".loginbody").stop().animate({ "margin-top": (bh - ch) / 2 + "px" });

            }
            else {
                $(".loginbody").stop().animate({ "margin-top": "20px" });
                $(".loginbody").css("margin-bottom", "20px");
            }
        }
    });

    var defaults = {
        "Account": "#txtName",
        "Pwd": "#txtpwd",
        "ImgYzm": "#txtImgYzm"

    };

    //function ShowMessage(message, timeOut) {
    //    var _mhtml = "<div id='showmessage' class='showmessage'><p>" + message + "</p></div>";

    //    $("body").append(_mhtml);
    //    $("#showmessage").fadeIn(1000);
    //    setTimeout(function () {
    //        $("#showmessage").remove();
    //    }, timeOut)
    //}



})(jQuery)
