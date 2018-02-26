<%@ Page Language="C#" AutoEventWireup="true" CodeFile="qb.aspx.cs" Inherits="qb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" DeleteCommand="DELETE FROM [QuizBase] WHERE [Tno] = @Tno" InsertCommand="INSERT INTO [QuizBase] ([Ttype], [Tno], [Tque], [Tsel1], [Tsel2], [Tsel3], [Tsel4], [Ans]) VALUES (@Ttype, @Tno, @Tque, @Tsel1, @Tsel2, @Tsel3, @Tsel4, @Ans)" SelectCommand="SELECT [Ttype], [Tno], [Tque], [Tsel1], [Tsel2], [Tsel3], [Tsel4], [Ans] FROM [QuizBase]" UpdateCommand="UPDATE [QuizBase] SET [Ttype] = @Ttype, [Tque] = @Tque, [Tsel1] = @Tsel1, [Tsel2] = @Tsel2, [Tsel3] = @Tsel3, [Tsel4] = @Tsel4, [Ans] = @Ans WHERE [Tno] = @Tno">
            <DeleteParameters>
                <asp:Parameter Name="Tno" Type="Double" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Ttype" Type="Double" />
                <asp:Parameter Name="Tno" Type="Double" />
                <asp:Parameter Name="Tque" Type="String" />
                <asp:Parameter Name="Tsel1" Type="String" />
                <asp:Parameter Name="Tsel2" Type="String" />
                <asp:Parameter Name="Tsel3" Type="String" />
                <asp:Parameter Name="Tsel4" Type="String" />
                <asp:Parameter Name="Ans" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Ttype" Type="Double" />
                <asp:Parameter Name="Tque" Type="String" />
                <asp:Parameter Name="Tsel1" Type="String" />
                <asp:Parameter Name="Tsel2" Type="String" />
                <asp:Parameter Name="Tsel3" Type="String" />
                <asp:Parameter Name="Tsel4" Type="String" />
                <asp:Parameter Name="Ans" Type="String" />
                <asp:Parameter Name="Tno" Type="Double" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" DeleteCommand="DELETE FROM [QuizBase] WHERE [Tno] = @Tno" InsertCommand="INSERT INTO [QuizBase] ([Ttype], [Tno], [Tque], [Tsel1], [Tsel2], [Tsel3], [Tsel4], [Ans]) VALUES (@Ttype, @Tno, @Tque, @Tsel1, @Tsel2, @Tsel3, @Tsel4, @Ans)" SelectCommand="SELECT [Ttype], [Tno], [Tque], [Tsel1], [Tsel2], [Tsel3], [Tsel4], [Ans] FROM [QuizBase] WHERE ([Tque] LIKE '%' + @Tque + '%')" UpdateCommand="UPDATE [QuizBase] SET [Ttype] = @Ttype, [Tque] = @Tque, [Tsel1] = @Tsel1, [Tsel2] = @Tsel2, [Tsel3] = @Tsel3, [Tsel4] = @Tsel4, [Ans] = @Ans WHERE [Tno] = @Tno">
            <DeleteParameters>
                <asp:Parameter Name="Tno" Type="Double" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Ttype" Type="Double" />
                <asp:Parameter Name="Tno" Type="Double" />
                <asp:Parameter Name="Tque" Type="String" />
                <asp:Parameter Name="Tsel1" Type="String" />
                <asp:Parameter Name="Tsel2" Type="String" />
                <asp:Parameter Name="Tsel3" Type="String" />
                <asp:Parameter Name="Tsel4" Type="String" />
                <asp:Parameter Name="Ans" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="Tque" PropertyName="Text" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Ttype" Type="Double" />
                <asp:Parameter Name="Tque" Type="String" />
                <asp:Parameter Name="Tsel1" Type="String" />
                <asp:Parameter Name="Tsel2" Type="String" />
                <asp:Parameter Name="Tsel3" Type="String" />
                <asp:Parameter Name="Tsel4" Type="String" />
                <asp:Parameter Name="Ans" Type="String" />
                <asp:Parameter Name="Tno" Type="Double" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click1" />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Tno" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Ttype" HeaderText="題目類別" SortExpression="Ttype" />
                <asp:BoundField DataField="Tno" HeaderText="題號" ReadOnly="True" SortExpression="Tno" />
                <asp:BoundField DataField="Tque" HeaderText="題目敘述" SortExpression="Tque" />
                <asp:BoundField DataField="Tsel1" HeaderText="選項1" SortExpression="Tsel1" />
                <asp:BoundField DataField="Tsel2" HeaderText="選項2" SortExpression="Tsel2" />
                <asp:BoundField DataField="Tsel3" HeaderText="選項3" SortExpression="Tsel3" />
                <asp:BoundField DataField="Tsel4" HeaderText="選項4" SortExpression="Tsel4" />
                <asp:BoundField DataField="Ans" HeaderText="答案" SortExpression="Ans" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="搜尋"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="200px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="送出" />
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="Tno" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Ttype" HeaderText="題目類別" SortExpression="Ttype" />
                <asp:BoundField DataField="Tno" HeaderText="題號" ReadOnly="True" SortExpression="Tno" />
                <asp:BoundField DataField="Tque" HeaderText="題目敘述" SortExpression="Tque" />
                <asp:BoundField DataField="Tsel1" HeaderText="選項1" SortExpression="Tsel1" />
                <asp:BoundField DataField="Tsel2" HeaderText="選項2" SortExpression="Tsel2" />
                <asp:BoundField DataField="Tsel3" HeaderText="選項3" SortExpression="Tsel3" />
                <asp:BoundField DataField="Tsel4" HeaderText="選項4" SortExpression="Tsel4" />
                <asp:BoundField DataField="Ans" HeaderText="答案" SortExpression="Ans" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
    
    </div>
    </form>
</body>
</html>
