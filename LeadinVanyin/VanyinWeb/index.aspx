<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LeadinWeb.index1" %>


<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>



<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>万印网首页</title>
    <link rel="stylesheet" type="text/css" href="/css/style.css" />
    <link href="css/index.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="/css/swiper.min.css" />
    <link href="/css/showdetail.css" rel="stylesheet" />
</head>

<body>

    <!--头部导航 Begin-->
    <uc1:Header runat="server" ID="Header" />
    <!--头部导航 End-->

    <!--首页Banner Begin-->
    <div id="banner">
        <div class="banner">
            <div class="swiper-container swiperbanner">
                <div class="swiper-wrapper">
                    <asp:Repeater runat="server" ID="repBanner">
                        <ItemTemplate>
                            <div class="swiper-slide red-slide">
                                <img src="<%#Eval("ImgUrl") %>" />
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="pagination"></div>
            </div>
        </div>
    </div>
    <!--首页Banner End-->

    <!--正文 Begin-->
    <div id="content">

        <!--展览展示 Begin-->
        <div class="exhibition">

            <!--微博秀 Begin-->
            <div class="weibo">
                <iframe width="210" height="195" class="share_self" frameborder="0" scrolling="no" src="http://widget.weibo.com/weiboshow/index.php?language=&width=210&height=195&fansRow=2&ptype=0&speed=100&skin=1&isTitle=1&noborder=1&isWeibo=1&isFans=0&uid=1828618634&verifier=7761d223&colors=dcdcdc,f7fcf6,666666,64934d,ecfbfd&dpc=1"></iframe>
            </div>
            <!--微博秀 End-->

            <!--展览展示 Begin-->
            <ul class="box exhibi">
                <li class="link">
                    <p class="title">展览展示</p>
                    <p class="subtitle">一站式解决方案</p>
                    <a href="Exhibition.aspx">展览策划</a>
                    <a href="Exhibition.aspx">展台设计</a>
                    <a href="Exhibition.aspx">展台搭建</a>
                    <a href="Exhibition.aspx">项目执行</a>
                </li>
                <li class="img">
                    <a href="Exhibition.aspx">
                        <img src="img/index/exhibitionbg.png" /></a>
                </li>
            </ul>
            <!--展览展示 End-->

            <!--会务活动 Begin-->
            <ul class="box exhibi">
                <li class="link">
                    <p class="title">会务活动</p>
                    <p class="subtitle">全方位支持方案</p>
                    <a href="Conference.aspx">活动策划</a>
                    <a href="Conference.aspx">物料设计制作</a>
                    <a href="Conference.aspx">活动执行</a>
                </li>
                <li class="img">
                    <a href="Conference.aspx">
                        <img src="img/index/activity.png" /></a>
                </li>
            </ul>
            <!--会务活动 End-->
        </div>
        <!--展览展示 End-->

        <!--设计模版 Begin-->
        <div class="design">
            <div class="designtop">
                <p>畅销模版</p>
                <ul class="type">
                    <asp:Repeater runat="server" ID="repTemplateType">
                        <ItemTemplate>
                            <li><span><%# Eval("Title") %></span><input type="hidden" name="hidTypeId" value="<%#Eval("Id") %>" /></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>

            <ul class="designhot">
                <li class="template220 temli1">
                    <p class="name"><%=defaultTemplateTypeName %></p>
                    <p class="remark"><%=defaultTemplateTypeRemark %></p>
                    <a class="more" href="design.aspx?type=<%=defaultTemplateTypeId %>">更多模版&nbsp;&nbsp;>></a>
                </li>
                <asp:Repeater runat="server" ID="repBigTemplate">
                    <ItemTemplate>
                        <li class="template440 temli2">
                            <a class="temabox" href="javascript:void(0)" onclick="ShowDetail('<%#Eval("TemplateId") %>')">
                                <img src="<%#Eval("ImgUrl") %>" />
                                <div class="nameprice">
                                    <p><%#Eval("TemplateTitle") %></p>
                                    <p><span><%#Eval("Price") %></span></p>
                                </div>
                            </a>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
                <li class="template4402">
                    <div class="swiper-container swiperdesign">
                        <div class="swiper-wrapper">
                            <asp:Repeater runat="server" ID="repSwiperTemplate">
                                <ItemTemplate>
                                    <div class="swiper-slide">
                                        <a href="javascript:void(0)" onclick="ShowDetail('<%#Eval("TemplateId") %>')">
                                            <img src="<%# Eval("ImgUrl") %>" />
                                            <div class="nameprice">
                                                <p><%#Eval("TemplateTitle") %></p>
                                                <p><span><%#Eval("Price") %></span></p>
                                            </div>
                                        </a>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                        <div class="paginationdesign"></div>
                    </div>

                </li>
                <asp:Repeater runat="server" ID="repSmallTemplate">
                    <ItemTemplate>
                        <li class="template220">
                            <a class="temabox" href="javascript:void(0)" onclick="ShowDetail('<%#Eval("TemplateId") %>')">
                                <img src="<%# Eval("ImgUrl") %>" />
                                <div class="nameprice">
                                    <p><%#Eval("TemplateTitle") %></p>
                                    <p><span><%#Eval("Price") %></span></p>
                                </div>
                            </a>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>

            </ul>

        </div>
        <!--设计模版 End-->

        <!--印刷精品 Begin-->
        <ul class="printcase">
            <li class="caseli1">
                <p class="name">印刷精品</p>
                <p class="remark">各式名片优质模板供您选择，设计印刷一站式体验</p>
                <a class="more" href="#">更多模版&nbsp;&nbsp;>></a>
            </li>
            <li class="caseli2">
                <a class="temabox" href="#">
                    <img src="img/index/printimg/printimg1.jpg" />
                    <div class="nameprice">
                        <p>绿色科技感名片模板</p>
                        <p><span>名片</span></p>
                    </div>
                </a>
            </li>
            <li class="caseli3">

                <div class="swiper-container swiperprint">
                    <div class="swiper-wrapper">
                        <div class="swiper-slide blue-slide">
                            <a href="#">
                                <img src="img/index/printimg/printimg3.jpg" />
                                <div class="nameprice">
                                    <p>绿色科技感名片模板1</p>
                                    <p><span>100元</span></p>
                                </div>
                            </a>
                        </div>
                        <div class="swiper-slide red-slide">
                            <a href="#">
                                <img src="img/index/printimg/printimg3.jpg" />
                                <div class="nameprice">
                                    <p>绿色科技感名片模板2</p>
                                    <p><span>100元</span></p>
                                </div>
                            </a>
                        </div>
                        <div class="swiper-slide orange-slide">
                            <a href="#">
                                <img src="img/index/printimg/printimg3.jpg" />
                                <div class="nameprice">
                                    <p>绿色科技感名片模板3</p>
                                    <p><span>100元</span></p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="paginationprint"></div>
                </div>

            </li>
            <li class="caseli4">
                <a class="temabox" href="#">
                    <img src="img/index/printimg/printimg2.jpg" />
                    <div class="nameprice">
                        <p>绿色科技感名片模板</p>
                        <p><span>100元</span></p>





                    </div>
                </a>
            </li>
            <li class="caseli5">
                <a class="temabox" href="#">
                    <img src="img/index/printimg/printimg2.jpg" />
                    <div class="nameprice">
                        <p>绿色科技感名片模板</p>
                        <p><span>100元</span></p>
                    </div>
                </a>
            </li>
            <li class="caseli6">
                <a class="temabox" href="#">
                    <img src="img/index/printimg/printimg1.jpg" />
                    <div class="nameprice">
                        <p>绿色科技感名片模板</p>
                        <p><span>100元</span></p>
                    </div>
                </a>
            </li>
            <li class="caseli7">
                <a class="temabox" href="#">
                    <img src="img/index/printimg/printimg1.jpg" />
                    <div class="nameprice">
                        <p>绿色科技感名片模板</p>
                        <p><span>100元</span></p>
                    </div>
                </a>
            </li>
        </ul>
        <!--印刷精品 End-->

        <!--工艺展示 Begin-->
        <div class="echnology">
            <div class="echnologyleft">
                <p class="name">工艺材质</p>
                <p class="remark">多种工艺呈现&nbsp;&nbsp;&nbsp;&nbsp;尽显完美印品</p>
            </div>
            <div class="echnologylist">
                <div class="swiper-container swiperecno">
                    <div class="swiper-wrapper">
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />

                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                        <div class="swiper-slide">
                            <img src="img/index/echnologyimg.jpg" />
                        </div>
                    </div>
                </div>

            </div>

        </div>
        <!--工艺展示 End-->

        <!--数码快印 Begin-->
        <div class="digital">
            <div class="digitaltop">
                <p>数码快印</p>
                <a href="#">更多门店 <span>>></span></a>
            </div>

            <div class="digitalbox">

                <div class="digitalleft">
                    <ul>
                        <asp:Repeater runat="server" ID="repStoreCity">
                            <ItemTemplate>
                                <li>
                                    <p><%# GetCityName(Eval("Id").ToString()) %></p>
                                    <input type="hidden" name="hidStoreCity" value="<%#Eval("Id") %>" />
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>


                    </ul>
                </div>
                <div class="digitallist">

                    <asp:Repeater runat="server" ID="repStore">
                        <ItemTemplate>
                            <ul>
                                <li class="img">
                                    <a href="#">
                                        <img src="img/index/digitalimg.jpg" /></a>
                                </li>
                                <li class="detail">
                                    <a class="title" href="#">万印网闵行北桥店</a>
                                    <p>地址：上海市闵行区沪闵路沪闵汽配用品城 </p>
                                    <p>营业时间：8:00-19:00 </p>
                                    <p>支付方式：刷卡*，现金，支付宝 </p>
                                </li>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>




                </div>
            </div>

        </div>
        <!--数码快印 End-->

        <!--新闻资讯 Begin-->
        <div class="news">
            <div class="newsindustry">
                <ul class="industrylist">
                    <li class="title">
                        <p>行业资讯</p>
                        <a href="article.aspx?type=10002">更多<span>>></span></a></li>
                    <asp:Repeater runat="server" ID="repNews">
                        <ItemTemplate>
                            <li class="name">
                                <a href="articledetail.aspx?id=<%#Eval("Num") %>">
                                    <p><%#Eval("Title") %></p>
                                </a>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>


                </ul>

            </div>
            <asp:Repeater runat="server" ID="repNewDesign">
                <ItemTemplate>
                    <ul class="newsprint">
                        <li class="title"><a href="articledetail.aspx?id=<%#Eval("Num") %>">
                            <p><%#Eval("Title") %></p>
                        </a></li>
                        <li class="detail">
                            <img src="<%#Eval("ImgUrl") %>" />

                            <div class="remark">
                                <div class="remarkbox">
                                    <p><%#Leadin.Common.Utils.CutString(Eval("Abstract").ToString(),320) %></p>
                                </div>
                                <a href="articledetail.aspx?id=<%#Eval("Num") %>"></a>
                            </div>

                        </li>
                    </ul>
                </ItemTemplate>
            </asp:Repeater>

            <asp:Repeater runat="server" ID="repNewPrint">
                <ItemTemplate>
                    <ul class="newsprint">
                        <li class="title"><a href="articledetail.aspx?id=<%#Eval("Num") %>">
                            <p><%#Eval("Title") %></p>
                        </a></li>
                        <li class="detail">
                            <img src="<%#Eval("ImgUrl") %>" />

                            <div class="remark">
                                <div class="remarkbox">
                                    <p><%#Leadin.Common.Utils.CutString(Eval("Abstract").ToString(),320) %></p>
                                </div>
                                <a href="articledetail.aspx?id=<%#Eval("Num") %>"></a>
                            </div>

                        </li>
                    </ul>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <!--新闻资讯 End-->

    </div>
    <!--正文 Begin-->

    <!--底部 Begin-->
    <uc1:Footer runat="server" ID="Footer" />
    <!--底部 End-->


    <script src="js/swiper.min.js" charset="utf-8"></script>
    <script src="js/jquery.showdetail.js"></script>
    <script src="js/jquery.index.js" charset="utf-8"></script>

</body>

</html>
