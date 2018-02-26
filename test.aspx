<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css"> 
    body { 
      background-image:url('pic/background/test.jpg');
       background-repeat: no-repeat;
       background-attachment: scroll; 

     } 
  </style> 
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 320px">
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="45px" style="position: absolute; z-index: 1; top: 97px; left: 115px"></asp:Label>
        <br />
    
        
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Bold="True" Font-Size="45px" style="position: relative; top: -1px; left: -225px">
        </asp:RadioButtonList>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="45px" style="position: absolute; z-index: 1; left: 306px; top: 615px; " Visible="False"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" BackColor="#FF3300" Font-Size="XX-Large" OnClick="Button2_Click" style="position: relative; top: 160px; left: 66px; margin-top: 4px;" Text="結束測驗" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="下一題" BackColor="#00CCFF" Font-Size="XX-Large" style="position: relative; top: 113px; left: -228px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
