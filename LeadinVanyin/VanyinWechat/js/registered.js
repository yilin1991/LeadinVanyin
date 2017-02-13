/// <reference path="jquery-1.11.1.min.js" />
/// <reference path="Message.js" />



(function () {

    $.fn.extend({

        GetYzm: function (options) {

            var opts = $.extend({}, defaults, options);


            $(this).click(function () {


                if ($(opts.txtPhone).val().trim() == "") {
                    ShowMessage("手机号码不能为空", 1000);
                }
                else {

                    if (!(/^1[3|4|5|7|8][0-9]\d{8}$/.test($(opts.txtPhone).val()))) {
                        ShowMessage("请输入正确手机号", 1000);
                    }
                    else {
                        $.ajax({
                            type: "POST",
                            url: "Tools/GetYzm.ashx",
                            data: { Tel: $(opts.txtPhone).val() },
                            dataType: "json",
                            success: function (data) {
                                if (data.state) {
                                    ShowMessage("短信发送成功", 1500);
                                }
                                else {
                                    ShowMessage(data.message,1500);
                                }
                            }
                        });
                    }

                }

               

               
            })

            return $(this);

        },
        BtnOK: function (options) {

            var opts = $.extend({}, defaults, options);

            


            $(this).click(function () {
                if ($(opts.txtPhone).val().trim() == "") {
                    ShowMessage("手机号码不能为空", 1000);

                }
                else {
                    if (!(/^1[3|4|5|7|8][0-9]\d{8}$/.test($(opts.txtPhone).val()))) {
                        ShowMessage("请输入正确手机号", 1000);

                    }
                    else {
                        if ($(opts.txtYzm).val().trim() == "") {
                            ShowMessage("手机验证码不能为空", 1000);
                          
                        }
                        else {
                            if ($(opts.txtImgYzm).val().trim() == "") {
                                ShowMessage("图形验证码不能为空", 1000);
                            }
                            else {
                                $.ajax({
                                    type: "POST",
                                    url: "Tools/registered.ashx",
                                    data: { Tel: $(opts.txtPhone).val(), yzm: $(opts.txtYzm).val(), imgYzm: $(opts.txtImgYzm).val() },
                                    dataType: "json",
                                    success: function (data) {
                                        if (data.state) {
                                            location.href = "Print.aspx";
                                        }
                                        else {
                                            alert(data.message);
                                        }
                                    },
                                    error: function () {
                                        alert("未找到文件");

                                    }
                                });
                            }
                        }
                    }
                }

                

                
                

               


            })

            return $(this);

        }




    });


    var defaults = {
        "txtPhone": "#txtPhone",
        "txtYzm": "#txtYzm",
        "txtImgYzm": "#txtImgYzm"
    }



})(jQuery)