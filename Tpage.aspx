<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tpage.aspx.cs" Inherits="Tpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css"> 
    body { 
      background-image:url('pic/background/stupage.jpg');
       background-attachment: scroll; 
       background-repeat: no-repeat;
       
       
     } 

  </style> 
</head>
<body>
    <form id="form1" runat="server" style="z-index: 1">
    <div>
    
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" BackColor="#3366FF" style="z-index: 1; left: 907px; top: 407px; position: absolute; height: 115px; width: 231px" Text="登出" Font-Size="XX-Large" OnClick="Button3_Click" />
    
    </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" BackColor="#3366FF" style="z-index: 1; left: 537px; top: 407px; position: absolute; height: 115px; width: 231px"  Text="學生成績查詢" Font-Size="XX-Large" OnClick="Button2_Click" />
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#3366FF" style="z-index: 1; left: 122px; top: 406px; position: absolute; height: 115px; width: 231px" Text="題庫管理" Font-Size="XX-Large" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
