<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="SynchProgram" runat="server" OnClick="SynchProgram_Click" Text="Synchronous program" />
&nbsp;
        <asp:Button ID="AsynchProgram" runat="server" OnClick="AsynchProgram_Click" Text="Asynchronous program" />
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
