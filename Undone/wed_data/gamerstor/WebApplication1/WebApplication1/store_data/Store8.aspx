﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Store8.aspx.vb" Inherits="WebApplication1.Store8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Delight - Battle Brothers</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="~/Index_meun\style_data\Style_header_footer.css"/>
    <link rel="stylesheet" href="~/Index_meun\style_data\Web_Store.css"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css" integrity="sha384-oS3vJWv+0UjzBfQzYUhtDYW+Pj2yciDJxpsK1OYPAYjqT085Qq/1cq5FLXAZQ7Ay" crossorigin="anonymous"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <!--******************頭頂內容*****************-->
        <div class="row">
            <div class="col-md-12">
                   <div class ="auto-style4">                     
                     <asp:Panel ID="Panel1" runat="server" style="position: relative; float: right; ">
                         <asp:Button ID="Button3" runat="server" style="float: none; text-align: center; right: 315px; bottom: -19px; " Text="登入" BackColor="#3C3C3C" BorderStyle="None" ForeColor="White" Font-Size="12px" PostBackUrl="~/Index_meun/WebSign_in.aspx"/>
                         <asp:Label ID="Label1" runat="server" Font-Size="Large" style="float: none; top: -15px; left: -16px; height: 30px; width: 19px; bottom: 15px" Text="|" ForeColor="White"></asp:Label>
                         <asp:Button ID="Button2" runat="server" style="float: none; bottom: -19px;height: 15px; right: 214px" Text="註冊" BackColor="#3C3C3C" BorderStyle="None" ForeColor="White" Font-Size="12px" PostBackUrl="~/Index_meun/Web_register.aspx" />
                     </asp:Panel>
                    
                         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/logo_01.jpg" CssClass="auto-style3" Height="58px" Width="224px" PostBackUrl="~/Index_meun/WebStore.aspx" />
                       <!--******************menu*****************-->
                <nav class ="navbar">
                    <div class="dropdown" id="dropdownMenuLink" >
                        <asp:button ID="Button4" runat="server" class="dropbtn"  PostBackUrl="~/Index_meun/WebStore.aspx" Text="商店"/>
                            <div class="dropdown-content">
                                <a href="#">精選</a>
                                <a href="#">新推出</a>
                                <a href="#">促銷商品</a>
                            </div>
                    </div>
                                  
                    <div class="dropdown">
                        <asp:button ID="Button5" runat="server" class="dropbtn"  PostBackUrl="~/Index_meun/Web_Community.aspx" Text="社群"/>
                            <div class="dropdown-content">
                                <a href="#">討論區</a>
                                <a href="#">市集</a>
                                <a href="Web_news.aspx">新聞</a>
                            </div>
                    </div>

                        <asp:button ID="Button6" runat="server" class="dropbtn" PostBackUrl="~/Index_meun/Web_about.aspx" Text="關於"/>
                        <asp:button ID="Button7" runat="server" class="dropbtn" PostBackUrl="~/Index_meun/Web_Customer_Service.aspx" Text="客服中心"/>
                </nav>
        </div> 
<!--******************menu-end*****************-->
            </div> <!--col-md-12-->
        </div><!--row-->
