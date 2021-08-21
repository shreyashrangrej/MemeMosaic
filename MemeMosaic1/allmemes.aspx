<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="allmemes.aspx.cs" Inherits="MemeMosaic1.allmemes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <center>

          <br />
          <asp:Button ID="Button1" runat="server" Text="All" OnClick="Button1_Click"></asp:Button>
          <asp:Button ID="Button2" runat="server" Text="Memes" OnClick="Button2_Click"></asp:Button>
          <asp:Button ID="Button3" runat="server" Text="News" OnClick="Button3_Click"></asp:Button>
          <asp:Button ID="Button4" runat="server" Text="Other" OnClick="Button4_Click"></asp:Button>


    <asp:DataList ID="DataList1" runat="server" CellPadding="10" CellSpacing="10" DataKeyField="Id" RepeatColumns="3" RepeatDirection="Horizontal">
        <ItemTemplate>
             <div class="pros">
                 
                  <a href="single.aspx?id=<%#Eval("Id")  %>" >
              <img alt ="" src ='uploads/<%#Eval("img") %>' height="300" width="300"/>
              
                <br /> 
                       <input type="hidden" value="<%#Eval("Id")  %>" name="proid" />
               
 
                 <br />
            <b>  Catoegory: </b> 
         <b>   <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("category") %>' />
            <br /><hr /></b>
                <b>   Title:</b>
            <asp:Label ID="categoryLabel" runat="server" Text='<%# Eval("title") %>' />
            <br /><hr />
         <b>   Date: </b> 
            <asp:Label ID="subcategoryLabel" runat="server" Text='<%# Eval("dt") %>' />
            <br /><hr />
         
         
    </a>
                    
         </div>
            <br />
  

        
        </ItemTemplate>
    </asp:DataList>
        </center>
</asp:Content>
