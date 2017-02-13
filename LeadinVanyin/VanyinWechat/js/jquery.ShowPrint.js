(function() {

	$.fn.extend({

		ShowPrint: function() {

			$(this).bind("click", function() {

				if ($(this).parents(".IsPrint").hasClass("IsPrintselect")) {
					$(this).find(".IsPrintbox").stop().animate({
						"left": "3px"
					}, 500)
					$(this).parents(".IsPrint").removeClass("IsPrintselect");
					$(".printbody").stop().animate({
						"height": "0px"
					}, 500);
				$(".IsPrint").find("li:nth-child(3) p").text("否");
					

				} else {
					$(this).find(".IsPrintbox").stop().animate({
						"left": "33px"
					}, 500)
					$(this).parents(".IsPrint").addClass("IsPrintselect");
					$(".printbody").stop().animate({
						"height": $(".printbox").height() + "px"
					}, 500, function() {

						$(this).css("height", "auto");

					})
					$(".IsPrint").find("li:nth-child(3) p").text("是");
				}



				return $(this);

			})



		}

	})



})(jQuery)