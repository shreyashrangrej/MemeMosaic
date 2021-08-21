<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="MemeMosaic1.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="md">
      <div class="login" style="height:400px;">
        <div class="inlogin" style="background-image:url('back1.png')">
<h1> Register your Account</h1>
    <asp:TextBox ID="TextBox5" placeholder="Enter your Name" runat="server"  required=""></asp:TextBox>
    <br />
<asp:TextBox ID="TextBox1" type="email"  placeholder="Enter your E-mail Id" runat="server" required=""></asp:TextBox>
<br />
<asp:TextBox ID="TextBox2" placeholder="Enter your Mobile No" runat="server"  required=""></asp:TextBox>

<br />
<asp:TextBox ID="TextBox3" placeholder="Enter your city" runat="server"  required=""></asp:TextBox>
<br />
         
<asp:TextBox ID="TextBox4" type="password" placeholder="Enter your Password" runat="server"  required=""></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
   <br />
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            </div>

</div>
        </div>
</asp:Content>
