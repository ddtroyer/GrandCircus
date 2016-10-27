<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorLayout.aspx.cs" Inherits="Calculator.CalculatorLayout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 87px; width: 420px">
    
    </div>
        <p>
            <asp:Button ID="btn7" runat="server" Height="85px" Text="7" Width="85px" />
            <asp:Button ID="btn8" runat="server" Height="85px" Text="8" Width="85px" />
            <asp:Button ID="btn9" runat="server" Height="85px" Text="9" Width="85px" />
            <asp:Button ID="Button26" runat="server" Height="85px" Text="+" Width="85px" />
            <asp:Button ID="Button27" runat="server" Height="85px" Text="-" Width="85px" />
        </p>
        <p>
            <asp:Button ID="btn4" runat="server" Height="85px" Text="4" Width="85px" />
            <asp:Button ID="btn5" runat="server" Height="85px" Text="5" Width="85px" />
            <asp:Button ID="btn6" runat="server" Height="85px" Text="6" Width="85px" />
            <asp:Button ID="Button28" runat="server" Height="85px" Text="*" Width="85px" />
            <asp:Button ID="Button29" runat="server" Height="85px" Text="/" Width="85px" />
        </p>
        <p>
            <asp:Button ID="btn1" runat="server" Height="85px" Text="1" Width="85px" />
            <asp:Button ID="btn2" runat="server" Height="85px" Text="2" Width="85px" />
            <asp:Button ID="btn3" runat="server" Height="85px" Text="3" Width="85px" />
            <asp:Button ID="Button30" runat="server" Height="85px" Text="=" Width="85px" />
            <asp:Button ID="Button31" runat="server" Height="85px" Text="9" Width="85px" />
        </p>
        <p>
            <asp:Button ID="btn0" runat="server" Height="85px" Text="0" Width="170px" />
            <asp:Button ID="Button15" runat="server" Height="85px" Text="." Width="85px" />
        </p>
    </form>
</body>
</html>
