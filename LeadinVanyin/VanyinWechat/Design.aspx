<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Design.aspx.cs" Inherits="Design" %>

<!DOCTYPE html>
<html>

	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
		<title>万印网首页</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
		<link rel="stylesheet" type="text/css" href="css/design.css" />
		<link rel="stylesheet" type="text/css" href="css/styleSelect.css" />
	</head>

	<body>

		<!--头部 begin-->
		<div id="header">
			<p>万印网</p>
			<div class="headerback">
				<a href="#"><img src="img/public/backico.png" /></a>
			</div>
		</div>
		<!--头部 end--

		<!--正文 begin-->
		<div id="content">

			<div class="title">
				<div class="titlebox">
					<p>我要设计</p>
				</div>
			</div>

			<div class="design">
				<div class="inputlist input1">
					<ul>
						<li>
							<p>设计类别</p>
						</li>
						<li>
							<select name="" class="ui-select">
								<option value="1">名片</option>
								<option value="2">画册</option>
								<option value="3">三折页</option>
								<option value="4">易拉宝</option>
								<option value="5">台历</option>
							</select>
						</li>
					</ul>
				</div>

				<div class="inputlist stencil">
					<a href="#">
						<p>请选择设计模板</p>
					</a>
				</div>

				<div class="inputlist inputremark">

					<div class="remarktitle">
						<p>设计要求</p>
					</div>
					<div class="remarkinput">
						<textarea class="txtremark"></textarea>
					</div>
				</div>

			</div>

			<div class="IsPrint">
				<ul>
					<li>
						<p>是否需要印刷</p>
					</li>
					<li class="btnshow">
						<span><img src="img/public/yesico.png"/></span>
						<span><img src="img/public/noico.png"/></span>
						<div class="IsPrintbox"></div>
					</li>
					<li>
						<p>否</p>
					</li>
				</ul>
			</div>

			<div class="printbody">
				<div class="printbox">

					<div class="inputlist input1">
						<ul>
							<li>
								<p>印刷类别</p>
							</li>
							<li>
								<select name="" class="ui-select">
									<option value="1">名片</option>
									<option value="2">画册</option>
									<option value="3">三折页</option>
									<option value="4">易拉宝</option>
									<option value="5">台历</option>
								</select>
						</ul>
					</div>
					<div class="inputlist input1">
						<ul>
							<li>
								<p>印刷纸张</p>
							</li>
							<li>
								<select name="" class="ui-select">
									<option value="1">名片</option>
									<option value="2">画册</option>
									<option value="3">三折页</option>
									<option value="4">易拉宝</option>
									<option value="5">台历</option>
								</select>
							</li>
						</ul>
					</div>
					<div class="inputlist input1">
						<ul>
							<li>
								<p>印刷数量</p>
							</li>
							<li>
								<input type="text" name="txtNum" id="txtNum" class="inputtxtnum" value="10" />
							</li>
						</ul>
					</div>
					<div class="inputlist input1">
						<ul>
							<li>
								<p>印刷工艺</p>
							</li>
							<li>
								<select name="" class="ui-select">
									<option value="1">名片</option>
									<option value="2">画册</option>
									<option value="3">三折页</option>
									<option value="4">易拉宝</option>
									<option value="5">台历</option>
								</select>
							</li>
						</ul>
					</div>
					<div class="inputlist inputremark">

						<div class="remarktitle">
							<p>印刷要求</p>
						</div>
						<div class="remarkinput">
							<textarea class="txtremark"></textarea>
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
										<a href="EditAddress.html">
											<p>新增收货地址</p>
										</a>
									</div>

									<div class="addlist">
										<div class="addli">
											<ul>
												<li>
													<p><span>KK 女士</span><span>15021588888</span></p>
													<p>左岸88B417</p>
												</li>
												<li>
													<a href="#"><img src="img/public/editaddico.png" /></a>
												</li>
											</ul>
										</div>
										<div class="addli">
											<ul>
												<li>
													<p><span>KK 女士</span><span>15021588888</span></p>
													<p>左岸88B417</p>
												</li>
												<li>
													<a href="#"><img src="img/public/editaddico.png" /></a>
												</li>
											</ul>
										</div>
										<div class="addli">
											<ul>
												<li>
													<p><span>KK 女士</span><span>15021588888</span></p>
													<p>左岸88B417</p>
												</li>
												<li>
													<a href="#"><img src="img/public/editaddico.png" /></a>
												</li>
											</ul>
										</div>
										<div class="addli">
											<ul>
												<li>
													<p><span>KK 女士</span><span>15021588888</span></p>
													<p>左岸88B417</p>
												</li>
												<li>
													<a href="#"><img src="img/public/editaddico.png" /></a>
												</li>
											</ul>
										</div>
										<div class="addli">
											<ul>
												<li>
													<p><span>KK 女士</span><span>15021588888</span></p>
													<p>左岸88B417</p>
												</li>
												<li>
													<a href="#"><img src="img/public/editaddico.png" /></a>
												</li>
											</ul>
										</div>
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

		</div>
		<!--正文 end-->

		<!--底部  begin-->
		<div class="orderfooter">
			<a href="#">
					核对无误，确认下单
				</a>
		</div>
		<!--底部  end-->
		<script src="js/jquery-1.11.1.min.js" type="text/javascript" charset="utf-8"></script>
		<script src="js/jquery.Address.js" type="text/javascript" charset="utf-8"></script>

		<script src="js/jquery.selectle.js" type="text/javascript" charset="utf-8"></script>
<script src="js/jquery.ShowPrint.js" type="text/javascript" charset="utf-8"></script>
		<script type="text/javascript">
		    $(function () {
		        $(".otherltitle").AddressUnfold();
		        $(".addlist .addli").AddressSelect();

		        $.SelectLoad();

		        $(".btnshow").ShowPrint();

		    })
		</script>
	</body>

</html>