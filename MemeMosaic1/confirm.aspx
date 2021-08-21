<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="MemeMosaic1.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login" style="height:auto;">


        <h1>All Pending Memes List</h1>


    
        <table border="1">
        <tr>
            <th>Sr.No</th>
            <th>Title</th>
            <th>Discription</th>
            <th>Date</th>
            <th>Image</th>
            <th>Action</th>
        </tr>
        <% for(int s=1;s<=i;s++)
            {
                %>
         <tr>
            <td>
                <%=s %>
            </td>
              <td>
              
                <%=Session["title'" + s + "'"] %>
            </td>
              <td>
                 <%=Session["disc'" + s + "'"] %>
            </td>
              <td>
                <%=Session["dt'" + s + "'"] %>
            </td>
              <td>
                  <a href="uploads/<%=img  %>" target="_blank">
                <img src="uploads/<%=Session["img'" + s + "'"] %>" height="100" width="100" />

                 </a>
            </td>
             <td>
                 <form action="checkout.aspx" method="post">
            <input type="hidden"/>
        </form>
                  <form action="confirm.aspx"  method="post">
                      <input type="hidden" value="<%=Session["id'" + s + "'"] %>" name="pro"/>
                  <input type="submit" name="cnf" value="Approve"  />
                      </form>
                                  </td>
        </tr>

        

      <%   }   
        %>
     
    </table>
      
         <br /><br />
        <center>
                <a href="adminhome.aspx">Back to Admin Home</a>
         </center>
         <br /><br />
    </div>
</asp:Content>
