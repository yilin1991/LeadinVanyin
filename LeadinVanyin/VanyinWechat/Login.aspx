<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>


<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>万印网首页</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/Login.css" />
</head>

<body>
    <form runat="server" id="myform">


		<!--正文 begin-->
        <div id="content">

            <div class="loginbody">

                <div class="logintitle">
                    <p>帐号绑定</p>
                </div>

                <div class="logininput">
                    <div class="logininputico"></div>
                    <div class="logininputtext">
                        <input type="text" name="txtName" id="txtName" value="" class="logintext" placeholder="请输入您的帐号" />
                    </div>
                </div>
                <div class="logininput loginpwd">
                    <div class="logininputico"></div>
                    <div class="logininputtext">
                        <input type="password" name="txtpwd" id="txtpwd" value="" class="logintext" placeholder="请输入您的密码" />
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
                    <p>确认绑定</p>
                </div>
                <div class="loginremark">
                    <p>还没有帐号？<a href="registered.aspx">现在去注册</a></p>
                </div>
            </div>


        </div>
        <!--正文 end-->
        <uc1:Footer runat="server" ID="Footer" />
        <!--底部  begin-->
       
        <!--底部  end-->
        <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
        <script src="js/Message.js" ></script>
        <script src="js/login.js"></script>
        <script type="text/javascript">
            $(function () {
                $.Loginload();

              

                $(".loginbtn").BindMember();

                $(".GetImgYzm img").click(function () {
                    document.getElementById("yzm").src = "Tools/Yzm.ashx?t=" + Math.random();
                })




            })
		</script>
    </form>
</body>

</html>
