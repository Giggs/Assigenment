<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Evyatar.Web.Controls" Namespace="Evyatar.Web.Controls" TagPrefix="evy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" style="width: 100%" cellpadding="3" cellspacing="3">
            <tr>
                <td>
                    ScrollableListBox</td>
                <td style="width: 194px">
                    ASP.NET 2.0 Listbox</td>
                <td>
                    Properties</td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Panel ID="Panel1" runat="server" BorderColor="Red" BorderStyle="None" BorderWidth="1px">
                        <evy:ScrollableListBox ID="ScrollableListBox1" runat="server">
                            <asp:ListItem>Item 1</asp:ListItem>
                            <asp:ListItem>Item 2</asp:ListItem>
                            <asp:ListItem>Item 3</asp:ListItem>
                        </evy:ScrollableListBox>
                    </asp:Panel>
                </td>
                <td valign="top" style="width: 194px">
                    <asp:Panel ID="Panel2" runat="server" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                        <asp:ListBox ID="ListBox1" runat="server">
                            <asp:ListItem>Item 1</asp:ListItem>
                            <asp:ListItem>Item 2</asp:ListItem>
                            <asp:ListItem>Item 3</asp:ListItem>
                        </asp:ListBox>
                    </asp:Panel>
                </td>
                <td valign="top">
                    <asp:CheckBox ID="chkWidth" runat="server" AutoPostBack="True" OnCheckedChanged="chkWidth_CheckedChanged" Text="Width" ValidationGroup="Apply Changes" /><br />
                    <asp:Panel runat="server" ID="pnlWidth" Enabled="False">
                        <asp:TextBox ID="txtWidth" runat="server" Width="30px" ValidationGroup="Apply Changes"></asp:TextBox><asp:DropDownList ID="ddlWidth" runat="server" Width="42px" ValidationGroup="Apply Changes">
                            <asp:ListItem>px</asp:ListItem>
                            <asp:ListItem>%</asp:ListItem>
                            <asp:ListItem>pt</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="cmvWidth" runat="server" ControlToValidate="txtWidth"
                            Display="Dynamic" ErrorMessage="Width must be grater or equal to 0" Operator="GreaterThanEqual"
                            Type="Integer" ValidationGroup="Apply Changes" ValueToCompare="0" Enabled="False"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="rfvWidth" runat="server" ErrorMessage="enter a value"
                            ValidationGroup="Apply Changes" ControlToValidate="txtWidth" Enabled="False"></asp:RequiredFieldValidator></asp:Panel>
                    <asp:CheckBox ID="chkHeight" runat="server" AutoPostBack="True" OnCheckedChanged="chkHeight_CheckedChanged" Text="Height" ValidationGroup="Apply Changes" /><br />
                    <asp:Panel runat="server" ID="pnlHeight" Enabled="False">
                        <asp:TextBox ID="txtHeight" runat="server" Width="30px" ValidationGroup="Apply Changes"></asp:TextBox><asp:DropDownList ID="ddlHeight" runat="server" Width="42px" ValidationGroup="Apply Changes">
                            <asp:ListItem>px</asp:ListItem>
                            <asp:ListItem>%</asp:ListItem>
                            <asp:ListItem>pt</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="cmvHeight" runat="server" ControlToValidate="txtHeight"
                            Display="Dynamic" ErrorMessage="Height must be grater or equal to 0" Operator="GreaterThanEqual"
                            Type="Integer" ValidationGroup="Apply Changes" ValueToCompare="0" Enabled="False"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="rfvHeight" runat="server" ErrorMessage="enter a value"
                            ValidationGroup="Apply Changes" ControlToValidate="txtHeight" Enabled="False"></asp:RequiredFieldValidator></asp:Panel>
                    Rows:<br />
                    <asp:TextBox ID="txtRows" runat="server" Width="30px" ValidationGroup="Apply Changes">4</asp:TextBox><asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtRows"
                        Display="Dynamic" ErrorMessage="Rows must be grater than 0" Operator="GreaterThanEqual"
                        Type="Integer" ValidationGroup="Apply Changes" ValueToCompare="1"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="enter a value"
                        ValidationGroup="Apply Changes" ControlToValidate="txtRows"></asp:RequiredFieldValidator><br />
                    Border Color:<br />
                    <asp:DropDownList ID="ddlBorderColor" runat="server">
                    </asp:DropDownList><br />
                    Border Style:<br />
                    <asp:DropDownList ID="ddlBorderStyle" runat="server">
                    </asp:DropDownList><br />
                    Border Width:<br />
                    <asp:TextBox ID="txtBorderWidth" runat="server" ValidationGroup="Apply Changes" Width="30px">0</asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtBorderWidth" Display="Dynamic" ErrorMessage="Border width must be grater than or equal 0" Operator="GreaterThanEqual" Type="Integer" ValidationGroup="Apply Changes" ValueToCompare="0"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ControlToValidate="txtBorderWidth" ErrorMessage="enter a value" ID="RequiredFieldValidator2" runat="server" ValidationGroup="Apply Changes"></asp:RequiredFieldValidator><br />
                    <asp:Button ID="btnApplyChanges" runat="server" OnClick="btnApplyChanges_Click" Text="Apply Changes" ValidationGroup="Apply Changes" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtNewItem" runat="server" ValidationGroup="New Item" Width="369px">This is a very long item text that requires an horizontal scroll bar</asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewItem"
                        Display="Dynamic" ErrorMessage="*" ValidationGroup="New Item"></asp:RequiredFieldValidator>
                    <asp:Button ID="btnNewItem" runat="server" Text="Add Item" ValidationGroup="New Item" OnClick="btnNewItem_Click" /></td>
                <td>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
