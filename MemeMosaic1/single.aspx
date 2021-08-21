<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="single.aspx.cs" Inherits="MemeMosaic1.single" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="login" style="height:500px;">
        <h1>You Can Download Your Image</h1>
        <br />
         <b>   Title: <%=title %></b>
           
            <br />

          <image src="uploads/<%=img %>" height="350px" width="350px" />
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Download!!" OnClick="Button1_Click" />
    </div>

</asp:Content>
