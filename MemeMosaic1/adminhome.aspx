<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="MemeMosaic1.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="login">
        <h1>Welcome Admin</h1>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Upload Memes" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Pending Memes List" OnClick="Button2_Click" />
          <asp:Button ID="Button4" runat="server" Text="Manage Memes" OnClick="Button4_Click" />
          <asp:Button ID="Button3" runat="server" Text="View Users" OnClick="Button3_Click" />
    </div>
</asp:Content>
