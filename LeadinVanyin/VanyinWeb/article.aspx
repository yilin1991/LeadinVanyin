<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="article.aspx.cs" Inherits="LeadinWeb.article" %>

<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register Src="~/Control/ArticleLeft.ascx" TagPrefix="uc1" TagName="ArticleLeft" %>




<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>我要设计</title>
    <link rel="stylesheet" type="text/css" href="/css/style.css" />
    <link rel="stylesheet" type="text/css" href="/css/article.css" />
    <link href="/Vanyin/css/pagination.css" rel="stylesheet" />
</head>

<body>

    <!--头部导航 Begin-->
    <uc1:Header runat="server" ID="Header" />
    <!--头部导航 End-->

    <!--正文 Begin-->
    <div id="content">

        <div class="articlebox">
            <%-- 资讯左侧导航 Begin --%>
            <uc1:ArticleLeft runat="server" ID="ArticleLeft" />
            <%-- 资讯左侧导航 End --%>

            <div class="articlecontent">

                <p class="title">设计知识</p>

                <div class="articlebody">

                    <asp:Repeater runat="server" ID="repArticle">
                        <ItemTemplate>
                            <a href="articledetail.aspx?id=<%#Eval("Id") %>" class="articlelist">
                                <p class="name"><%#Eval("Title") %></p>
                                <p class="remark"><%#Eval("Abstract") %></p>
                                <p class="time"><%# Convert.ToDateTime(Eval("Addtime").ToString()).ToString("yyyy-MM-dd") %></p>
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>



                </div>
                <div class="articlepage">
                    <div class="page flickr">
                    </div>
                </div>

            </div>



        </div>

    </div>
    <!--正文 Begin-->

    <!--底部 Begin-->
    <uc1:Footer runat="server" ID="Footer" />
    <!--底部 End-->

    <script src="Vanyin/js/jquery.pagination.js"></script>

    <script>
        $(function () {

            $(".page").pagination(<%= pcount %>, {
                callback: pageselectCallback,
                prev_text: "上一页",
                next_text: "下一页",
                items_per_page:<%= pagesize%>,
                num_display_entries:3,
                current_page:<%= page%>,
                num_edge_entries:3,
                link_to:"?page=__id__<%= strUrl.ToString()%>"
            });

            switch("<%= typeid%>")
            {
                case "10000":
                    $(".articlemenu a").eq(1).addClass("active");
                    break;
                case "10001":
                    $(".articlemenu a").eq(0).addClass("active");
                    break;
                case "10002":
                    $(".articlemenu a").eq(2).addClass("active");
                    break;
            }


                
        })

         function pageselectCallback(page_id, jq) {
             //alert(page_id); 回调函数，进一步使用请参阅说明文档
         }

    </script>

</body>

</html>
