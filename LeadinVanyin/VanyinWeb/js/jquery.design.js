/// <reference path="jquery-1.11.1.min.js" />


$(function () {

    $(window).resize(function () {
        onresize1();
    });

    //����ͷ��ģ�����Ŀ��
    $(".designtype li").width(1100 / $(".designtype li").length);

    //����Ĭ����ϸ���̵����ָ߶�
    $(".showdesign").height($(window).height());

    //�ر���ϸ����
    $(".showdesignclose").click(function () { 
        CloseShowdesign();      
    })

    //������ർ��Ĭ��λ��
    $(".leftmenu").css("left", (($(window).width() - 1150) / 2 - 80) + "px");

    //չ����ϸ����
    $(".leftmenu ul li.liucheng").click(function () {
        ShowShowdesign();
    })

    $(".leftmenu ul li.backtop").click(function(){

        $("html,body").animate({ scrollTop: 0 }, 500);
    })


    //��ർ��չ������
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

    



    //����Ĭ�����ѡ����ʽ        
    $(".designmenu ul.designtype li").eq(0).addClass("active");
    $(".leftmenu ul li.designtype").eq(0).addClass("active");



})

//ҳ���ȷ����ı��¼�
function onresize1() {

    $(".showdesign").height($(window).height());//�����������ִ�С
    $(".leftmenu").css("left", (($(window).width() - 1150) / 2 - 80) + "px");//���ò������λ��
}


//��ʾģ����ϸ��Ϣ
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



//�ر�������ϸ
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



//չ����ϸ����
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




















