<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebSign_in.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Delight-遊戲平台</title>
    <style type ="text/css">
        body {
            background-color:white;
            margin:0;
            padding:0px;
	        line-height:1.6em;
        }

        header {
	        margin:0px,auto;
	        overflow:hidden;
            background-color:#3C3C3C;
            height:auto;
        }
  
        .container{
	        width:80%;
	        margin:auto;
	        overflow:hidden;
            
        }
            .container h1 {
             color:white;
            }
        #navbar{
	     background-color:#3C3C3C;
	     color:#fff;
        }
            #navbar ul {
             padding:0;
	        list-style: none;
            }
            #navbar li {
                display:inline;
            }
            #navbar a {
             color:#fff;
	        text-decoration: none;
	        font-size:18px;
	        padding-right:15px;
            }
        #showcase {
         background-image:url('../images/showcase.jpg');
	     background-position:center right;
	     min-height:300px;
	     margin-bottom:30px;
	     text-align: center;
        }
            #showcase h1 {
             color:#fff;
	         font-size:50px;
	         line-height:6.5em;
	         padding-top:30px;
            height: 362px;
        }
        #sidebar {
         float:right;
	     width:30%;
	     background: #333;
	     color:#fff;
	     padding:10px;
	     box-sizing: border-box;
            position: relative;
            text-align: center;
            top: 54px;
            left: -24px;
        }

        #main {
         float:left;
	     width:50%;
	     padding:0 30px;
	     box-sizing: border-box;
            height: 170px,auto;
        }
            #main h1 {
                color:black;
            }
        footer {
         background-color:#3C3C3C;
       	 text-align: center;
	     padding:20px;
    	 margin-top:40px;
        }
            footer p {
                color:white;
            }

        @media(max-width:600px) {
            #main {
                width: 100%;
                float: none;
            }

            #sidebar {
                width: 100%;
                float: none;
            }
        }
        .auto-style1 {
            height: 30px;
        }
        .auto-style2 {
            width: 51%;
            height: 370px;
        }
        .auto-style3 {
            width: 382px;
            position: relative;
        }
        .auto-style5 {
            position: relative;
        }
        .auto-style6 {
            width: 80%;
            margin: auto;
            overflow: hidden;
            height: 372px;
        }
        .auto-style7 {
            height: 30px;
            text-align: center;
            width: 265px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
             <header>
                 <div class ="container">                     
                     <asp:Panel ID="Panel1" runat="server" style="position: relative; float: right; ">
                         <asp:Button ID="Button3" runat="server" style="float: none; text-align: center; right: 315px; bottom: -19px" Text="登入" BackColor="#3C3C3C" BorderStyle="None" ForeColor="White" />
                         <asp:Label ID="Label1" runat="server" Font-Size="Large" style="float: none; top: -15px; left: -16px; height: 36px; width: 19px; bottom: 15px" Text="|" ForeColor="White"></asp:Label>
                         <asp:Button ID="Button2" runat="server" style="float: none; bottom: -18px; right: 214px" Text="註冊" BackColor="#3C3C3C" BorderStyle="None" ForeColor="White" />
                     </asp:Panel>
                     <h1>
                         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/icon/綜合/png/power-cord.png" style="top: 1px; left: 75px; height: 45px; width: 56px; right: -75px; float: left; position: relative" />
                         <asp:Button ID="Button1" runat="server" BackColor="#3C3C3C" BorderStyle="None" ForeColor="White" Text="Delight" Font-Names="Cooper Black" Font-Size="XX-Large" Height="49px" Width="316px" src="E:\期中作業\gamerstor\WebApplication1\WebApplication1\WebStor.aspx" />
                     </h1>

                    <nav id ="navbar">
                        <ul>
                               <li><a href="#">商店</a></li>
                               <li><a href="#">社群</a></li>
                               <li><a href="#">關於</a></li>
                               <li><a href="#">客服中心</a></li>
                               <li><a href="#">新聞</a></li>
                        </ul>
                   </nav>
                 </div>

            </header>

            <div class="auto-style6">
                <section id="main" class="auto-style2">
                             <h2 class="auto-style5">Sign in-登入</h2>   
            <table class="auto-style3">
                <tr>
                    <td class="auto-style1">使用者姓名:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px" Height="20px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">使用者密碼:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Height="20px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:Button ID="Button4" runat="server" Text="登入" Width="59px" BackColor="#666699" BorderStyle="None" ForeColor="White" Height="24px" />
                    </td>
                </tr>
                <tr>
                    <td class="style2" colspan="2">
                        <asp:Label ID="lblOutput" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
                </section>
            
            </div>

            <footer>
                <p>Copyright © 2019 WebGD-Stor</p>
            </footer>
       
    </form>
</body>
</html>
