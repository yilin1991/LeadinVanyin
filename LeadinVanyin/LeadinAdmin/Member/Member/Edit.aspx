<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Edit.aspx.cs" Inherits="LeadinWeb.Vanyin.Member.Member.Edit" %>

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
                        <li><a href="List.aspx">会员管理</a></li>
                        <li>></li>
                        <li>编辑会员</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <div class="editTop">
                        <span>基本信息</span>
                    </div>
                    <div class="editForm">



                        <div class="control-group">
                            <label class="control-label" for="txtAccount">帐号</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtAccount" CssClass="inputWidth2" nullmsg="请输入帐号！" errormsg="请输入帐号！"></asp:TextBox>
                                <span class="help-inline">请填写帐号！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtPhone">手机号</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtPhone" CssClass="inputWidth2" nullmsg="请输入手机号！" errormsg="请输入手机号！"></asp:TextBox>
                                <span class="help-inline">请输入手机号！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtEmail">邮箱</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="inputWidth2" nullmsg="请输入邮箱！" errormsg="请输入邮箱！"></asp:TextBox>
                                <span class="help-inline">请输入邮箱！</span>
                            </div>
                        </div>
                         <div class="control-group">
                            <label class="control-label" for="txtPass">密码</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtPass" CssClass="inputWidth2" TextMode="Password" datatype="s6-18" nullmsg="请输入6-18位字母数字组合的密码！" errormsg="请输入6-18位字母数字组合的密码！"></asp:TextBox>
                                <span class="help-inline">请输入6-18位字母数字组合的密码！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtRecpass">确认密码</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtRecpass" CssClass="inputWidth2" recheck="txtPass"  TextMode="Password" datatype="*" nullmsg="请确认您的密码！" errormsg="两次密码输入不一致，请重新输入！"></asp:TextBox>
                                <span class="help-inline">请确认您的密码！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="ddlType">会员类别</label>
                            <div class="controls">
                                <asp:DropDownList runat="server" ID="ddlType" DataMember="5"  datatype="*" nullmsg="请选择会员类别！" errormsg="会员类别不能为空！">
                                    <asp:ListItem Value="">请选择会员类别</asp:ListItem>
                                </asp:DropDownList>
                                 <span class="help-inline">请选择会员类别！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtHeaderImg">头像</label>
                            <div class="controls " >

                                <ul class="filebox">
                                    <li class="txtfilename"><asp:TextBox runat="server" ID="txtHeaderImg" CssClass="inputWidth2"></asp:TextBox></li>
                                    <li class="btnfilea"><a href="javascript:void(0)" onclick="btnfileaclick($(this))" class="btnfilebtn">上传图片</a></li>
                                    <li class="fileinput"><input type="file" name="fileuploadico" id="fileuploadico" onchange="fileonchange($(this),'myfrom')" /></li>
                                </ul>
                            </div>
                        </div>
                          

                       <div class="control-group">
                            <label class="control-label">性别</label>
                            <div class="controls">
                                <label class="checkbox">
                                    <asp:RadioButton runat="server" ID="rbman" Checked="true" GroupName="sex"/>  男
                                </label>
                                <label class="checkbox">
                                    <asp:RadioButton runat="server" ID="rbwoman"  GroupName="sex"/>  女
                                </label>
                                <label class="checkbox">
                                    <asp:RadioButton runat="server" ID="rbsecrecy"  GroupName="sex"/>  保密
                                </label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtAge">年龄</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtAge" CssClass="inputWidth1" ignore="ignore" datatype="n" nullmsg="请输入年龄！" errormsg="请输入正确的年龄（整数）！"></asp:TextBox>
                                <span class="help-inline">请输入年龄！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtCompanyName">公司名称</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtCompanyName" CssClass="inputWidth3" ></asp:TextBox>
                                
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtCompanyAddress">公司地址</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtCompanyAddress" CssClass="inputWidth3"></asp:TextBox>
                            </div>
                        </div>
                         <div class="control-group">
                            <label class="control-label" for="txtPosition">职位</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtPosition"  CssClass="inputWidth3"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtName">姓名</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtName" CssClass="inputWidth3"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtSubName">别名</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtSubName" CssClass="inputWidth3"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtAddress">详细地址</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtAddress" CssClass="inputWidth3"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="txtRemark">会员简介</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtRemark" TextMode="MultiLine" CssClass="inputWidth4 inputHeight2"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="ckState">会员状态</label>
                            <div class="controls">
                                <label class="checkbox">
                                    <asp:CheckBox runat="server" ID="ckState" Checked="true" />勾选表示启用
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

                SetLeftMenu("会员管理", "添加会员");



                KindEditor.ready(function (K) {
                    var editor1 = K.create('#txtRemark', {
                        cssPath: '/kindeditor-4.1.10/plugins/code/prettify.css',
                        uploadJson: '/Tools/upload_json.ashx',
                        fileManagerJson: '/kindeditor-4.1.10/asp.net/file_manager_json.ashx',
                        allowFileManager: true
                    });
                });


            


            })

        </script>


    </form>
</body>

</html>
