/// <reference path="jquery-1.11.1.min.js" />



(function () {

    $.fn.extend({

        ShowOption: function (options) {

          return  $(this).each(function () {


                $(this).find(".selectText").bind("click", function () {

                    if ($(this).parents(".selectbox").hasClass("select1")) {
                        $(this).parents(".selectbox").find(".selectlist").stop().animate({
                            "height": "0px"
                        });
                        $(this).parents(".selectbox").removeClass("select1");
                    } else {
                        $(this).parents(".selectbox").find(".selectlist").stop().animate({
                            "height": "120px"
                        });
                        $(this).parents(".selectbox").addClass("select1");

                        $(".selectText").not(this).each(function () {

                            $(this).parents(".selectbox").removeClass("select1");
                            $(this).parents(".selectbox").find(".selectlist").stop().animate({
                                "height": "0px"
                            });
                        })

                    }


                })



                $(this).on("click", ".selectlist li", function () {

                    var selectText = $(this).find("p").text();

                    $(this).addClass("select").siblings().removeClass("select");

                    $(this).parents(".selectbox").find(".selectText p").text(selectText);
                    $(this).parents("li").find("select option").each(function () {
                        if ($(this).text() == selectText) {
                            $(this).attr("selected", true).siblings().attr("selected", false);
                        }

                    })

                    $(".selectlist").stop().animate({
                        "height": "0px"
                    });
                    $(".selectbox").removeClass("select1");


                    //event.stopPropagation();
                })
            })

        },
        ProvinceClick: function () {

            $(this).on("click", ".selectlist li", function () {


                var cid = $(this).find("input[type=hidden]").val();
                $.ajax({
                    type: "POST",
                    url: "Tools/GetCity.ashx",
                    data: { pid: cid },
                    dataType: "json",
                    success: function (data) {

                        $("#ddlCity").html(data.strddlCity);
                        $("#ddlCity").parent().find(".selectbox").remove();
                        $("#ddlCity").parent().append(data.strCity);

                        $("#ddlDistrict").html(data.strddlDistrict);
                        $("#ddlDistrict").parent().find(".selectbox").remove();
                        $("#ddlDistrict").parent().append(data.strDistrict);


                        $("#ddlCity").parent().find(".selectbox").ShowOption();
                        $("#ddlDistrict").parent().find(".selectbox").ShowOption();
                        $("#ddlCity").parent("li").find(".selectbox").CityClick();
                    }
                });
               
                //even.t.stopPropagation();
            })

        },
        CityClick: function () {
            
            $(this).on("click", ".selectlist li", function () {

               
                var cid = $(this).find("input[type=hidden]").val();

                $.ajax({
                    type: "POST",
                    url: "Tools/GetDistrict.ashx",
                    data: { pid: cid },
                    dataType: "json",
                    success: function (data) {

                        $("#ddlDistrict").html(data.strddlDistrict);
                        $("#ddlDistrict").parent().find(".selectbox").remove();
                        $("#ddlDistrict").parent().append(data.strDistrict);

                        $("#ddlDistrict").parent().find(".selectbox").ShowOption();
                    }
                });
            })
        }
    })



    $.extend({
        SelectLoad: function (options) {

            var opts = $.extend({}, defaults, options);
            $(".ui-select").each(function () {
                var htmlText = "";
                htmlText += "<div class=\"selectbox\">";
                htmlText += "<div class=\"selectText\">";
                if ($(this).find("option:selected").text().trim() != "") {
                    htmlText += "<p>" + $(this).find("option:selected").text() + "</p>";
                } else {
                    htmlText += "<p>" + $(this).find("option:first-child").text() + "</p>";
                }
                htmlText += "</div>";
                htmlText += "<div class=\"selectico\">";
                htmlText += "<img src=\"img/public/selectico.png\" />";
                htmlText += "</div>";
                htmlText += "<div class=\"selectlist\">";
                htmlText += "<ul>";
                $(this).find("option").each(function () {
                    htmlText += "<li><p>" + $(this).text() + "</p><input type=\"hidden\" name=\"hidvalue\"  value=\"" + $(this).val() + "\" class=\"hidvalue\" /></li>";
                })
                htmlText += "</ul>";
                htmlText += "</div>";
                htmlText += "</div>";
                $(this).parent().append(htmlText);
            })
        }
    });
    var defaults = {
        "SelectClass": "ui-select"
    }


})(jQuery)