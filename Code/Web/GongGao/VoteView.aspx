﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VoteView.aspx.cs" Inherits="GongGao_VoteView" %>

<html>
<head>
    <title>阿琴小店协同办公服务平台</title>
    <link href="../Style/Style.css" type="text/css" rel="STYLESHEET">

    <script language="javascript">
  function PrintTable()
    {
        document.getElementById("PrintHide") .style.visibility="hidden"    
        print();
        document.getElementById("PrintHide") .style.visibility="visible"    
    }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="middle" style="border-bottom: #006633 1px dashed; height: 30px;">
                    &nbsp;<img src="../images/BanKuaiJianTou.gif" />
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;投票管理&nbsp;>>&nbsp;查看投票
                </td>
                <td align="right" valign="middle" style="border-bottom: #006633 1px dashed; height: 30px;">
                    &nbsp;<img class="HerCss" onclick="PrintTable()" src="../images/Button/BtnPrint.jpg" />&nbsp;
                    <img src="../images/Button/JianGe.jpg" />&nbsp;
                    <img class="HerCss" onclick="javascript:window.history.go(-1)" src="../images/Button/BtnExit.jpg" />&nbsp;
                </td>
            </tr>
            <tr>
                <td height="3px" colspan="2" style="background-color: #ffffff">
                </td>
            </tr>
        </table>
        <table style="width: 100%" bgcolor="#999999" border="0" cellpadding="2" cellspacing="1">
            <tr>
                <td align="right" style="width: 170px; background-color: #e1f5fc; height: 25px;">
                    投票主题：
                </td>
                <td style="background-color: #ffffff; height: 25px; padding-left: 5px;">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 170px; height: 25px; background-color: #e1f5fc">
                    投票选项：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 170px; height: 25px; background-color: #e1f5fc">
                    发布人：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 170px; height: 25px; background-color: #e1f5fc">
                    发布时间：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
