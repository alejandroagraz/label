<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication9._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <link href="Scripts/jqueryUI/jquery-ui.css" type="text/css" rel="stylesheet">    

    <link href="media/css/bootstrap.minV_3_JC_NEW.css" type="text/css" rel="stylesheet">

    <script type="text/javascript" src="Scripts/jquery-2.1.1.min.js"></script>
    
    <script type="text/javascript" src="Scripts/jqueryUI/jquery-ui.js"></script>

    <script type="text/javascript" src="Scripts/jquery.yesnoV3_JC.js"></script>

    <script type="text/javascript" src="Scripts/bootstrap.minV3_JC_NEW.js"></script>

    <link href="media/css/bootstrap-multiselectV3_JC.css" type="text/css" rel="stylesheet">

    <script type="text/javascript" src="Scripts/bootstrap-multiselectV3_JC.js"></script>  

    <script type="text/javascript" src="Scripts/jquery.dialogextend.min.js"></script>

    <LINK href="Scripts/BootDatePi/bootstrap-datetimepicker.css" rel="stylesheet">  
        
<SCRIPT type="text/javascript" src="Scripts/BootDatePi/moment-with-locales.js"></SCRIPT>                  
<SCRIPT type="text/javascript" src="Scripts/BootDatePi/bootstrap-datetimepicker.js"></SCRIPT> 

    <section class="featured">
        <div class="content-wrapper">


        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        &nbsp;<asp:Panel ID="Panel1" runat="server" BackColor="#F2F2F2" BorderColor="Black" BorderStyle="None" ForeColor="Black" Height="655px" ScrollBars="Vertical" style="padding: 10px; border-width: 1.5px; border-color:#008ec1; border-style:solid; text-align:left;" Width="907px">

        <asp:Label ID="Label1" runat="server" Text="Label" ></asp:Label>
        </asp:Panel>
        
  

    <asp:Button ID="verTodo"  style=" background-color:#008ec1; color:white;" visible="false" runat="server" Font-Names="Berlin Sans FB" OnClick="cp_Click" Text="Ver Todo"/>

</asp:Content>
