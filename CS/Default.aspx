<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <dx:ASPxGridView ID="ASPxGridView1" runat="server" OnAutoFilterCellEditorInitialize="ASPxGridView1_AutoFilterCellEditorInitialize"  OnProcessColumnAutoFilter="ASPxGridView1_ProcessColumnAutoFilter"
            AutoGenerateColumns="False">
            <Settings ShowFilterBar="Visible" ShowFilterRow="true" ShowFilterRowMenu="true" />
            <Columns>
                <dx:GridViewDataTextColumn FieldName="OrderID" Caption="Order #" VisibleIndex="0">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="EmployeeID" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn FieldName="OrderDate" VisibleIndex="3" Settings-FilterMode="Value"    >
                 <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy HH:mm" EditFormatString="dd/MM/yyyy HH:mm">
                 </PropertiesDateEdit>
                </dx:GridViewDataDateColumn>
            </Columns>
        </dx:ASPxGridView>
    </form>
</body>
</html>
