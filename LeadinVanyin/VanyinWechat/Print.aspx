<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Print.aspx.cs" Inherits="Print" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>我要印刷</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/Print.css" />
    <link rel="stylesheet" type="text/css" href="css/styleSelect.css" />

    <link href="css/EditAddress.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />

</head>

<body id="printBody">
    <form runat="server" id="from">

        <!--正文 begin-->
        <div id="content">
            <div class="title">
                <div class="titlebox">
                    <p>我要印刷</p>
                </div>
            </div>
            <div class="printbody">
                <div class="inputlist input1">
                    <ul>
                        <li>
                            <p>印刷类别</p>
                        </li>
                        <li>
                            <asp:DropDownList runat="server" ID="ddlClass" CssClass="ui-select"></asp:DropDownList>

                        </li>
                    </ul>
                </div>
                <div class="inputlist input1">
                    <ul>
                        <li>
                            <p>印刷纸张</p>
                        </li>
                        <li>
                            <asp:DropDownList runat="server" ID="ddlPaper" CssClass="ui-select">
                                <asp:ListItem Value="1">铜版/哑粉纸</asp:ListItem>
                                <asp:ListItem Value="2">艺术纸</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                    </ul>
                </div>
                <div class="inputlist input1">
                    <ul>
                        <li>
                            <p>印刷数量</p>
                        </li>
                        <li>
                            <asp:TextBox runat="server" ID="txtNum" CssClass="inputtxtnum" Text="1"></asp:TextBox>
                        </li>
                    </ul>
                </div>
                <div class="inputlist input1">
                    <ul>
                        <li>
                            <p>印刷工艺</p>
                        </li>
                        <li>
                            <asp:DropDownList runat="server" ID="ddlTechnology" CssClass="ui-select">
                                <asp:ListItem Value="1">烫金/银</asp:ListItem>
                                <asp:ListItem Value="2">覆膜</asp:ListItem>
                                <asp:ListItem Value="3">凹凸</asp:ListItem>
                                <asp:ListItem Value="4">镂空</asp:ListItem>
                                <asp:ListItem Value="5">UV</asp:ListItem>
                                <asp:ListItem Value="6">其他</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                    </ul>
                </div>
                <div class="inputlist inputremark">

                    <div class="remarktitle">
                        <p>印刷要求</p>
                    </div>
                    <div class="remarkinput">
                        <asp:TextBox runat="server" ID="txtRemark" TextMode="MultiLine" CssClass="txtremark" placeholder="您可在这里填写您对您要印刷产品的描述和要求！"></asp:TextBox>
                    </div>
                </div>

                <div class="otherbody">
                    <div class="otherlist">
                        <div class="otherltitle">
                            <a href="javascript:void(0)">
                                <p>请填写能与您通讯的常用地址</p>
                            </a>
                        </div>

                        <div class="otherlistbody">
                            <div class="otherlistbox">

                                <div class="otherlisttop">
                                    <a href="javascript:void(0)">
                                        <p>新增收货地址</p>
                                    </a>
                                </div>
                                <asp:HiddenField runat="server" ID="hidAddress" />
                                <asp:HiddenField runat="server" ID="hidEditId" />

                                <div class="addlist">
                                    <asp:Repeater runat="server" ID="repAddress">
                                        <ItemTemplate>
                                            <div class="addli">
                                                <ul>
                                                    <li>
                                                        <p><span><%#Eval("Harvesr_Name") %></span><span><%#Eval("Harvesr_tel") %></span></p>
                                                        <p><%#GetCityName(int.Parse(Eval("Harvest_ID").ToString()))+ Eval("Harvesr_Address") %></p>
                                                    </li>
                                                    <li class="editAddress">
                                                        <a href="javascript:void(0)">
                                                            <input type="hidden" class="hidAid" value='<%#Eval("Harvest_ID") %>' />
                                                            <img src="img/public/editaddico.png" /></a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>

                            </div>
                        </div>
                    </div>

                    <div class="otherlist">
                        <ul>
                            <li></li>
                            <li>
                                <input type="text" name="txtremark" class="txtremark1" id="txtremark" value="" placeholder="如有特殊需求请备注" />
                            </li>
                        </ul>

                    </div>
                </div>

            </div>

        </div>
        <!--正文 end-->


        <%-- 收获地址 Begin --%>

        <div class="AddressBox">
            <input type="hidden" runat="server" id="hidType" />
            <div class="addtitle">
                <i class="icon-angle-left"></i>
                <p>编辑收获地址</p>
            </div>

            <div class="addform">
                <div class="inputlistbox inputname">
                    <input type="text" name="txtname" id="txtname" value="" class="txtinput" placeholder="姓名" />
                </div>
                <div class="inputlistbox address">
                    <ul>
                        <li class="leftselect">
                            <select id="ddlProvince" class="ui-select" onchange="change()">
                                <asp:Repeater runat="server" ID="repProvince">
                                    <ItemTemplate>
                                        <option value="<%#Eval("ProId") %>"><%#Eval("ProName") %></option>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </select>
                        </li>
                        <li class="leftselect">
                            <select id="ddlCity" class="ui-select">
                                <asp:Repeater runat="server" ID="repCity">
                                    <ItemTemplate>
                                        <option value="<%#Eval("CityId") %>"><%#Eval("CityName") %></option>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </select>
                        </li>
                    </ul>
                </div>

                <div class="inputlistbox inputname leftselect">
                    <select id="ddlDistrict" class="ui-select">
                        <asp:Repeater runat="server" ID="repDistrict">
                            <ItemTemplate>
                                <option value="<%#Eval("Id") %>"><%#Eval("DisName") %></option>
                            </ItemTemplate>
                        </asp:Repeater>
                    </select>

                </div>
                <div class="inputlistbox inputname">
                    <input type="text" name="txtAddress" id="txtAddress" value="" class="txtinput" placeholder="详细地址" />
                </div>
                <div class="inputlistbox inputname">
                    <input type="text" name="txtTel" id="txtTel" value="" class="txtinput" placeholder="联系手机" />
                </div>
            </div>


            <div class="btnAddress">
                <p>确认保存</p>

            </div>
        </div>


        <%-- 收获地址 End --%>


        <!--底部  begin-->
        <div class="orderfooter">
            <%--<a href="Login.aspx">核对无误，确认下单</a>--%>

            <asp:Button runat="server" ID="btnSubmit" Text="核对无误，确认下单" CssClass="btnSubmit" OnClick="btnSubmit_Click" />

        </div>
        <!--底部  end-->
    </form>

    <script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
    <script src="js/Message.js"></script>
    <script src="js/jquery.Address.js" type="text/javascript" charset="utf-8"></script>
    <script src="js/jquery.selectle.js" type="text/javascript" charset="utf-8"></script>

    <script type="text/javascript">
        $(function () {
            $(".otherltitle").AddressUnfold();
            $(".addlist .addli").AddressSelect();
            $(".otherlisttop a").AddressAdd({ "AddType": "add" });
            $(".addtitle i").CloseAddress();
            $.SelectLoad();
            $.SetAddressBoxHeight();
            $(".selectbox").ShowOption()
            $("#ddlProvince").parent("li").find(".selectbox").ProvinceClick();
            $("#ddlCity").parent("li").find(".selectbox").CityClick();

            $(".editAddress").AddressAdd({ "AddType": "edit" })

            $(".btnAddress").BtnAddress();

           
        })

		</script>

</body>

</html>
