<%@ Page Language="C#" AutoEventWireup="true" CodeFile="review.aspx.cs" Inherits="review" %>

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
    <div style="margin-left: 760px">
    
        &nbsp;<br />
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
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="20" DataKeyNames="TestID" Font-Size="XX-Large">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                 <asp:TemplateField HeaderText="測驗編號">
                    <ItemTemplate>
                        <%#GridView1.PageIndex * GridView1.PageSize + GridView1.Rows.Count + 1%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="TypeName" HeaderText="測驗題型" SortExpression="TypeName" />
                <asp:BoundField DataField="Score" HeaderText="成績" SortExpression="Score" />
		        <asp:BoundField DataField="TestID" HeaderText="測驗ID" SortExpression="TestID" ReadOnly="True" />
                <asp:BoundField DataField="Time" HeaderText="測驗時間" SortExpression="Time" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" SelectCommand="
SELECT dbo.QType.TypeName,dbo.Result.Score,dbo.Result.TestID,dbo.Result.Time FROM dbo.Result INNER JOIN Qtype on result.Ttype = Qtype.Questtype WHERE ([Sid] = @Sid)">
            <SelectParameters>
                <asp:SessionParameter Name="Sid" SessionField="login" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/object/back.png" OnClick="ImageButton1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>