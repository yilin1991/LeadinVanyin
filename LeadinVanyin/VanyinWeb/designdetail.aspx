<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="designdetail.aspx.cs" Inherits="LeadinWeb.designdetail" %>

<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>我要设计</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/designcar.css" />
</head>

<body>

    <!--头部导航 Begin-->
    <uc1:Header runat="server" ID="Header" />
    <!--头部导航 End-->

    <!--正文 Begin-->
    <div id="content" class="design">

        <!--头部地图 Begin-->
        <div class="designmenu">
            <ul class="designmap">
                <li><a href="index.aspx">首页</a></li>
                <li>></li>
                <li><a href="design.aspx">我要设计</a></li>
                <li>></li>
                <li class="mapname">核对信息，需求填写</li>
            </ul>
        </div>
        <!--头部地图 End-->

        <div class="detail">
            <p>请您认真核对和填写以下内容，避免耽误您需求的及时处理</p>
            <div class="detailbox">

                <!--模版图片 Begin-->
                <div class="img">
                    <img src="img/design/designimg.jpg" />
                </div>
                <!--模版图片 End-->

                <!--模版详情 Begin-->
                <div class="content">
                </div>
                <!--模版详情 End-->
            </div>
        </div>




    </div>
    <!--正文 Begin-->

    <!--底部 Begin-->
    <uc1:Footer runat="server" ID="Footer" />
    <!--底部 End-->






</body>

</html>
