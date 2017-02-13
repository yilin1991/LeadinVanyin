<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conference.aspx.cs" Inherits="LeadinWeb.Conference" %>


<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>我要设计</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/Conference.css" />
</head>

<body>

    <!--头部导航 Begin-->
    <uc1:Header runat="server" ID="Header" />
    <!--头部导航 End-->

    <!--正文 Begin-->
    <div id="content">


          <div class="content_all">
      
                <div class="content_top">
                    <div class="content_left">
                        <img src="/img/Conference/huiwuhuodong01.png" alt="img" />
                    </div>
                    <div class="content_right">
                        <span>会务活动</span>
                    </div>
                </div>
                <div class="content_bigImg">
                    <img src="/img/Conference/huiwuhuodong02.png" alt="bigimg" />
                </div>

                <div class="content_top">
                    <div class="content_left">
                        <img src="/img/Conference/sheji01.png" alt="img" />
                    </div>
                    <div class="content_right">
                        <span>会务室设计</span>
                    </div>
                </div>
                <div class="content_bigImg">
                    <div class="content_bigImg_Left">
                        <img src="/img/Conference/huihusheji01.png" alt="bigimg">
                    </div>
                    <div class="content_bigImg_Right">
                        <img src="/img/Conference/huiwusheji02.png" alt="bigimg">
                    </div>

                </div>
          
        </div>

        
    </div>
    <!--正文 Begin-->

    <!--底部 Begin-->
    <uc1:Footer runat="server" ID="Footer" />
    <!--底部 End-->






</body>

</html>

