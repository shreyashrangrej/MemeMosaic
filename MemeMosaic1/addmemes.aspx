<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addmemes.aspx.cs" Inherits="MemeMosaic1.addmemes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class ="login" style="height:450px;">
        <div class="inlogin" style="height:400px;">
        <h1>Add Memes</h1>
        <br />
                <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Select Catogory</asp:ListItem>
                <asp:ListItem>Memes</asp:ListItem>
                <asp:ListItem>News</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
                
            </asp:DropDownList>
        <br /> 
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Meme Title" ></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Discription" ></asp:TextBox>
        <br />
       
     
        <asp:FileUpload ID="FileUpload1" runat="server" />
      
        <br />
        
    
        <asp:Button ID="Button1" runat="server" Text="Add Meme" OnClick="Button1_Click" />
        <br />
              <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
</div>

      </div>
</asp:Content>
