<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tlogin.aspx.cs" Inherits="Tlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 <style type="text/css"> 
    body { 
      background-image:url('pic/background/login.jpg');
       background-repeat: no-repeat;
       background-attachment: scroll;
       
       
         



     } 
  </style> 

</head> 


<body>
    <form id="form1" runat="server">
    <div style="width: 1267px" >
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 538px; top: 688px; position: absolute" Text="教師帳號" Font-Size="XX-Large"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 741px; top: 687px; position: absolute; height: 32px; width: 240px;"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 741px; top: 786px; position: absolute; height: 32px; width: 240px;"></asp:TextBox>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/object/login.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 1085px; top: 608px; position: absolute; height: 291px; width: 394px;" />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    
        <br />
        <br />
        <br />
    
    &nbsp;&nbsp;&nbsp;
    
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" SelectCommand="SELECT * FROM [LogSheet]"></asp:SqlDataSource>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 537px; top: 788px; position: absolute" Text="教師密碼" Font-Size="XX-Large"></asp:Label>
    
    </div>
    </form>
</body>
</html>
