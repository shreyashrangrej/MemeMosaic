<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userhome.aspx.cs" Inherits="MemeMosaic1.userhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login">
        <h1>Welcome User</h1>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Upload Memes" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Memes List" OnClick="Button2_Click" />

    </div>
</asp:Content>
