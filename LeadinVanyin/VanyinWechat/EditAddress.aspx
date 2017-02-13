<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditAddress.aspx.cs" Inherits="EditAddress" %>

<!DOCTYPE html>
<html>

	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
		<title>万印网首页</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
		<link rel="stylesheet" type="text/css" href="css/EditAddress.css" />

	</head>

	<body>

		<!--头部 begin-->
		<div id="header">
			<p>万印网</p>
			
		</div>
		<!--头部 end--

		<!--正文 begin-->
		<div id="content">
			
			<div class="addtitle">
				<p>编辑收获地址</p>
			</div>
			
			<div class="addform">
				<div class="inputlistbox inputname">
					<input type="text" name="txtname" id="txtname" value="" class="txtinput" placeholder="姓名" />
				</div>
				<div class="inputlistbox address">
					<ul>
						<li><P>上海市</P></li>
						<li><P>浦东新区</P></li>
					</ul>
				</div>
				
				<div class="inputlistbox inputname">
					<input type="text" name="txtname" id="Text1" value="" class="txtinput" placeholder="浦东新区" />
				</div>
				<div class="inputlistbox inputname">
					<input type="text" name="txtname" id="Text2" value="" class="txtinput" placeholder="详细地址" />
				</div>
				<div class="inputlistbox inputname">
					<input type="text" name="txtname" id="Text3" value="" class="txtinput" placeholder="联系手机" />
				</div>
			</div>

		</div>
		<!--正文 end-->

		<!--底部  begin-->
		<div class="orderfooter">
			<a href="#">
					确认保存
				</a>
		</div>
		<!--底部  end-->

	</body>

</html>