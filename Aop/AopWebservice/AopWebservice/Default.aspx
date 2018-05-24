<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AopWebservice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox_CityName" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询天气" />
            <br />
            <br />
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="207px" Width="472px" Columns="50" TextMode="MultiLine" 
            style="word-wrap:break-word;height:80px;word-break:break-all;"></asp:TextBox>
        <p >
            上面的调用Google的webserve ，下面调用自己的webservice</p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="+"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="=" OnClick="Button2_Click" />
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br/>
        <p>webservice client利用AOP记录log！</p>
        <p>&nbsp;</p>
        
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>&nbsp;
            <asp:Button ID="Button3" runat="server" Text="调用wcf服务" OnClick="Button3_Click" />
        <p>
            <asp:TextBox ID="TextBox6" runat="server" Height="28px" Width="315px"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <p>
            &nbsp;</p>
    </form>


</body>
</html>
