<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="resetpass.aspx.cs" Inherits="MemeMosaic1.resetpass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login">
         <h1>
             Enter Your Email ID
         </h1>
    <asp:TextBox ID="TextBox1" required=""  runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Reset" OnClick="Button1_Click" />
    </div>
</asp:Content>
