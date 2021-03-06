﻿<%@ Page Language="C#" AutoEventWireup="true" enableEventValidation="false" CodeBehind="Edit.aspx.cs" Inherits="LeadinWeb.Vanyin.Store.Store.Edit" %>


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
    <link rel="stylesheet" type="text/css" href="/Vanyin/css/inputStyle.css" />
    <link href="/Vanyin/css/upload.css" rel="stylesheet" />
    <link href="/Vanyin/css/message.css" rel="stylesheet" />

     <script src="/Vanyin/js/jquery-1.11.1.min.js" charset="utf-8"></script>
     <script src="/Vanyin/js/jquery.message.js"></script>

</head>

<body>
    <form class="form-horizontal" id="myfrom" runat="server">
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
                        <li><a href="../Product/List.aspx">门店管理</a></li>
                        <li>></li>
                        <li><a href="List.aspx"></a></li>
                        <li>></li>
                        <li>兑换商品类别编辑</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <div class="editTop">
                        <span>基本信息</span>
                    </div>
                    <div class="editForm">



                        <div class="control-group">
                            <label class="control-label" for="txtName">门店名称</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtName" CssClass="inputWidth2" datatype="*" nullmsg="请输入门店名称！" errormsg="门店名称不能为空！"></asp:TextBox>
                                <span class="help-inline">请填写门店名称！</span>
                            </div>
                        </div>
                      
                     
                        <div class="control-group">
                            <label class="control-label" for="ddlType">门店类别</label>
                            <div class="controls">
                                <asp:DropDownList runat="server" ID="ddlType" DataMember="5"  datatype="*" nullmsg="请选择门店类别！" errormsg="门店类别不能为空！">
                                    <asp:ListItem Value="">请选择门店类别</asp:ListItem>
                                </asp:DropDownList>
                                <span class="help-inline">请填写门店类别！</span>
                            </div>
                        </div>
                       
                          
                        <div class="control-group">
                            <label class="control-label" for="ddlCity">所在城市</label>
                            <div class="controls">
                                <asp:DropDownList runat="server" ID="ddlCity" >
                                   
                                </asp:DropDownList>
                                <asp:DropDownList runat="server" ID="ddlSubCity" datatype="*" nullmsg="请选择商品类别！" errormsg="商品类别不能为空！">
                                 
                                </asp:DropDownList>
                                 <span class="help-inline">请填写所在城市！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtAddress">门店地址</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtAddress" CssClass="inputWidth2"  datatype="*" nullmsg="请输入门店地址！" errormsg="门店地址不能为空！"></asp:TextBox>
                                <span class="help-inline">请输入门店地址！</span>
                            </div>
                        </div>
                         <div class="control-group">
                            <label class="control-label" for="txtfileico1">门店图片</label>
                            <div class="controls " >

                                <ul class="filebox">
                                    <li class="txtfilename"><asp:TextBox runat="server" ID="txtfileico1" CssClass="inputWidth2" datatype="*" nullmsg="请上传门店图片！" errormsg="门店图片不能为空！"></asp:TextBox></li>
                                    <li class="btnfilea"><a href="javascript:void(0)" onclick="btnfileaclick($(this))" class="btnfilebtn">上传图片</a></li>
                                    <li class="fileinput"><input type="file" name="fileuploadico" id="fileuploadico" onchange="fileonchange($(this),'myfrom')" /></li>
                                    <li class="filemessage"> <span class="help-inline">请上传门店图片！</span></li>
                                </ul>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtBeginTime">营业时间</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtBeginTime" CssClass="inputWidth2"  datatype="*" nullmsg="请输入营业时间！" errormsg="营业时间不能为空！"></asp:TextBox>
                                <span class="help-inline">请输入营业时间！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtPayType">支付方式</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtPayType" CssClass="inputWidth2" datatype="*" nullmsg="请输入支付方式！" errormsg="请输入支付方式！"></asp:TextBox>
                                <span class="help-inline">请输入支付方式！</span>
                            </div>
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label" for="txtScope">主营业务</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtScope" CssClass="inputWidth2"></asp:TextBox> 
                            </div>
                        </div>                 
                        <div class="control-group">
                            <label class="control-label" for="txtContent">门店详情</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtContent" TextMode="MultiLine" CssClass="inputWidth4 inputHeight2"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtSortNum">门店排序</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtSortNum" CssClass="inputWidth1" Text="1" datatype="n" nullmsg="请输入门店排序！" errormsg="请输入正确的门店排序（整数）！"></asp:TextBox>
                                <span class="help-inline">请输入门店排序！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label">门店属性</label>
                            <div class="controls">
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckIndex" />首页
                                </label>
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckHot" />热门
                                </label>
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckRec" />推荐
                                </label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="ckState">门店状态</label>
                            <div class="controls">
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckState" Checked="true" />勾选表示显示
                                </label>
                            </div>
                        </div>

                        <div class="form-actions">
                            <asp:Button runat="server" ID="btnOk" CssClass="btn" Text="确认提交" OnClick="btnOk_Click" />
                            <input type="reset" class="btn" value="重置" />
                        </div>




                    </div>




                </div>

                <!--页面内容 End-->

            </div>
            <!--正文 End-->
        </div>
       
        <script src="/Vanyin/js/jquery.admin.js" charset="utf-8"></script>
        <script src="/Vanyin/js/Validform_v5.3.2.js"></script>
        <script src="/Vanyin/js/jquery.form.min.js"></script>
        <script src="/Vanyin/js/jquery.uploadfile.js"></script>
        <script src="/Vanyin/js/jquery.leadinupload.js"></script>
           <script src="/kindeditor-4.1.10/kindeditor.js"></script>
    <script src="/kindeditor-4.1.10/lang/zh_CN.js"></script>
        <script>

            $(function () {

                $(".form-horizontal").Validform({
                    tiptype: function (msg, o, cssctl) {
                        //msg：提示信息;
                        //o:{obj:*,type:*,curform:*}, obj指向的是当前验证的表单元素（或表单对象），type指示提示的状态，值为1、2、3、4， 1：正在检测/提交数据，2：通过验证，3：验证失败，4：提示ignore状态, curform为当前form对象;
                        //cssctl:内置的提示信息样式控制函数，该函数需传入两个参数：显示提示信息的对象 和 当前提示的状态（既形参o中的type）;
                        if (!o.obj.is("form")) {//验证表单元素时o.obj为该表单元素，全部验证通过提交表单时o.obj为该表单对象;
                            var objtip = o.obj.siblings(".help-inline");
                            if (o.type == 2) {

                                objtip.removeClass("error").addClass("success");
                            }
                            else if (o.type == 3) {
                                objtip.removeClass("success").addClass("error");
                            }
                            cssctl(objtip, o.type);
                            objtip.text(msg);
                        } else {
                            var objtip = o.obj.find("#msgdemo");
                            cssctl(objtip, o.type);
                            objtip.text(msg);
                        }
                    }


                });

                SetLeftMenu("门店管理", "添加门店");



                KindEditor.ready(function (K) {
                    var editor1 = K.create('#txtContent', {
                        cssPath: '/kindeditor-4.1.10/plugins/code/prettify.css',
                        uploadJson: '/Tools/upload_json.ashx',
                        fileManagerJson: '/kindeditor-4.1.10/asp.net/file_manager_json.ashx',
                        allowFileManager: true
                    });
                });



                $("#ddlCity").change(function () {

                    var cid=$(this).val();
                   
                    $.ajax({
                        type: "POST",
                        url: "Edit.aspx/SetChange",
                        //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字  
                        data: "{ 'cid':"+  cid+"}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (data) {
                            //返回的数据用data.d获取内容  
                            
                            $("#ddlSubCity").html(data.d);

                        },
                        error: function (err) {
                            alert(err);
                        }
                    });


                })



            })

        </script>


    </form>
</body>

</html>

