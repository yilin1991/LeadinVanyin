<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="LeadinWeb.Vanyin.Article.Article.List" %>

<%@ Register Src="~/Vanyin/Controls/left.ascx" TagPrefix="uc1" TagName="left" %>
<%@ Register Src="~/Vanyin/Controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>



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
    <link rel="stylesheet" type="text/css" href="/Vanyin/css/List.css" />
    <link href="/Vanyin/css/pagination.css" rel="stylesheet" />
    <link href="/Vanyin/css/message.css" rel="stylesheet" />
    <script src="/Vanyin/js/jquery-1.11.1.min.js" charset="utf-8"></script>
    <script src="/Vanyin/js/jquery.message.js"></script>
</head>

<body>
    <form id="myform" runat="server">
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
                        <li><a href="/Vanyin/index.aspx">首页</a></li>
                        <li>></li>
                        <li><a href="../Template/List.aspx">模版管理</a></li>
                        <li>></li>
                        <li>模版列表</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <ul class="search row">
                        <li class="small">类别名称：</li>
                        <li>
                            <asp:DropDownList runat="server" ID="ddltype">
                                <asp:ListItem Value="0">请选择模版类别</asp:ListItem>
                            </asp:DropDownList>

                        </li>
                         
                        <li>
                            <asp:DropDownList runat="server" ID="ddlKey">
                                <asp:ListItem Value="0">请选择搜索类别</asp:ListItem>
                                <asp:ListItem Value="1">门店编号</asp:ListItem>
                                <asp:ListItem Value="2">关键字</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                        <li>
                            <asp:TextBox runat="server" ID="txtKey" placeholder="请输入类别名称关键字"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnSearch" Text="搜索" OnClick="btnSearch_Click" />
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnAllList" Text="查看全部" OnClick="btnAllList_Click" />
                        </li>
                    </ul>

                    <ul class="operation">
                        <li class="operadd"><a href="Edit.aspx"><i class="icon-plus"></i>添加</a></li>
                    </ul>

                    <div class="listtable">
                        <ul class="tbtitle">
                            <li class="allselect">
                                <input type="checkbox" name="ckAll" id="ckAll" value="" /></li>
                            <li style="width: 100px;">操作</li>
                            <li style="width: 100px;">编号</li>
                            <li style="width: 200px;">资讯标题</li> 
                            <li style="width: 200px;">副标题</li>
                            <li style="width: 100px;">资讯类别</li>
                            <li style="width: 100px;">资讯状态</li>
                            <li style="width: 150px;">资讯属性</li>
                            <li style="width: 100px;">作者</li>
                            <li style="width: 200px;">关键字</li>
                            <li style="width: 150px;">资讯来源</li>
                            <li style="width: 200px;">资讯描述</li>
                            <li style="width: 200px;">资讯导读</li>
                            <li style="width: 100px;">添加时间</li>
                        </ul>

                        <asp:Repeater runat="server" ID="repList" OnItemCommand="repList_ItemCommand">
                            <ItemTemplate>
                                <ul class="listli">
                                    <li class="allselect">
                                        <asp:CheckBox runat="server" ID="ckSelect" />
                                    </li>
                                    <li class="operli" style="width: 100px;">
                                        <a class="operliedit" href="Edit.aspx?id=<%#Eval("Id") %>&page=<%# page+strUrl.ToString() %>" title="编辑"><i class="icon-edit"></i></a>   
                                    </li>
                                    <li style="width: 100px;">
                                        <asp:HiddenField runat="server" ID="hidid" Value='<%# Eval("Id") %>' />
                                        <asp:Label runat="server" ID="lbid" Text='<%# Eval("Num") %>'></asp:Label></li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("Title") %>"><%#Eval("Title") %></a></li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("SubTitle") %>"><%#Eval("SubTitle") %></a></li>
                                     <li style="width: 100px;"><%#GetTypeName(Eval("TypeId").ToString()) %></li>   
                                    <li class="state" style="width: 100px;">
                                        <asp:LinkButton runat="server" ID="lbtnState" CommandName="lbtnState"><i class="<%# string.Equals(Eval("StateInfo").ToString(),"0")?"icon-remove-sign":"icon-ok-sign" %>")"></i></asp:LinkButton></li>
                                    <li class="listattr" style="width: 150px;">
                                          <asp:LinkButton runat="server" ID="lbtnIndex" CssClass='<%# string.Equals(Eval("IsIndex").ToString(),"0")?"attrred":"attrgreen" %>' CommandName="lbtnIndex" ToolTip="首页"><i class="icon-home"></i></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbtnhot" CssClass='<%# string.Equals(Eval("IsHot").ToString(),"0")?"attrred":"attrgreen" %> ' CommandName="lbtnhot" ToolTip="热门"><i class="icon-bell-alt"></i></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="lbtnRec" CssClass='<%# string.Equals(Eval("IsRec").ToString(),"0")?"attrred":"attrgreen" %>' CommandName="lbtnRec" ToolTip="推荐"><i class="icon-thumbs-up"></i></asp:LinkButton>
                                    </li>
                                    <li style="width: 100px;"><%#Eval("Author") %> </li>
                                  
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("StrKey") %>"><%#Eval("StrKey") %></a> </li>
                                    <li style="width: 150px;"><a class="suba" title="<%#Eval("SourceInfo") %>"><%#Eval("SourceInfo") %></a> </li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("Describe") %>"><%#Eval("Describe") %></a> </li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("Introduction") %>"><%#Eval("Introduction") %></a> </li>
                                    <li style="width: 100px;"><%#Convert.ToDateTime(Eval("AddTime")).ToString("yyyy-MM-dd") %> </li>
                                </ul>

                            </ItemTemplate>
                        </asp:Repeater>
                    </div>


                    <div class="pageBox">
                        <div class="pageBoxNum">
                            <span>共</span>
                            <span><%= pcount %></span>
                            <span>条数据，</span>
                            <span>共</span>
                            <span><%= Math.Ceiling(decimal.Parse(pcount.ToString())/pagesize) %></span>
                            <span>页，</span>
                            <span>当前显示第</span>
                            <span><%= string.IsNullOrWhiteSpace(Request.Params["page"])?1:int.Parse(Request.Params["page"])+1 %></span>
                            <span>页</span>
                        </div>
                        <div class="pageControls">
                            <div class="page flickr">
                            </div>
                        </div>
                    </div>


                </div>

                <!--页面内容 End-->

            </div>
            <!--正文 End-->
        </div>
    </form>
    <script src="/Vanyin/js/jquery.admin.js" charset="utf-8"></script>
    <script src="/Vanyin/js/jquery.pagination.js"></script>
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
            $("#ckAll").click(function(){               
                var check= $(this).prop("checked");
                $("input[type=checkbox]").each(function(){
                    $(this).prop("checked",check);
                })              
            })


            SetLeftMenu("资讯管理","资讯列表");


          
        })

        function pageselectCallback(page_id, jq) {
            //alert(page_id); 回调函数，进一步使用请参阅说明文档
        }




    </script>

</body>

</html>
