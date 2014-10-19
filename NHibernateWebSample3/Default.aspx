<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NHibernateWebSample._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 68px;
        }
        .style3
        {
            width: 87px;
        }
        .style4
        {
            width: 8%;
        }
        .style6
        {
            width: 4%;
        }
        .style7
        {
            width: 128px;
        }
        .style9
        {
            width: 63%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCFF">
            <b>Insert Panel</b><br />
            <br />
            <table class="style1">
                <tr>
                    <td class="style3">
                        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFirstname" runat="server" 
                            ControlToValidate="txtFirstName" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:Label ID="lblLastName" runat="server" Text="Second Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredLastname" runat="server" 
                            ControlToValidate="txtLastName" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        DepId</td>
                    <td>
                        <asp:DropDownList ID="ddlDeptId" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" onclick="btnInsert_Click" 
                            Text="Insert to Database" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        
        <hr />
        
        <asp:Panel ID="Panel2" runat="server" BackColor="#FFFF99">
            <b>Load Panel</b><br />
            <br />
            <table class="style1">
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnLoad" runat="server" CausesValidation="False" 
                            onclick="btnLoad_Click" Text="Load from Database" />
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td>
                        <asp:GridView ID="grdEmployee" runat="server" BackColor="LightGoldenrodYellow" 
                            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                            GridLines="None" AllowPaging="True" 
                            onpageindexchanging="grdEmployee_PageIndexChanging">
                            <FooterStyle BackColor="Tan" />
                            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                                HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        
        <hr />
        
        <asp:Panel ID="Panel3" runat="server" BackColor="Lime">
            <b>Update Panel</b><br />
            <br />
            <table class="style1">
                <tr>
                    <td class="style4">
                        EmpId</td>
                    <td class="style7">
                        First Name</td>
                    <td class="style9">
                        Second Name</td>
                    <td class="style6">
                        Email Id</td>
                    <td class="style6">
                        Address</td>
                    <td class="style6">
                        Joining Date</td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:DropDownList ID="ddlEmpId" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlEmpId_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="style7">
                        <asp:TextBox ID="txtFirstUpdate" runat="server"></asp:TextBox>
                    </td>
                    <td class="style9">
                        <asp:TextBox ID="txtLastUpdate" runat="server" Width="168px"></asp:TextBox>
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtUpdateEmail" runat="server" Width="218px"></asp:TextBox>
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtUpdateAddress" runat="server"></asp:TextBox>
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtUpdateDOJ" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        &nbsp;</td>
                    <td colspan="5">
                        <asp:Button ID="btnUpdate" runat="server" CausesValidation="False" 
                            onclick="btnUpdate_Click" Text="Update Data" />
                        &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        
    </div>
    </form>
</body>
</html>
