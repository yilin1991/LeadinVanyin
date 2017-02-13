<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="LeadinWeb.Vanyin.DesignTemplate.Type.List" %>

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
    <!--<link rel="stylesheet" type="text/css" href="css/flat-ui.min.css"/>-->
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
                        <li><a href="List.aspx">模版类别管理</a></li>
                        <li>></li>
                        <li>模版类别列表</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <ul class="search row">
                        <li class="small">类别名称：</li>
                        <%--<li>
                            <select name="selctname">
                                <option value="0">请选择类别</option>
                            </select></li>
                        <li>
                            <select name="selctname">
                                <option value="0">请选择类别</option>
                            </select></li>--%>
                        <li>
                            <%--<input type="text" name="txtkey" id="txtkey" value=""  />--%>
                            <asp:TextBox runat="server" ID="txtKey" placeholder="请输入类别名称关键字"></asp:TextBox>
                        </li>
                        <li>
                            <%--<button>搜索</button>--%>
                            <asp:Button runat="server" ID="btnSearch" Text="搜索" OnClick="btnSearch_Click"/>
                        </li>
                        <li>
                            <%--<input type="button" id="btnserach" value="查看全部" />--%>
                            <asp:Button runat="server" ID="btnAllList" Text="查看全部" OnClick="btnAllList_Click"/>
                        </li>
                        <%--<li>
                            <input type="button" id="Button1" value="查看全部" /></li>--%>
                       <%-- <li>
                            <button>搜索</button></li>--%>
                    </ul>

                    <ul class="operation">
                        <li class="operadd"><a href="Edit.aspx"><i class="icon-plus"></i>添加</a></li>
                        <%--<li class="operedit"><a href="#"><i class="icon-pencil"></i>修改</a></li>--%>
                       <%-- <li class="operdel"><asp:LinkButton runat="server" ID="lbtndels" OnClick="lbtndels_Click"  OnClientClick="return confirm('删除后不可恢复，确认删除吗？')"><i class="icon-remove"></i>删除</asp:LinkButton></li>--%>
                    </ul>

                    <div class="listtable">
                        <ul class="tbtitle">
                            <li class="allselect">
                                <input type="checkbox" name="ckAll" id="ckAll" value="" /></li>
                            <li style="width: 100px;">操作</li>
                            <li style="width: 100px;">编号</li>
                            <li style="width: 200px;">名称</li>
                            <li style="width: 100px;">关键字</li>
                            <li style="width: 100px;">排序</li>
                            <li style="width: 200px;">副标题</li>
                            <li style="width: 100px;">状态</li>
                            <li style="width: 100px;">热门类别</li>
                            <li style="width: 100px;">价格</li>
                            <li style="width: 100px;">设计周期</li>
                            
                            <li style="width: 100px;">添加时间</li>
                        </ul>

                        <asp:Repeater runat="server" ID="repList" OnItemCommand="repList_ItemCommand">
                            <ItemTemplate>
                                <ul class="listli">
                                    <li class="allselect">
                                      <asp:CheckBox runat="server" ID="ckSelect" />
                                    </li>
                                    <li class="operli" style="width: 100px;">
                                        <%--<a class="operliadd" href="#" title="添加"><i class="icon-plus-sign"></i></a>--%>
                                        <a class="operliedit" href="Edit.aspx?id=<%#Eval("Id") %>&page=<%# page+strUrl.ToString() %>" title="编辑"><i class="icon-edit"></i></a>
                                        <%--<a class="operlidel" href="#" title="删除"></a>--%>
                                       <%-- <asp:LinkButton runat="server" CssClass="operlidel" ID="lbtnDel" ToolTip="删除"  OnClientClick="return confirm('删除后不可恢复，确认删除吗？')" CommandName="lbtnDel"><i class="icon-trash"></i></asp:LinkButton>--%>
                                        <%--<a class="operliready" href="#" title="删除"><i class="icon-file-alt"></i></a>--%>
                                    </li>
                                    <li style="width: 100px;">
                                        <asp:Label runat="server" ID="lbid" Text='<%# Eval("Id") %>'></asp:Label></li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("Title") %>"><%#Eval("Title") %></a></li>
                                      <li style="width: 100px;"><%#Eval("Typekey") %> </li>
                                    <li style="width: 100px;"><%#Eval("SortNum") %> </li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("SubTitle") %>"><%#Eval("SubTitle") %></a></li>
                                    <li class="state" style="width: 100px;">
                                        <asp:LinkButton runat="server" ID="lbtnState" CommandName="lbtnState"><i class="<%# string.Equals(Eval("StateInfo").ToString(),"0")?"icon-remove-sign":"icon-ok-sign" %>")"></i></asp:LinkButton></li>
                                    <li class="state" style="width: 100px;">
                                        <asp:LinkButton runat="server" ID="lbtnHot" CommandName="lbtnHot"><i class="<%# string.Equals(Eval("DetailRemark").ToString(),"0")?"icon-remove-sign":"icon-ok-sign" %>")"></i></asp:LinkButton></li>
                                    <li style="width: 100px;"><%#Eval("Price") %></li>
                                    <li style="width: 100px;"><%#Eval("Cycle") %></li>
                                    
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

            SetLeftMenu("设计模版管理","类别管理");


        })

        function pageselectCallback(page_id, jq) {
            //alert(page_id); 回调函数，进一步使用请参阅说明文档
        }







    </script>

</body>

</html>
