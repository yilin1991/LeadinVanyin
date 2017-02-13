<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="LeadinWeb.Vanyin.Member.Type.List" %>

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
                        <li><a href="../Member/List.aspx">会员管理</a></li>
                        <li>></li>
                        <li>会员类别管理</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <ul class="search row">
                        <li class="small">类别名称：</li>
                        <li>
                            <asp:TextBox runat="server" ID="txtKey" Enabled="false" placeholder="请输入类别名称关键字"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnSearch" Enabled="false" Text="搜索"/>
                        </li>
                        <li>
                            <asp:Button runat="server" ID="btnAllList" Enabled="false" Text="查看全部"/>
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
                            <li style="width: 200px;">名称</li>
                            <li style="width: 100px;">排序</li>
                            <li style="width: 100px;">状态</li>
                        </ul>

                        <asp:Repeater runat="server" ID="repList" OnItemCommand="repList_ItemCommand">
                            <ItemTemplate>
                                <ul class="listli">
                                    <li class="allselect">
                                      <asp:CheckBox runat="server" ID="ckSelect" />
                                    </li>
                                    <li class="operli" style="width: 100px;">
                                       <a class="operliedit" href="Edit.aspx?id=<%#Eval("Id") %>" title="编辑"><i class="icon-edit"></i></a>                                    
                                    </li>
                                    <li style="width: 100px;">
                                        <asp:Label runat="server" ID="lbid" Text='<%# Eval("Id") %>'></asp:Label></li>
                                    <li style="width: 200px;"><a class="suba" title="<%#Eval("Title") %>"><%#Eval("Title") %></a></li>
                                    <li style="width: 100px;"><%#Eval("SortNum") %> </li>
                                    <li class="state" style="width: 100px;">
                                        <asp:LinkButton runat="server" ID="lbtnState" CommandName="lbtnState"><i class="<%# string.Equals(Eval("StateInfo").ToString(),"0")?"icon-remove-sign":"icon-ok-sign" %>")"></i></asp:LinkButton></li>
                                </ul>

                            </ItemTemplate>
                        </asp:Repeater>
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

            
            $("#ckAll").click(function(){               
                var check= $(this).prop("checked");
                $("input[type=checkbox]").each(function(){
                    $(this).prop("checked",check);
                })              
            })

            SetLeftMenu("会员管理","类别管理");


        })

        

    </script>

</body>

</html>

