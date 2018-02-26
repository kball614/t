<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mypage.aspx.cs" Inherits="mypage" %>

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
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/object/test.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 511px; top: 321px; position: absolute; height: 254px; width: 280px;" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/object/logout.png" OnClick="ImageButton3_Click" style="z-index: 1; left: 948px; top: 307px; position: absolute; height: 266px; width: 277px" />
    
    </div>
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/object/review.png" OnClick="ImageButton2_Click" style="z-index: 1; left: 52px; top: 305px; position: absolute; height: 270px; width: 309px;" />
    </form>
</body>
</html>
