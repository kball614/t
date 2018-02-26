<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tscore.aspx.cs" Inherits="Tscore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="XX-Large" OnClick="Button1_Click" Text="返回" />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" SelectCommand="SELECT [Sid], [Score], [Ttype] FROM [Result] WHERE ([Sid] = @Sid)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="Sid" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Sid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Sid" HeaderText="學號" ReadOnly="True" SortExpression="Sid" />
                <asp:BoundField DataField="ClassNo" HeaderText="座號" SortExpression="ClassNo" />
                <asp:BoundField DataField="Spaw" HeaderText="學生密碼" SortExpression="Spaw" />
                <asp:BoundField DataField="Sname" HeaderText="學生姓名" SortExpression="Sname" />
                <asp:BoundField DataField="Sgender" HeaderText="性別" SortExpression="Sgender" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JTConnectionString %>" DeleteCommand="DELETE FROM [StudentProfile] WHERE [Sid] = @Sid" InsertCommand="INSERT INTO [StudentProfile] ([Sid], [ClassNo], [Spaw], [Sname], [Sgender]) VALUES (@Sid, @ClassNo, @Spaw, @Sname, @Sgender)" SelectCommand="SELECT * FROM [StudentProfile]" UpdateCommand="UPDATE [StudentProfile] SET [ClassNo] = @ClassNo, [Spaw] = @Spaw, [Sname] = @Sname, [Sgender] = @Sgender WHERE [Sid] = @Sid">
            <DeleteParameters>
                <asp:Parameter Name="Sid" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Sid" Type="String" />
                <asp:Parameter Name="ClassNo" Type="Int32" />
                <asp:Parameter Name="Spaw" Type="String" />
                <asp:Parameter Name="Sname" Type="String" />
                <asp:Parameter Name="Sgender" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ClassNo" Type="Int32" />
                <asp:Parameter Name="Spaw" Type="String" />
                <asp:Parameter Name="Sname" Type="String" />
                <asp:Parameter Name="Sgender" Type="String" />
                <asp:Parameter Name="Sid" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Sid" HeaderText="學號" SortExpression="Sid" />
                <asp:BoundField DataField="Score" HeaderText="測驗分數" SortExpression="Score" />
                <asp:BoundField DataField="Ttype" HeaderText="測驗類別" SortExpression="Ttype" />
            </Fields>
        </asp:DetailsView>
    
    </div>
    </form>
</body>
</html>
