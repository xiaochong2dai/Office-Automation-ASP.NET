﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyDesk.aspx.cs" Inherits="MyDesk" %>
<html>
	<head>
		<title>企业OA综合管理平台</title>
  <LINK href="../Style/Style.css" type="text/css" rel="STYLESHEET">
</head>
<body>

<script type="text/javascript">
function SwitchMenu(theClass){
 var alldivTags=document.getElementsByTagName("div");
 for(i=0;i<alldivTags.length;i++){
  if(alldivTags[i].className==theClass) {   
   if(alldivTags[i].style.display=='none'){
    alldivTags[i].style.display='block';
   }else{
    alldivTags[i].style.display='none';
   }
  }
 }
}
</script>

<script language="javascript" >
function _delmodel(a)
{
    msg="确认不显示此模块吗?";
    if(window.confirm(msg))
    {    
      window.location.href ='MyDeskDel.aspx?ModelName='+a;
    }
}
</script>

    <form id="form1" runat="server">
    <div>    
     <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style="border-bottom: #006633 1px dashed; height: 30px;">&nbsp;<img src="../images/BanKuaiJianTou.gif" />
                我的办公桌
                </td>
                <td align="right" valign="middle" style="border-bottom: #006633 1px dashed; height: 30px;">
                    <a href="MyDeskSetting.aspx"> <img align="absMiddle" border="0" src="../images/Button/Setting.gif" /></a>
                    &nbsp;<img src="../images/Button/JianGe.jpg" />&nbsp;
                    <img class="HerCss" onclick="javascript:window.history.go(-1)" src="../images/Button/BtnExit.jpg" />&nbsp;</td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
    </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>        
    </form>
</body>
</html>