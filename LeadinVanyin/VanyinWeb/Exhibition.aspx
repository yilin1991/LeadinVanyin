<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exhibition.aspx.cs" Inherits="LeadinWeb.Exhibition" %>

<%@ Register Src="~/Control/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>我要设计</title>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/exhibition.css" />
</head>

<body>

    <!--头部导航 Begin-->
    <uc1:Header runat="server" ID="Header" />
    <!--头部导航 End-->

    <!--正文 Begin-->
    <div id="content" class="design">

        	<div class="exhBody">
			
			
			<div class="exhTitle">
				<ul>
					<li><img src="/img/Exhibition/exh_ico.png"/></li>
					<li><p>展览展示</p></li>
				</ul>
			</div>
			<div class="exhBanner">
				<img src="/img/Exhibition/exh_img1.jpg" />
			</div>
			
			<div class="exhdiv1">
				<p>展览策划</p>
			</div>
			<div class="exhdiv2">
				<div class="exhdiv2Top">
					<p>展览策划是一个综合性的系统工程，</p>
					<p>目标是起点，信息是基础，创意是核心。</p>
				</div>
				<div class="exhdiv2Content">
					<p>展览策划就是会展企业根据收集和掌握的信息，对会展项目的立项、方案实施、品牌树立和推广、会展相关活动的开展、会展营销及会展管理进行总体部署和具有前瞻性规划的活动。展览策划对会展活动的全过程进行全方位的设计并找出最佳解决方案，以实现企业开展会展活动的目标。</p>
				</div>
				
			</div>
			<div class="exhdiv3">
				<p>展台设计</p>
			</div>
			<div class="exhdiv4">
				<p>传统的设计，特别是庙宇、宫殿、银行等，强调永恒、权威和壮观。但是在竞争的展览会上，展出成功与否在很大程度上靠观众的兴趣和反应。因此，展览设计要考虑人，主要是目标观众的目的、情绪、兴趣、观点、反应等因素。从目标观众的角度进行设计，容易引起目标观众的注意、共鸣，并为目标观众留下比较深的印象。</p>
			</div>
			
			<div class="exhdiv5">
				<p>展台搭建</p>
				<p>搭配设计，最大最优的呈现设计，一体式团队<br/>协作，全备的搭建设施是搭建的基础环节。</p>
			</div>
			
			
			<div class="exhdiv6">
				<p>项目执行</p>
				<p>成熟的操作团队，在每一个细节，力求做到"自然"。良好的协作，高效的进程，这是我们的基本素养。</p>
			</div>
			
			<div class="exhdiv7">
				<p>了解更多，马上咨询</p>
			</div>
			
			
		</div>


        
    </div>
    <!--正文 Begin-->

    <!--底部 Begin-->
    <uc1:Footer runat="server" ID="Footer" />
    <!--底部 End-->






</body>

</html>

