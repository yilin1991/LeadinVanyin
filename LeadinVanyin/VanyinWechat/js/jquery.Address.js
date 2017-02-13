/// <reference path="jquery-1.11.1.min.js" />
/// <reference path="Message.js" />



(function () {

	$.fn.extend({

		AddressUnfold: function(options) {//显示收获地址页面

			var opts = $.extend({}, defaults, options);
			var $this = $(this);
			$this.click(function() {
				if ($this.hasClass(opts.SelectClass)) {
					$(".otherlistbody").stop().animate({
						"height": "0px"
					}, opts.TimeOut)
					$this.removeClass(opts.SelectClass);
				} else {
					$("." + opts.AddressBody).stop().animate({
						"height": $("." + opts.AddressBox).height() + "px"
					}, opts.TimeOut)
					$this.addClass(opts.SelectClass);
				}
			})

		},
		AddressSelect: function(options) {//选择收获地址
			var $this = $(this);
			var opts = $.extend({}, defaults, options);
			return $this.each(function() {
				var $addli = $(this);
				$addli.find("li").eq(0).click(function() {  
				    var hidid = $addli.find("input[type=hidden]").val();
				    $("#hidAddress").val(hidid);
					$(this).css("background-image", "url(img/public/addselectico.png)");
					$(this).parents(".addli").siblings().find("li:first-child").css("background-image", "url(img/public/addmorenico.png)");
				})
			})
		},
		AddressAdd: function (options) { //点击显示收获地址
		    var opts = $.extend({}, defaults, options);

		    $(this).click(function () {
		        $this = $(this);

		        if (opts.AddType == "add") {
		            $("#txtname").val("");
		            $("#txtAddress").val("");
		            $("#txtTel").val("");
		        }
		        else if (opts.AddType == "edit") {

		            var hidAid = $this.find(".hidAid").val();
		            $("#hidEditId").val(hidAid);

		            $.ajax({
		                type: "POST",
		                url: "/Tools/GetAddressDetail.ashx",
		                data: { hidAid: hidAid },
		                dataType: "json",
		                success: function (data) {
		                    $("#txtname").val(data.Name);
		                    $("#txtAddress").val(data.Address);
		                    $("#txtTel").val(data.Tel);

		                    $("#ddlProvince option").each(function () {
		                        if ($(this).val() == data.Pid)
		                        {
                                    var selecttext = $(this).text();
		                            $(this).attr("selected", true).siblings().attr("selected", false);
		                            $("#ddlProvince").parents("li").find(".selectText p").text(selecttext);
		                        }
		                    })
                            
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


		        }

		        $(".AddressBox").fadeIn();
		        $(".AddressBox").animate({ "top": "0px" }, 500);

		        $("#hidType").val(opts.AddType);
		    })
		},
		CloseAddress: function () {//关闭收获地址页面
		    $(this).click(function () {
		        var wh = $(window).height();
		        $(".AddressBox").animate({ "top": -wh+"px" }, 500, function () {
		            $(".AddressBox").fadeOut();
		        });	        
		    })
		},
		BtnAddress: function (options) {//确认收获地址
		    var opts = $.extend({}, defaults, options);

		    $(this).bind("click", function () {
		        $this = $(this);
		        var name = $("#txtname").val();
		        var pid=$("#ddlProvince").val();
		        var cid = $("#ddlCity").val();
		        var did = $("#ddlDistrict").val();
		        var address = $("#txtAddress").val();
		        var tel = $("#txtTel").val();
		        var hid = $("#hidEditId").val();

		        if ($("#hidType").val() == "add") {
		            $.ajax({
		                type: "POST",
		                url: "/Tools/AddAddress.ashx",
		                data: { name: name, pid: pid, cid: cid, did: did, address: address, tel: tel,type:"add" },
		                dataType: "json",
		                success: function (data) {
		                    if (data.state) {
		                        $(".addlist").prepend(data.strHtml);
		                        var abh = $(".otherlistbox").height();
		                        $(".otherlistbody").stop().animate({ "height": abh + "px" })
		                        var wh = $(window).height();
		                        $(".AddressBox").animate({ "top": -wh + "px" }, 500, function () {
		                            $(".AddressBox").fadeOut();
		                        });
		                        $(".addlist .addli").AddressSelect();
		                        $(".otherlisttop a").AddressAdd({ "AddType": "add" });
		                        $(".editAddress").AddressAdd({ "AddType": "edit" })
		                    }
		                    else {
		                        ShowMessage(data.message, 1500);
		                    }
		                }
		            });
		        }
		        else {
		            $.ajax({
		                type: "POST",
		                url: "/Tools/AddAddress.ashx",
		                data: { name: name, pid: pid, cid: cid, did: did, address: address, tel: tel,hid:hid,type:"edit" },
		                dataType: "json",
		                success: function (data) {
		                    if (data.state) {
		                        $(".addli").each(function () {
		                            if ($(this).find(".hidAid").val() == hid)
		                            {
		                                $(this).html(data.strHtml);
		                            }
		                        })
		                        var abh = $(".otherlistbox").height();
		                        $(".otherlistbody").stop().animate({ "height": abh + "px" })
		                        var wh = $(window).height();
		                        $(".AddressBox").animate({ "top": -wh + "px" }, 500, function () {
		                            $(".AddressBox").fadeOut();
		                        });

		                        $(".addlist .addli").AddressSelect();
		                        $(".otherlisttop a").AddressAdd({ "AddType": "add" });
		                        $(".editAddress").AddressAdd({ "AddType": "edit" })
		                    }
		                    else {
		                        ShowMessage(data.message, 1500);
		                    }
		                }
		            });
		        }

		    })
		}
	})



	$.extend({
	    SetAddressBoxHeight: function () {
	        var wh = $(window).height();
	        $(".AddressBox").height(wh);
	        $(".AddressBox").css("top", -wh + "px");
	    }
	})


	var defaults = {
		"AddressBody": "otherlistbody",
		"AddressBox": "otherlistbox",
		"SelectClass": "select",
		"TimeOut": 500,
		"AddType":"add"
	}


})(jQuery)