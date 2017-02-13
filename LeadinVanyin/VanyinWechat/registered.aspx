<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registered.aspx.cs" Inherits="registered" %>

<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>
<html>

	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
		<title>万印网首页</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
		<link rel="stylesheet" type="text/css" href="css/registered.css"/>
	</head>

	<body>

		<!--头部 begin-->
		<div id="header">
			<p>万印网注册</p>
			<div class="headerback">
				<a href="#"><img src="img/public/backico.png" /></a>
			</div>
		</div>
		<!--头部 end--

		<!--正文 begin-->
		<div id="content">
		
			<div class="loginbody">
				
				<div class="logintitle">
					<p>用户注册</p>
				</div>
				
				<div class="logininput">
					<div class="logininputico"></div>
					<div class="logininputtext">
						<input type="text" name="txtPhone" id="txtPhone" value="" class="logintext" placeholder="请输入您的手机号码"/>
					</div>
				</div>
				<div class="logininput loginpwd">
					<div class="logininputico"></div>
					<div class="logininputtext">
						<ul>
							<li><input type="text" name="txtYzm" id="txtYzm" value="" class="logintext" placeholder="您收到的验证码"/></li>
							<li class="GetYzm"><p>获取验证码</p></li>
						</ul>
						
					</div>
				</div>
                <div class="logininput loginpwd">
					<div class="logininputico"></div>
					<div class="logininputtext">
						<ul>
							<li><input type="text" name="txtImgYzm" id="txtImgYzm" value="" class="logintext" placeholder="图形验证码"/></li>
							<li class="GetImgYzm"><img src="Tools/Yzm.ashx" id="yzm" /> </li>
						</ul>
						
					</div>
				</div>

				<div class="loginbtn">
					<p>确认注册</p>
				</div>
				<div class="loginremark">
					<p>已有帐号？<a href="Login.aspx">现在去绑定</a></p>
				</div>
				
			</div>
		


		</div>
		<!--正文 end-->

		<!--底部  begin-->
        <uc1:Footer runat="server" ID="Footer" />
		<!--底部  end-->
		<script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
		
        <script src="js/Message.js"></script>
        <script src="js/login.js" type="text/javascript" charset="utf-8"></script>
        <script src="js/registered.js"></script>

		<script type="text/javascript">
		    $(function () {
		        $.Loginload();

		        $(".logininputtext li.GetYzm").GetYzm();
		        $(".loginbtn").BtnOK();

		        

		        $(".GetImgYzm img").click(function () {
		            document.getElementById("yzm").src = "Tools/Yzm.ashx?t=" + Math.random();
		        })

		    })
		</script>
		
	</body>

</html>