<!--******************box*****************-->
            <!-- Second Container -->
            <div class="container-fluid bg-2 text-center">
                   <div class="col-sm-12 text-left"  > 
                       <h2>Battle Brothers</h2>
                         <hr/><br />
                        <div class="row" >
                            <div class="col-sm-12" style="left:18%;width:80%; ">
                              <div class="col-sm-8">
                                 <div id="myCarousel" class="carousel slide" data-ride="carousel">
                                       <!-- Indicators -->
                                       <ol class="carousel-indicators">
                                         <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                                         <li data-target="#myCarousel" data-slide-to="1"></li>
                                         <li data-target="#myCarousel" data-slide-to="2"></li>
                                       </ol>

                                       <!-- Wrapper for slides -->
                                       <div class="carousel-inner">
                                              <div class="item active">
                                                <img src="https://steamcdn-a.akamaihd.net/steam/apps/365360/ss_2ed5eff851e0562800376e4903e9bf3a2dcdde76.1920x1080.jpg?t=1555679695" alt="Los Angeles" style="width:100%;"/>
                                              </div>

                                              <div class="item">
                                                <img src="https://steamcdn-a.akamaihd.net/steam/apps/365360/ss_99591f270f73a66d760f979b16809f4aee1e7827.1920x1080.jpg?t=1555679695" alt="Chicago" style="width:100%;"/>
                                              </div>
                                       
                                              <div class="item">
                                                <img src="https://steamcdn-a.akamaihd.net/steam/apps/365360/ss_03699d4ce2eacbaeb5f493ae75332b586b09e1c0.1920x1080.jpg?t=1555679695" alt="New york" style="width:100%;"/>
                                              </div>
                                       </div>

                                       <!-- Left and right controls -->
                                       <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                                         <span class="glyphicon glyphicon-chevron-left"></span>
                                         <span class="sr-only">Previous</span>
                                       </a>
                                       <a class="right carousel-control" href="#myCarousel" data-slide="next">
                                         <span class="glyphicon glyphicon-chevron-right"></span>
                                         <span class="sr-only">Next</span>
                                       </a>
                                 </div>

                           </div>
                                  <div class="col-sm-5" style="left:5%;top:10px;">
                                      <img style="height:150px;" src="https://steamcdn-a.akamaihd.net/steam/apps/365360/header.jpg?t=1555679695"/>
                                      <p style="font-size:14px; width:85%;">
                                          Battle an army of sycophantic cultists, zombies, gargoyles, hellhounds,
                                          and an insatiable host of horrors in your quest to defeat the evil Tchernobog.
                                          Squirm through 42 loathesome levels filled with more atmosphere than a Lovecraftian mausoleum.</p>
                                      <p style="font-size:14px;"><br />&nbsp;發行日期:&nbsp;2017 年 3 月 24 日</p>
                                      <p style="font-size:14px;">&nbsp;發行商:&nbsp;Overhype Studios</p>
                                      <p style="font-size:14px;">&nbsp;類型:&nbsp;策略</p>
                                  </div>
                        </div>
                     </div><!--row--><br />
                    <br />
                 </div>
            </div>
        
       <!-- Third Container (Grid) -->
        <div class="container-fluid bg-3 text-center">    
            <!-- Container (Pricing Section) -->
                <h2>關於遊戲</h2>
                <h4>登入以將此項目新增至您的願望清單、關注它，或標記為不感興趣</h4>
              </div>
              <div class="row slideanim">

                <div class="col-sm-4 col-xs-12" style="height:390px;">
                  <div class="panel panel-default text-center">
                    <div class="panel-heading">
                      <h1>購買 Battle Brothers</h1>
                    </div>
                    <div class="panel-body"style="text-align:left;">
                      <p style="color:black;">名稱: Battle Brothers</p>
                      <p style="color:black;">類型: 策略</p>
                      <p style="color:black;">開發人員: Overhype Studios</p>
                      <p style="color:black;">發行商: Overhype Studios</p>
                      <p style="color:black;">系列作: none</p>
                      <p style="color:black;">發行日期: 2017 年 3 月 24 日</p>
                    </div>
                    <div class="panel-footer">
                      <h3>NT$ 186</h3><br />
                      <button class="btn btn-lg">購買</button>
                    </div>
                  </div>      
                </div> 
                  
                <div class="col-sm-4 col-xs-12" >
                  <div class="panel panel-default text-center">
                    <div class="panel-heading">
                      <h1>系統需求</h1>
                    </div>
                    <div class="panel-body" style="text-align:left;">
                        <p style="color:black;">1.作業系統: Windows 10 64-bit (32-bit not supported)</p><br />
                        <p style="color:black;">2.處理器: Intel Core i5-2300 2.8 GHz/AMD Phenom II X4 945 3.0 GHz or equivalent</p><br />
                        <p style="color:black;">3.記憶體: 2 GB 記憶體</p><br />
                        <p style="color:black;">4.儲存空間: 1.5 GB 可用空間</p>
                   </div>
                    <div class="panel-footer">
                      <button class="btn btn-lg">更多資訊</button>
                    </div>
                  </div>
                </div>       

                <div class="col-sm-4 col-xs-12" style="height:390px;">
                  <div class="panel panel-default text-center">
                    <div class="panel-heading">
                      <h1>關於此遊戲</h1>
                    </div>
                    <div class="panel-body" style="text-align:left;">
                       <p style="color:black;">1.Updated using Nightdive Studio’s KEX Engine</p>
                       <p style="color:black;">2.Vulkan, DirectX 11 and OpenGL 3.2 support, play with unlocked framerates!</p><br />
                       <p style="color:black;">3.Antialiasing, Ambient Occlusion, V-sync and Interpolation support</p><br />
                       <p style="color:black;">4.Support for high resolutions including 4K monitors</p>
                    </div>
                      <div class="panel-footer">
                      <button class="btn btn-lg">了解更多</button>
                    </div>
                    </div>
                </div>    
              </div>
            <br/><br/>
            <br/><br/>

            <!--******************content-content******************-->
        <!--******************footer-content******************-->
        <section id="footer">
                <div class="container">
                    <div class="row text-center text-xs-center text-sm-left text-md-left">
                        <div class="col-sm-4 col-md-4">
                            <h4>主頁</h4>
                            <ul class="list-unstyled quick-links">
                                <li><a href="WebStore.aspx"><i class="fa fa-angle-double-right"></i>首頁</a></li>
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>商店</a></li>
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>搜尋</a></li>
                                <li><a href="WebSign_in.aspx"><i class="fa fa-angle-double-right"></i>登入/註冊</a></li>
                            </ul>
                        </div>
                        <div class=" col-sm-4 col-md-4">
                            <h4>資訊</h4>
                            <ul class="list-unstyled quick-links">
                                <li><a href="Web_news.aspx"><i class="fa fa-angle-double-right"></i>新聞</a></li>
                                <li><a href="Web_about.aspx"><i class="fa fa-angle-double-right"></i>關於</a></li>
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>公告</a></li>
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>加入我們</a></li>
                            </ul>
                        </div>
                        <div class="col-sm-4 col-md-4">
                            <h4>客服中心</h4>
                            <ul class="list-unstyled quick-links">
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>FAQ</a></li>
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>回報紀錄</a></li>
                                <li><a href="javascript:void();"><i class="fa fa-angle-double-right"></i>服務條款</a></li>
                                <li><a href="Customer Service/Privacy_Policy.aspx"><i class="fa fa-angle-double-right"></i>隱私條款</a></li>

                            </ul>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class=" col-sm-12 col-md-12 mt-2 mt-sm-5">
                            <ul class="list-unstyled list-inline social text-center">
                                <li class="list-inline-item"><a href="https://www.facebook.com/Steam/"><i class="fab fa-facebook-f"></i></a></li>
                                <li class="list-inline-item"><a href="https://twitter.com/steam_games"><i class="fab fa-twitter"></i></a></li>
                                <li class="list-inline-item"><a href="https://www.instagram.com/d4gstore/"><i class="fab fa-instagram"></i></a></li>
                                <li class="list-inline-item"><a href="https://mail.google.com/mail/u/0/#inbox" target="_blank"><i class="far fa-envelope"></i></a></li>
                            </ul>
                        </div>
                        <hr/>
                    </div>	
                    <br />
                    <div class="row">
                        <div class="col-sm-12 col-md-12 mt-2 mt-sm-2 text-center text-white">
                            <p><u></u>臺北城市科技大學-資工系 版權所有</p>
                            <p class="h6">&copy  Copyright 2011 Taipei City University of Science and Technology.All right Reversed.</p>
                        </div>
                        <hr/>
                    </div>	
                </div>
            </section>
        <!--******************footer end******************-->

        </div><!--container end-->
    </form>
</body>
</html>
