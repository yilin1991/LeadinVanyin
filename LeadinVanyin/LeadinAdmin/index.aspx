<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LeadinWeb.index" %>

<%@ Register Src="~/Vanyin/Controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Vanyin/Controls/left.ascx" TagPrefix="uc1" TagName="left" %>



<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>领意文化管理系统平台</title>
    <link rel="stylesheet" type="text/css" href="/Vanyin/css/style.css" />
    <link rel="stylesheet" type="text/css" href="/Vanyin/css/index.css" />
    <link rel="stylesheet" type="text/css" href="/Vanyin/css/font-awesome.min.css" />
</head>

<body>

    <!-- 头部 Begin -->
    <uc1:Header runat="server" ID="Header" />
    <!-- 头部 End -->

    <!--正文 Begin-->
    <div id="main">

        <!--左侧导航 Begin-->
        <uc1:left runat="server" ID="left" />
        <!--左侧导航 End-->

        <!--页面内容 Begin-->
        <div id="pagemain">

            <div class="mapMenu">
                <ul>
                    <li>位置：</li>
                    <li><a href="#">首页</a></li>
                    <li>></li>
                    <li><a href="#">资讯管理</a></li>
                </ul>
            </div>

            <div class="contentBox">

                <div class="indexUser">
                    <ul>
                        <li>
                            <img src="/Vanyin/img/sun.png" /></li>
                        <li>admin</li>
                        <li>早上好</li>
                        <li>，欢迎使用后台管理系统</li>
                        <li>（admin@leaderee.com）</li>
                        <li><a href="#">帐号设置</a></li>
                    </ul>
                </div>

                <div class="loginTime">
                    <ul>
                        <li>
                            <img src="/Vanyin/img/time.png" /></li>
                        <li>您上次登录的时间：</li>
                        <li>2013-10-09 15:22</li>
                        <li>（不是您登录的？</li>
                        <li><a href="#">请点这里</a></li>
                        <li>）</li>
                    </ul>
                </div>

                <div class="indexLine">
                </div>

            </div>

            <!--页面内容 End-->

        </div>
        <!--正文 End-->
        
    </div>
    <script src="/Vanyin/js/jquery-1.11.1.min.js" charset="utf-8"></script>
    <script src="/Vanyin/js/jquery.admin.js" type="text/javascript" charset="utf-8"></script>

</body>

</html>
