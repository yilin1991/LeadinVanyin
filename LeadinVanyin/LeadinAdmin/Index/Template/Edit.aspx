<%@ Page Language="C#" AutoEventWireup="true" enableEventValidation="false" CodeBehind="Edit.aspx.cs" Inherits="LeadinWeb.Vanyin.Index.Template.Edit" %>

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
                        <li><a href="../Article/List.aspx">资讯管理</a></li>
                        <li>></li>
                        
                        <li>资讯编辑</li>
                    </ul>
                </div>

                <div class="contentBox">

                    <div class="editTop">
                        <span>基本信息</span>
                    </div>
                    <div class="editForm">



                        <div class="control-group">
                            <label class="control-label" for="txtTitle">标题</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtTitle" CssClass="inputWidth2" datatype="*" nullmsg="请输入标题！" errormsg="标题不能为空！"></asp:TextBox>
                                <span class="help-inline">请填写标题！</span>
                            </div>
                        </div>
                     
                        <div class="control-group">
                            <label class="control-label" for="ddlIndexType">首页类别</label>
                            <div class="controls">
                                <asp:DropDownList runat="server" ID="ddlIndexType" DataMember="5"  datatype="*" nullmsg="请选择首页类别！" errormsg="文章首页不能为空！">
                                    <asp:ListItem Value="">请选择首页类别</asp:ListItem>
                                </asp:DropDownList>
                                <span class="help-inline">请选择首页类别！</span>
                            </div>
                        </div>
                       <div class="control-group">
                            <label class="control-label" for="ddlTemplateType">模版类别</label>
                            <div class="controls">
                                <asp:DropDownList runat="server" ID="ddlTemplateType" DataMember="5"  datatype="*" nullmsg="请选择模版类别！" errormsg="模版类别不能为空！">
                                    <asp:ListItem Value="">请选择模版类别</asp:ListItem>
                                </asp:DropDownList>
                                <span class="help-inline">请选择模版类别！</span>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="ddlTemplate">设计模版</label>
                            <div class="controls">
                                <asp:DropDownList runat="server" ID="ddlTemplate" DataMember="5"  datatype="*" nullmsg="请选择设计模版！" errormsg="设计模版不能为空！">
                                    <asp:ListItem Value="">请选择设计模版</asp:ListItem>
                                </asp:DropDownList>
                                <span class="help-inline">请选择设计模版！</span>
                            </div>
                        </div>
                           <div class="control-group">
                            <label class="control-label" for="txtfileico1">展示图片</label>
                            <div class="controls " >

                                <ul class="filebox">
                                    <li class="txtfilename"><asp:TextBox runat="server" ID="txtfileico1" CssClass="inputWidth2" ></asp:TextBox></li>
                                    <li class="btnfilea"><a href="javascript:void(0)" onclick="btnfileaclick($(this))" class="btnfilebtn">上传图片</a></li>
                                    <li class="fileinput"><input type="file" name="fileuploadico" id="fileuploadico" onchange="fileonchange($(this),'myfrom')" /></li>
                                </ul>
                            </div>
                        </div>
                    
                        <div class="control-group">
                            <label class="control-label" for="txtSortNum">排序</label>
                            <div class="controls">
                                <asp:TextBox runat="server" ID="txtSortNum" CssClass="inputWidth1" Text="1" datatype="n" nullmsg="请输入类别顺序,数字越大越靠前！" errormsg="请输入正确的类别顺序（整数）！"></asp:TextBox>
                                <span class="help-inline">请输入类别顺序,数字越大越靠前！</span>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="ckState">状态</label>
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

                SetLeftMenu("首页模版", "添加首页模版");




                $("#ddlTemplateType").change(function () {

                    var cid = $(this).val();

                    $.ajax({
                        type: "POST",
                        url: "Edit.aspx/TemplateTypeChange",
                        //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字  
                        data: "{ 'cid':" + cid + "}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (data) {
                            //返回的数据用data.d获取内容  

                            $("#ddlTemplate").html(data.d);

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


