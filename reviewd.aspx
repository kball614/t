<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reviewd.aspx.cs" Inherits="reviewd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
         <style type="text/css"> 
    body { 
      background-image:url('pic/background/review.jpg');
       background-repeat: no-repeat;
       background-attachment: scroll; 

     } 
  </style> 
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 800px">
    
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Size="XX-Large" Text="第"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="XX-Large">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label5" runat="server" Font-Size="XX-Large" Text="題"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="確定" Font-Size="XX-Large" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Size="XX-Large">
        </asp:RadioButtonList>
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" SelectCommand="SELECT * FROM [LogSheet] WHERE ([TestID] = @TestID)">
            <SelectParameters>
                <asp:SessionParameter Name="TestID" SessionField="GV" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/object/back.png" OnClick="ImageButton1_Click" />
    
    </div>
    </form>
</body>
</html>
