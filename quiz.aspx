<%@ Page Language="C#" AutoEventWireup="true" CodeFile="quiz.aspx.cs" Inherits="quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css"> 
    body { 
      background-image:url('pic/background/quiz.jpg');
       background-repeat: no-repeat;
       background-attachment: scroll; 

     } 
  </style> 
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 1005px">
    
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Font-Size="XX-Large" style="z-index: 1; left: 88px; top: 485px; position: absolute; height: 303px; width: 487px" Font-Bold="True">
            <asp:ListItem Value="1">字型</asp:ListItem>
            <asp:ListItem Value="2">字義</asp:ListItem>
            <asp:ListItem Value="3">成語</asp:ListItem>
            <asp:ListItem Value="4">注音</asp:ListItem>
            <asp:ListItem Selected="True" Value="5">綜合</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Visible="False" />
        <br />
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/object/login.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 213px; top: 701px; position: absolute" />
    
    </div>
    </form>
</body>
</html>
