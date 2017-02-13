/// <reference path="jquery-1.11.1.min.js" />


$(function () {

    $(window).resize(function () {
        onresize1();
    });

    //设置头部模版类别的宽度
    $(".designtype li").width(1100 / $(".designtype li").length);

    //设置默认详细流程的遮罩高度
    $(".showdesign").height($(window).height());

    //关闭详细流程
    $(".showdesignclose").click(function () { 
        CloseShowdesign();      
    })

    //加载左侧导航默认位置
    $(".leftmenu").css("left", (($(window).width() - 1150) / 2 - 80) + "px");

    //展开详细流程
    $(".leftmenu ul li.liucheng").click(function () {
        ShowShowdesign();
    })

    $(".leftmenu ul li.backtop").click(function(){

        $("html,body").animate({ scrollTop: 0 }, 500);
    })


    //左侧导航展开收起
    $(window).scroll(function () {
    
            if ($(window).scrollTop() >= 240) {
                $(".leftmenu").stop().animate({
                    "height": $(".leftmenu ul").height() + "px"
                }, 500)
            } else {
                $(".leftmenu").stop().animate({
                    "height": "46px"
                }, 500)
            } 
    })

    



    //设置默认类别选中样式        
    $(".designmenu ul.designtype li").eq(0).addClass("active");
    $(".leftmenu ul li.designtype").eq(0).addClass("active");



})

//页面宽度发生改变事件
function onresize1() {

    $(".showdesign").height($(window).height());//设置流程遮罩大小
    $(".leftmenu").css("left", (($(window).width() - 1150) / 2 - 80) + "px");//设置侧边栏的位置
}


//显示模版详细信息
function ShowDetail(tid) {
    $.ajax({
        type: "POST",
        url: "/Tools/GetDesigntemp.ashx",
        data: { tid: tid },
        dataType: "json",
        success: function (data) {
            $.ClickShow({
                "templatename": data.templatename,
                "templatekey": data.templatekey,
                "detailcontent": data.detailcontent,
                "hidTemId": data.hidTemId,
                "designremark": data.designremark,
                "printremark": data.printremark,
                "toolsremark": data.toolsremark
            });
        }

    })
}



//关闭流程详细
var CloseShowdesign = function () {
    $(".showdesignbox").stop().animate({
        "opacity": "0"
    }, 500, function () {
        $(".showdesign").stop().animate({
            "opacity": "0"
        }, 500, function () {
            $(".showdesign").hide();
            $(".leftmenu").stop().animate({ "opacity": "1" }, 500);
        })
    })

}



//展开详细流程
var ShowShowdesign = function () {

    $(".leftmenu").stop().animate({ "opacity": "0" }, 500, function () {

        $(".showdesign").show();

        $(".showdesign").stop().animate({
            "opacity": "1"
        }, 500, function () {
            $(".showdesignbox").stop().animate({
                "opacity": "1"
            }, 500)
        })

    });



 


    



}




















