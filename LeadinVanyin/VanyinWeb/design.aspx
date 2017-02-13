<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="design.aspx.cs" Inherits="LeadinWeb.design" %>

<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>我要设计</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/design.css" />
    <link href="css/showdetail.css" rel="stylesheet" />

</head>

<body>

    <!--头部导航 Begin-->
    <uc1:Header runat="server" ID="Header" />
    <!--头部导航 End-->

    <!--正文 Begin-->
    <div id="content" class="design">
        <!--设计类别 Begin-->
        <div class="designmenu">
            <ul class="designtype">
                <asp:Repeater runat="server" ID="repTemplateType">
                    <ItemTemplate>
                        <li>
                            <a href="design.aspx?type=<%#Eval("Id") %>">
                                <img src="<%# Eval("Remark").ToString().Split(',')[0] %>" />
                                <p><%#Eval("Title") %></p>
                            </a>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>



        </div>
        <!--设计类别 End-->
        <!--设计说明 Begin-->
        <div class="typeremark">
            <div class="typeremarkbox">
                <div class="typeimg">
                    <img src="<%=model.ImgUrl %>" />
                </div>
                <div class="remark">
                    <p class="typename"><%=model.Title %>设计</p>
                    <ul>
                        <li class="subtitle">
                            <p><%=model.SubTitle %></p>
                        </li>
                        <li class="text date">
                            <p><span><%=model.Cycle %></span></p>
                        </li>
                        <li class="text price">
                            <p><span><%=model.Price %></span></p>
                        </li>
                    </ul>

                    <img src="img/design/typeimg/designremarkimg.png" />
                    <p class="typetext">小万为您提供精美的设计模板，供您选择。</p>
                    <p class="typetext">如您需要定制化的设计，您也可通过<a href="#"> “在线客服”</a>、<a href="#"> “电话咨询”</a>、<a href="#"> “需求留言”</a>的方式，与我们进行沟通。</p>
                </div>
            </div>

        </div>
        <!--设计说明 End-->
        <!--搜索 Begin-->
        <div class="search">
        </div>
        <!--搜索 End-->

        <div class="designlist">

            <asp:Repeater runat="server" ID="repTemplate">
                <ItemTemplate>
                    <ul>
                        <li class="img" onclick="ShowDetail('<%#Eval("Id") %>')">
                            <img src="<%#Eval("ImgUrl") %>" /></li>
                        <li class="text">
                            <span class="name"><%#Eval("Title") %></span>
                            <a href="designdetail.aspx?id=<%#Eval("Id") %>">选中</a>
                        </li>
                    </ul>
                </ItemTemplate>
            </asp:Repeater>



        </div>

        <p class="desinmore">没有更多了,小万正在努力更新中</p>

    </div>
    <!--正文 Begin-->



    <!--设计流程 Begin-->
    <div class="showdesign">
        <div class="showdesignbox">
            <ul class="showdesignul">
                <li class="title">
                    <p>万印网设计流程</p>
                </li>
                <li class="img">
                    <img src="img/design/show/showdesignimg.png" /></li>
                <li class="title">
                    <p>万印网设计服务标准</p>
                </li>
                <li class="table">
                    <img src="img/design/show/showdesignimg2.png" /></li>
            </ul>

            <div class="showdesignclose">
                <img src="img/design/show/showdesigncolse.png" />
            </div>

        </div>
    </div>
    <!--设计流程 End-->

    <!--左侧设计类别导航 Begin-->
    <div class="leftmenu">
        <ul class="">
            <li class="liucheng">
                <p>
                    设计流程<br />
                    及报价
                </p>
            </li>
            <asp:Repeater runat="server" ID="repTemplateType1">
                <ItemTemplate>
                    <li class="designtype">
                        <div class="designtypebox ">
                            <a href="design.aspx?type=<%#Eval("Id") %>">
                                <span class="name"><%#Eval("Title") %></span>
                                <span class="img">
                                    <img src="<%#Eval("Remark").ToString().Split(',')[1] %>" /></span>
                            </a>
                        </div>
                        <img src="img/design/designmenuleftico.png" />
                    </li>
                </ItemTemplate>
            </asp:Repeater>


            <li class="backtop">
                <img src="img/design/backtopico.png" />
                <p>返回顶部</p>
            </li>
        </ul>
    </div>
    <!--左侧设计类别导航 End-->


    <!--底部 Begin-->
    <uc1:Footer runat="server" ID="Footer" />
    <!--底部 End-->


    <script src="js/jquery-1.11.1.min.js" charset="utf-8"></script>
    <script src="js/jquery.design.js" charset="utf-8"></script>
    <script src="js/jquery.showdetail.js"></script>

    <script>
        $(function () {


            //判断是否第一次打开网站，如果第一次打开则加载流程详细页面否则不加载
            if("<%=IsFirstLook%>" == "1")
            {
                $(".showdesignbox").css("opacity", "0");
                $(".showdesign").css({ "opacity": "0", "display": "none" });
                $(".leftmenu").css("opacity", "1");
            }
      

            //根据选择的类别加载头部导航的样式
            $(".designtype li").each(function () {

                if ($(this).find("p").text() == "<%=model.Title%>") {
                    $(this).addClass("active");
                    $(this).find("img").attr("src", "<%=model.Remark.Split(',')[1]%>")
                }
                else {
                    $(this).removeClass("active");
                }
            })

            //根据选择的类别加载左侧导航的样式
            $(".leftmenu ul li.designtype").each(function () {

                if ($(this).find("span[class=name]").text() == "<%=model.Title%>") {
                    $(this).addClass("active");
                }
                else {
                    $(this).removeClass("active");
                }
            })


        })
    </script>

</body>

</html>
