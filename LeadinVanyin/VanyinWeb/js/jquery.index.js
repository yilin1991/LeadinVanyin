/// <reference path="jquery-1.11.1.min.js" />


$(function() {

	$(".swiperbanner").hover(function() {
		myBanner.stopAutoplay()
	}).mouseleave(function() {
		myBanner.startAutoplay()
	})

	$(".swiperdesign").hover(function() {
		myDesign.stopAutoplay()
	}).mouseleave(function() {
		myDesign.startAutoplay()
	})

	$(".swiperprint").hover(function() {
		myPrint.stopAutoplay()
	}).mouseleave(function() {
		myPrint.startAutoplay()
	})

	$(".swiperecno").hover(function() {
		myEcno.stopAutoplay()
	}).mouseleave(function() {
		myEcno.startAutoplay()
	})


	$(".designtop ul.type li").eq(0).addClass("active");//����Ĭ��ģ�������ʽ
	

    //ѡ��ģ�������ˢ�¼���ģ��
	$(".designtop ul.type li").click(function () {
	    $(this).addClass("active").siblings().removeClass("active");
	    var cid=$(this).find("input[type=hidden]").val();
	    $.ajax({
	        type: "POST",
	        url: "/index.aspx/SetTemplateTypeChange",
	        //�������ε�д��һ��Ҫ�ԣ�strΪ�βε�����,str2Ϊ�ڶ����βε�����  
	        data: "{ 'cid':" + cid + "}",
	        contentType: "application/json; charset=utf-8",
	        dataType: "json",
	        success: function (data) {
	            //���ص�������data.d��ȡ����  

	            $(".design .designhot").html(data.d);


	        },
	        error: function (err) {
	            alert(err);
	        }
	    });



	})

	$(".digitalbox .digitalleft ul li").eq(0).addClass("active");//����Ĭ���ŵ������ʽ
    //ѡ���ŵ������ˢ�¼����ŵ�
	$(".digitalbox .digitalleft ul li").click(function () {
	    $(this).addClass("active").siblings().removeClass("active");
	    var cid = $(this).find("input[type=hidden]").val();
	    $.ajax({
	        type: "POST",
	        url: "/index.aspx/SetStoreCityChange",
	        //�������ε�д��һ��Ҫ�ԣ�strΪ�βε�����,str2Ϊ�ڶ����βε�����  
	        data: "{ 'cid':" + cid + "}",
	        contentType: "application/json; charset=utf-8",
	        dataType: "json",
	        success: function (data) {
	            //���ص�������data.d��ȡ����  

	            $(".digitalbox .digitallist").html(data.d);


	        },
	        error: function (err) {
	            alert(err);
	        }
	    });



	})



})

var myBanner = new Swiper('.swiperbanner', {
	loop: true,
	autoplay: 3000,
	speed: 1000,
	autoplayDisableOnInteraction: false,
	pagination: ".pagination",
	paginationType: 'custom',
	paginationClickable: true,
});
var myDesign = new Swiper('.swiperdesign', {
	effect: 'fade',
	loop: true,
	speed: 1000,
	autoplay: 2000,
	autoplayDisableOnInteraction: false,
	pagination: ".paginationdesign",
	paginationClickable: true,
});
var myPrint = new Swiper('.swiperprint', {
	effect: 'fade',
	loop: true,
	speed: 1000,
	autoplay: 2000,
	autoplayDisableOnInteraction: false,
	pagination: ".paginationprint",
	paginationClickable: true,
});
var myEcno = new Swiper('.swiperecno', {
	loop: true,
	speed: 1500,
	autoplay: 4000,
	autoplayDisableOnInteraction: false,
	slidesPerView: 4,
	slidesPerGroup: 4,
	spaceBetween: 48,
	slidesPerView: 'auto',
	loopedSlides: 7,
	paginationClickable: true,
});



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
