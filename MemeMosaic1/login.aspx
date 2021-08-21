<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MemeMosaic1.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="md">

   
     <div class="login">



    <div class="inlogin" style="background-image:url('back1.png')">
        <h1>Welcome to Login!</h1>
        <asp:TextBox ID="TextBox1" type="email" placeholder="Enter your email" runat="server"  required=""></asp:TextBox> 
        <br />
        <asp:TextBox ID="TextBox2" type="password" placeholder=" Enter your Password"  runat="server"  required=""></asp:TextBox>
    <br />
       <asp:DropDownList ID="DropDownList1" runat="server">


           <asp:ListItem>Select Role</asp:ListItem>
           <asp:ListItem>User</asp:ListItem>
           <asp:ListItem>Admin</asp:ListItem>


       </asp:DropDownList>
        <br />
        
        
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

       <br />
        <a href="resetpass.aspx" style="color:white;">Forgot Password Click Here</a>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br /><br />
    </div>

</div>

 </div>

</asp:Content>
